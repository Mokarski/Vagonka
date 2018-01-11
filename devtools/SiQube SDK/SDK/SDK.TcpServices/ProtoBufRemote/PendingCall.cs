using System;
using System.Threading;

namespace SDK.NetworksServices.ProtoBufRemote
{
    internal class PendingCall : IAsyncResult
    {
        private readonly int mId;
        private readonly string mServiceName;
        private readonly string mMethodName;
        private readonly AsyncCallback mAsyncCallback;
        private readonly object mAsyncState;
        private bool mIsCompleted;
        private bool mIsFailed;
        private string mServerErrorMessage;
        private readonly ManualResetEvent mWaitHandle = new ManualResetEvent(false);
        private RpcMessage.Parameter mResult;

        public PendingCall(int id, string serviceName, string methodName, AsyncCallback asyncCallback,
                           object asyncState)
        {
            mId = id;
            mServiceName = serviceName;
            mMethodName = methodName;
            mAsyncCallback = asyncCallback;
            mAsyncState = asyncState;
        }

        public int Id { get { return mId; } }

        public bool IsFailed { get { return mIsFailed || (!mIsFailed && !mIsCompleted); } }

        public string ServerErrorMessage { get { return mServerErrorMessage; } }

        public object AsyncState { get { return mAsyncState; } }

        public bool IsCompleted { get { return mIsCompleted; } }

        public bool CompletedSynchronously { get { return false; } }

        public WaitHandle AsyncWaitHandle { get { return mWaitHandle; } }

        public RpcMessage.Parameter Result { get { return mResult; } }

        public object GetResultAs(Type type)
        {
            //we shouldn't be trying to access the return type if the server returned nothing
            if (mResult == null)
                throw new InvalidRpcCallException(mServiceName, mMethodName,
                    String.Format("Server had no return type, was expecting a return type {0}.", type));

            object param;
            string errorMsg;
            if (!ParameterConverter.FromMessage(mResult, type, out param, out errorMsg))
            {
                throw new InvalidRpcCallException(mServiceName, mMethodName,
                    String.Format("Failed to convert the rpc return value to the expected return type {0} ({1}).",
                    type, errorMsg));
                
            }
            return param;
        }

        public void ReceiveResult(RpcMessage.Result resultMessage)
        {
            mResult = resultMessage.CallResult;
            mIsCompleted = true;
            mIsFailed = resultMessage.IsFailed;
            mServerErrorMessage = resultMessage.ErrorMessage;
            if (mAsyncCallback != null)
                mAsyncCallback(this);
            mWaitHandle.Set();
        }
    }
}