using SDK.UI.Widgets.Base;

namespace SDK.UI.Widgets.Interfaces
{
    public enum Align
    {
        Left,
        Center,
        Right
    }

    public delegate void TextEvent(IWidget caller);

    public interface ITextArea : IWidget
    {
        string Text { get; set; }
        string FontName { get; }
        Align TextAlign { get;}
        int FontSize { get; }
        Color FontColor { get; }
        GfxPoint TextOffset { get;}

        float TextWidth { get; }

        void SetFont(string font, Color color, int size);
        void SetFont(Color color, int size);
        void SetFont(Color color);
        void SetFont(int size);
        void SetAlign(Align align, GfxPoint offset);
        void SetAlign(Align align);

        event TextEvent OnTextChange;
    }
}