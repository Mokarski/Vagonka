namespace SDK.UI.Widgets.Interfaces
{
    public interface IImage
    {
        bool Load(string url);
        void Scale(float scaleX, float scaleY);
    }
}