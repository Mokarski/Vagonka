using System.Collections.Generic;
using ProtoBuf;
using SDK.SignalsFactory.Interface;

namespace SDK.SignalsFactory.ProtoChannel.Interface
{
    public interface ISignalsClient
    {
        SignalsResponse GetStatus(SignalsRequest id);
        SignalSpecificationResponse GetSignals();
        bool Update(string id, float value);
        ConfigSectionsResponse GetConfig();
    }

    [ProtoContract]
    public class ConfigSectionsResponse
    {
        [ProtoMember(1)]
        public List<ConfigSectionResponse> Sections { get; set; }
    }

    [ProtoContract]
    public class ConfigSectionResponse
    {
        [ProtoMember(1)]                
        public string Url { get; set; }

        [ProtoMember(2)]
        public string Description { get; set; }

        [ProtoMember(3)]        
        public List<ConfigRecord> Specs { get; set; }
    }

    [ProtoContract]
    public class SignalSpecificationResponse
    {
        [ProtoMember(1)]
        public List<ConfigRecord> Specs { get; set; }
    }

    [ProtoContract]
    public class SignalsRequest
    {
        public SignalsRequest()
        {
        }

        public SignalsRequest(List<string> ids)
        {
            Ids = ids;
        }

        [ProtoMember(1)]
        public List<string> Ids { get; set; }
    }

    [ProtoContract]
    public class SignalsResponse
    {
        [ProtoMember(1)]
        public List<SignalStatus> Signals { get; set; }
    }
}