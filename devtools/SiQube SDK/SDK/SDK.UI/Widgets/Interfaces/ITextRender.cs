using System;

namespace SDK.UI.Widgets.Interfaces
{
    public interface ITextRender : IDisposable
    {
        void RenderText(string text);
        float[] GetEscapement(string text);
    }
}