using System.Dynamic;

namespace SDK.NetworksServices.ProtoBufRemote
{
    internal class DynamicCallResult : DynamicObject
    {
        private readonly PendingCall mPendingCall;

        public DynamicCallResult(PendingCall pendingCall)
        {
            mPendingCall = pendingCall;
        }

        public override bool TryConvert(ConvertBinder binder, out object result)
        {
            result = mPendingCall.GetResultAs(binder.Type);
            return true;
        }
    }
}
