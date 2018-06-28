using Jayrock.JsonRpc;
using Jayrock.Services;

namespace SDK.Rpc.Common
{
    public class BaseService : IService
    {
        private ServiceClass mClass;

        public virtual ServiceClass GetClass()
        {
            return mClass ?? (mClass = JsonRpcServices.GetClassFromType(GetType()));
        }
    }
}
