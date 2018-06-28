using System;

namespace SDK.NetworksServices.ProtoBufRemote
{
    public abstract class RpcChannel : IDisposable
    {
        private readonly RpcController mController;

        protected RpcChannel(RpcController controller)
        {
            mController = controller;
            controller.Channel = this;
        }

        internal abstract void Send(RpcMessage message);

        /// <summary>
        /// Handles a message which has been received. Can be called by multiple threads concurrently, it is up to the
        /// RpcClient and RpcServer to ensure they are thread-safe.
        /// </summary>
        /// <returns></returns>
        protected void Receive(RpcMessage message)
        {
            mController.Receive(message);
        }

        public abstract void Stop();

        /// <summary>
        /// Количество принятых данных
        /// </summary>
        public abstract long TotalBytesRead { get; }

        /// <summary>
        /// Количество переданных данных
        /// </summary>
        public abstract long TotalBytesWritten { get; }

        /// <summary>
        /// Активен и готов к работе
        /// </summary>
        public virtual bool IsReady { get; internal set; }
        
        /// <summary>
        /// Защита в работе
        /// </summary>
        public Action OnError;

        /// <summary>
        /// Стартуем работу нашего канала
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Чистим хвосты
        /// </summary>
        public virtual void Dispose() { Stop(); }

    }
}
