namespace SDK.NetworksServices.ProtoBufRemote
{
    /// <summary>
    /// A dummy RPC channel which just returns all sent messages to itself, useful for testing.
    /// </summary>
    public class LoopbackRpcChannel : RpcChannel
    {
        public LoopbackRpcChannel(RpcController controller) : base(controller)
        {
        }

        internal override void Send(RpcMessage message)
        {
            Receive(message);
        }

        public override void Stop()
        {
            throw new System.NotImplementedException();
        }

        public override long TotalBytesRead
        {
            get { throw new System.NotImplementedException(); }
        }

        public override long TotalBytesWritten
        {
            get { throw new System.NotImplementedException(); }
        }

        public override void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}
