using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WVGA.Antioxidant
{
    public static class  Progress
    {
        public static ProgressBar ClassicBar(IWidget parent, int x, int y)
        {
            var rv = new ProgressBar(parent, x, y, 310, 20, 10);
            rv.Status.SetFont(Palette.White, 20);

            rv.Border = new VGSolidColor(Palette.LightGrey);
            var fill = new VGLinearGradient(0, 0, 0, rv.Height);
            fill.AddColor(0, new Color(0x006400FF));
            fill.AddColor(25, new Color(0x006400FF));
            fill.AddColor(100, Palette.Lime);

            rv.PercentLine = fill;

            return rv;
        }
    }
}
