namespace SDK.SignalsFactory.Interface
{
    public class MenuConfigSection
    {
        public string Id { get; private set; }
        public string ParentId { get; private set; }
        public string Description { get; private set; }
        public string[] Childs { get; private set; }
        public string[] Signals { get; internal set; }
    }
    
    public interface IRemoteSignalsFactory
    {             
        IReadonlySignal GetSignal(string id);
        bool Update(IReadonlySignal signal, float value);
        bool Update(string signalId, float value);

        MenuConfigSection GetMenuConfig(string sectionId);
    }
}