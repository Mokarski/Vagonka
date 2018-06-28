using System;

namespace SDK.NetworksServices.ProtoBufRemote
{
    public class Proxy
    {
        private readonly RpcClient mClient;
        private readonly string mServiceName;

        public Proxy(RpcClient client, string serviceName)
        {
            mClient = client;
            mServiceName = serviceName;
        }

        protected void CallWithoutResultHelper(string methodName, RpcMessage.Parameter[] parameters)
        {
            mClient.CallWithoutResult(mServiceName, methodName, parameters);
        }

        protected RpcMessage.Parameter BlockingCallHelper(string methodName, RpcMessage.Parameter[] parameters)
        {
            if (mClient.IsReady)
            {
                var asyncResult = BeginAsyncCallHelper(methodName, parameters, null, null);
                return EndAsyncCallHelper(methodName, asyncResult);
            }

            throw new InvalidRpcCallException(mServiceName, methodName, String.Format("Server failed to process call."));
        }

        protected IAsyncResult BeginAsyncCallHelper(string methodName, RpcMessage.Parameter[] parameters, AsyncCallback callback, object state)
        {
            return mClient.Call(mServiceName, methodName, parameters, callback, state);
        }

        protected RpcMessage.Parameter EndAsyncCallHelper(string methodName, IAsyncResult asyncResult)
        {
            var pendingCall = (PendingCall)asyncResult;

            if (mClient.IsReady)
            {
                pendingCall.AsyncWaitHandle.WaitOne(mClient.ResponseTimeout);
                pendingCall.AsyncWaitHandle.Close();
            }

            if (pendingCall.IsFailed)
                throw new InvalidRpcCallException(mServiceName, methodName,
                    String.Format("Server failed to process call, returned error message: \"{0}\".",
                    pendingCall.ServerErrorMessage));

            return pendingCall.Result;
        }
    }
}
