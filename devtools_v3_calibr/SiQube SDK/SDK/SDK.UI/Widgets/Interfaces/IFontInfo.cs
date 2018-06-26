namespace SDK.UI.Widgets.Interfaces
{

    public struct Kerning
    {
        public uint key;
        public float x;
        public float y;
    };

    public class Glyph
    {
        public uint glyphIndex;
        public float[] origin;
        public float[] escapement;
        public byte[] commands;
        public float[] coordinates;
    };

    
    public interface IFontInfo
    {
        Glyph[] Glyphs { get; }
        Kerning[] Kernings { get; }
    }
}