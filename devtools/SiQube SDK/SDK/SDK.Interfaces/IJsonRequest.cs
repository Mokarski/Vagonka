namespace SDK.Interfaces
{
    public interface IJsonRequest
    {
        long Id { get; }
        string Method { get; }
        object Args { get; }
    }
}