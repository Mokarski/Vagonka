using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Linq;

namespace SDK.NetworksServices.ProtoBufRemote
{
    internal class RpcMethodDescriptor
    {
        private readonly string mName;
        private readonly string mServiceName;
        private MethodInfo mSyncMethodInfo;
        private MethodInfo mAsyncBeginMethodInfo;
        private MethodInfo mAsyncEndMethodInfo;
        private Type[] mParameterTypes;
        private Type mReturnType;

        public RpcMethodDescriptor(MethodInfo methodInfo, RpcMethodAttribute attr, string serviceName)
        {
            mServiceName = serviceName;

            Type[] methodParamTypes = methodInfo.GetParameters().Select(p => p.ParameterType).ToArray();

            if (methodInfo.Name.StartsWith("Begin") && methodParamTypes.Length >= 2
                && methodInfo.ReturnType == typeof(IAsyncResult)
                && methodParamTypes[methodParamTypes.Length - 2] == typeof(AsyncCallback)
                && methodParamTypes[methodParamTypes.Length - 1] == typeof(object))
            {
                mAsyncBeginMethodInfo = methodInfo;
                mParameterTypes = methodParamTypes.Take(methodParamTypes.Length-2).ToArray();
                if (attr != null && attr.Name != null)
                    mName = attr.Name;
                else
                    mName = methodInfo.Name.Substring(5);
            }
            else if (methodInfo.Name.StartsWith("End") && methodParamTypes.Length == 1
                && methodParamTypes[0] == typeof(IAsyncResult))
            {
                mAsyncEndMethodInfo = methodInfo;
                mReturnType = methodInfo.ReturnType;
                if (attr != null && attr.Name != null)
                    mName = attr.Name;
                else
                    mName = methodInfo.Name.Substring(3);
            }
            else
            {
                mSyncMethodInfo = methodInfo;
                mParameterTypes = methodParamTypes;
                mReturnType = methodInfo.ReturnType;
                if (attr != null && attr.Name != null)
                    mName = attr.Name;
                else
                    mName = methodInfo.Name;
            }

            //verify parameters
            if (mParameterTypes != null)
            {
                foreach (Type paramType in mParameterTypes)
                {
                    if (!ParameterConverter.IsSupportedType(paramType))
                        throw new ArgumentException(
                            String.Format(
                                "Parameter of type '{0}' on method '{1}' in service '{2}' is not a supported type.",
                                paramType, methodInfo.Name, serviceName));
                }
            }

            //verify return type
            if (mReturnType != null && mReturnType != typeof(void))
            {
                if (!ParameterConverter.IsSupportedType(mReturnType))
                    throw new ArgumentException(
                        String.Format("Return type '{0}' of method '{1}' in service '{2}' is not a supported type",
                            mReturnType, mName, serviceName));
            }
        }

        public string Name { get { return mName; } }

        public bool HasAsyncDeclarations { get { return (mAsyncBeginMethodInfo != null); } }

        public MethodInfo SyncCallMethod { get { return mSyncMethodInfo; } }

        public MethodInfo AsyncBeginCallMethod { get { return mAsyncBeginMethodInfo; } }

        public MethodInfo AsyncEndCallMethod { get { return mAsyncEndMethodInfo; } }

        public Type[] ParameterTypes { get { return mParameterTypes; } }

        public Type ReturnType { get { return mReturnType; } }

        public void Merge(RpcMethodDescriptor method)
        {
            Debug.Assert(method.mName == mName && method.mServiceName == mServiceName);

            if (mReturnType != null && method.mReturnType != null && mReturnType != method.mReturnType)
                throw new ArgumentException(
                    String.Format("Invalid declarations for method '{0}', the return types are not consistent.", mName));

            if (mParameterTypes != null && method.mParameterTypes != null
                && !mParameterTypes.SequenceEqual(method.mParameterTypes))
                throw new ArgumentException(
                    String.Format("Invalid declarations for method '{0}', the parameter types are not consistent.", mName));

            if (mSyncMethodInfo != null && method.mSyncMethodInfo != null)
                throw new ArgumentException(
                    String.Format("Invalid declarations for method '{0}', more than one synchronous call found.", mName));
            if (mAsyncBeginMethodInfo != null && method.mAsyncBeginMethodInfo != null)
                throw new ArgumentException(
                    String.Format("Invalid declarations for method '{0}', more than one begin async call found.", mName));
            if (mAsyncEndMethodInfo != null && method.mAsyncEndMethodInfo != null)
                throw new ArgumentException(
                    String.Format("Invalid declarations for method '{0}', more than one end async call found.", mName));

            mReturnType = mReturnType ?? method.mReturnType;
            mParameterTypes = mParameterTypes ?? method.mParameterTypes;
            mSyncMethodInfo = mSyncMethodInfo ?? method.mSyncMethodInfo;
            mAsyncBeginMethodInfo = mAsyncBeginMethodInfo ?? method.mAsyncBeginMethodInfo;
            mAsyncEndMethodInfo = mAsyncEndMethodInfo ?? method.mAsyncEndMethodInfo;
        }

        public bool IsAsyncDeclarationValid()
        {
            if (mAsyncBeginMethodInfo != null && mAsyncEndMethodInfo != null)
                return true;
            if (mAsyncBeginMethodInfo == null && mAsyncEndMethodInfo == null)
                return true;
            return false;
        }

        public void Invoke(object service, IList<RpcMessage.Parameter> parameters, RpcMessage resultMessage)
        {
            ParameterInfo[] parameterInfos = mSyncMethodInfo.GetParameters();
            if (parameterInfos.Length != parameters.Count)
            {
                if (resultMessage != null)
                {
                    resultMessage.ResultMessage.IsFailed = true;
                    resultMessage.ResultMessage.ErrorMessage = String.Format(
                        "Wrong number of parameters for method '{1}' in service '{0}'", mServiceName, Name);
                }
                return;
            }

            var invokeParameters = new object[parameters.Count];
            for (int i=0; i<parameters.Count; ++i)
            {
                string errorMsg;
                if (!ParameterConverter.FromMessage(parameters[i], parameterInfos[i].ParameterType,
                    out invokeParameters[i], out errorMsg))
                {
                    if (resultMessage != null)
                    {
                        resultMessage.ResultMessage.IsFailed = true;
                        resultMessage.ResultMessage.ErrorMessage = String.Format(
                            "Parameter {0} could not be converted to expected type '{1}' for method '{2}' in service '{3}' ({4}).",
                            i, parameterInfos[i].ParameterType, Name, mServiceName, errorMsg);
                    }
                    return;
                }
            }

            object result = mSyncMethodInfo.Invoke(service, invokeParameters);

            if (resultMessage != null)
            {
                RpcMessage.Parameter resultParameter;
                string errorMsg;
                if (ParameterConverter.ToMessage(result, out resultParameter, out errorMsg))
                {
                    resultMessage.ResultMessage.CallResult = resultParameter;
                }
                else
                {
                    resultMessage.ResultMessage.IsFailed = true;
                    resultMessage.ResultMessage.ErrorMessage = String.Format(
                        "Result type {0} could not be converted to a message for method '{1}' in service '{2}' ({3}).",
                        mSyncMethodInfo.ReturnType, Name, mServiceName, errorMsg);
                }
            }
        }
    }
}
