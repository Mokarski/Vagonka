using System;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WVGA.Antioxidant
{

    static public class Buttons
    {
        private static VGLinearGradient SetPaint(Color up, Color down, int height)
        {
            var rv = new VGLinearGradient(0, 0, 0, height);
            rv.AddColor(0, down);
            rv.AddColor(30, up);
            rv.AddColor(100, up);
            return rv;
        }
        private static void SetText(IWidget rv, string text, int fontSize, float fontCoefficient)
        {
            //const int kFontSize = 25;
            //const float kBias = 0.85f;

            var lines = text.Split(new[] { "\\r", "\\n" }, StringSplitOptions.RemoveEmptyEntries);

            const int kFontBiasY = 3;
            var allTextHeight = fontSize * fontCoefficient * lines.Length;

            for (var i = 0; i < lines.Length; i++)
            {
                var line = new TextArea(rv, 0,
                                        (int)((rv.Height + allTextHeight * i - fontSize * fontCoefficient) / (lines.Length + 1)) - (lines.Length == 1 ? 0 : kFontBiasY),
                                        rv.Width, rv.Height) { Text = lines[lines.Length - i - 1] };

                line.SetAlign(Align.Center, new GfxPoint(0, kFontBiasY));
                line.SetFont(Palette.White, fontSize);
            }
        }

        #region Giant button

        private static IntPtr mGiantOutline;
        private static bool mGiantInitialized;
        private static VGLinearGradient mGiantActiveVGPaint;
        private static VGLinearGradient mGiantNormalVGPaint;
        private static VGSolidColor mGiantStrokeVGPaint;

        private static void InitGiant()
        {
            if(mGiantInitialized)
                return;

            const int kWidth = 230;
            const int kHeight = 90;
            const int kRound = 25;

            mGiantOutline = VGPath.OpenVGPath();

            VGU.vguRoundRect(mGiantOutline, 0, 0, kWidth, kHeight, kRound, kRound);

            mGiantStrokeVGPaint = new VGSolidColor(Palette.LightGrey);
            //mGiantNormalVGPaint = SetPaint(Palette.LightBlue, Palette.LightGrey, kHeight);
            mGiantNormalVGPaint = SetPaint(Palette.DarkGray, Palette.LightGrey, kHeight);
            mGiantActiveVGPaint = SetPaint(Palette.LightGrey, Palette.DarkGray, kHeight);

            mGiantInitialized = true;
        }


        public static Button GiantButton(IWidget parent, string text, int x, int y)
        {
            InitGiant();

            const int kFontSize = 40;
            const float kBias = 0.85f;

            var rv = new Button(parent, new VGPath(mGiantOutline, mGiantStrokeVGPaint, mGiantActiveVGPaint), new VGPath(mGiantOutline, mGiantStrokeVGPaint, mGiantNormalVGPaint));

            SetText(rv, text, kFontSize, kBias);

            rv.Move(x, y);

            return rv;
        }

        #endregion

        #region Classic button

        private static IntPtr mClassicOutline;
        private static bool mClassicInitialized;

        private static VGLinearGradient mClassicActiveVGPaintDefault;
        private static VGLinearGradient mClassicNormalVGPaintDefault;

        private static VGLinearGradient mClassicActiveVGPaintRed;
        private static VGLinearGradient mClassicNormalVGPaintRed;

        private static VGLinearGradient mClassicActiveVGPaintGreen;
        private static VGLinearGradient mClassicNormalVGPaintGreen;

        private static VGSolidColor mClassicStrokeVGPaint;

        private static void InitClassic()
        {
            if (mClassicInitialized)
                return;

            const int kWidth = 120;
            const int kHeight = 50;
            const int kRound = 15;

            mClassicOutline = VGPath.OpenVGPath();

            VGU.vguRoundRect(mClassicOutline, 0, 0, kWidth, kHeight, kRound, kRound);

            mClassicStrokeVGPaint = new VGSolidColor(Palette.LightGrey);

            #region default color
            //mClassicNormalVGPaintDefault = SetPaint(Palette.LightBlue, Palette.LightGrey, kHeight);
            mClassicNormalVGPaintDefault = SetPaint(Palette.DarkGray, Palette.LightGrey, kHeight);
            mClassicActiveVGPaintDefault = SetPaint(Palette.LightGrey, Palette.DarkGray, kHeight);
            #endregion

            #region red color
            //mClassicNormalVGPaintRed = SetPaint(Palette.LightBlue, Palette.Red, kHeight);
            mClassicNormalVGPaintRed = SetPaint(new Color(0x640000FF), Palette.Red, kHeight);
            mClassicActiveVGPaintRed = SetPaint(Palette.Red, new Color(0x640000FF), kHeight);
            #endregion

            #region green color
            //mClassicNormalVGPaintGreen = SetPaint(Palette.LightBlue, Palette.Lime, kHeight);
            //mClassicNormalVGPaintGreen = SetPaint(new Color(0x004623FF), Palette.Lime, kHeight);
            mClassicNormalVGPaintGreen = SetPaint(new Color(0x006400FF), Palette.Lime, kHeight);
            mClassicActiveVGPaintGreen = SetPaint(Palette.Lime, new Color(0x006400FF), kHeight);
            #endregion

            mClassicInitialized = true;
        }


        public static Button ClassicButton(IWidget parent, string text, int x, int y, ColorStyle style = ColorStyle.Default)
        {
            InitClassic();

            const int kFontSize = 24;
            const float kBias = 1.0f;

            Button rv = null;
            switch (style)
            {
                    case ColorStyle.Default:
                     rv = new Button(parent, new VGPath(mClassicOutline, mClassicStrokeVGPaint, mClassicActiveVGPaintDefault), new VGPath(mClassicOutline, mClassicStrokeVGPaint, mClassicNormalVGPaintDefault));
                    break;

                    case ColorStyle.Red:
                    rv = new Button(parent, new VGPath(mClassicOutline, mClassicStrokeVGPaint, mClassicActiveVGPaintRed), new VGPath(mClassicOutline, mClassicStrokeVGPaint, mClassicNormalVGPaintRed));
                    break;

                    case ColorStyle.Green:
                    rv = new Button(parent, new VGPath(mClassicOutline, mClassicStrokeVGPaint, mClassicActiveVGPaintGreen), new VGPath(mClassicOutline, mClassicStrokeVGPaint, mClassicNormalVGPaintGreen));
                    break;

            }

            if (rv == null)
                return null;

            SetText(rv, text, kFontSize, kBias);

            rv.Move(x, y);

            return rv;
        }

        #endregion

        #region Modal button

        private static IntPtr mModalOutline;
        private static bool mModalInitialized;

        private static VGLinearGradient mModalActiveVGPaintDefault;
        private static VGLinearGradient mModalNormalVGPaintDefault;

        private static VGLinearGradient mModalActiveVGPaintRed;
        private static VGLinearGradient mModalNormalVGPaintRed;

        private static VGLinearGradient mModalActiveVGPaintGreen;
        private static VGLinearGradient mModalNormalVGPaintGreen;

        private static VGSolidColor mModalStrokeVGPaint;

        private static void InitModal()
        {
            if (mModalInitialized)
                return;

            const int kWidth = 90;
            const int kHeight = 35;
            const int kRound = 10;

            mModalOutline = VGPath.OpenVGPath();

            VGU.vguRoundRect(mModalOutline, 0, 0, kWidth, kHeight, kRound, kRound);

            mModalStrokeVGPaint = new VGSolidColor(Palette.LightGrey);

            #region default color
            mModalNormalVGPaintDefault = SetPaint(Palette.DarkGray, Palette.LightGrey, kHeight);
            mModalActiveVGPaintDefault = SetPaint(Palette.LightGrey, Palette.DarkGray, kHeight);
            #endregion

            #region red color
            mModalNormalVGPaintRed = SetPaint(new Color(0x640000FF), Palette.Red, kHeight);
            mModalActiveVGPaintRed = SetPaint(Palette.Red, new Color(0x640000FF), kHeight);
            #endregion

            #region green color
            mModalNormalVGPaintGreen = SetPaint(new Color(0x006400FF), Palette.Lime, kHeight);
            mModalActiveVGPaintGreen = SetPaint(Palette.Lime, new Color(0x006400FF), kHeight);
            #endregion

            mModalInitialized = true;
        }


        public static Button ModalButton(IWidget parent, string text, int x, int y, ColorStyle style = ColorStyle.Default)
        {
            InitModal();

            const int kFontSize = 24;
            const float kBias = 0.85f;

            Button rv = null;
            switch (style)
            {
                case ColorStyle.Default:
                    rv = new Button(parent, new VGPath(mModalOutline, mModalStrokeVGPaint, mModalActiveVGPaintDefault), new VGPath(mModalOutline, mModalStrokeVGPaint, mModalNormalVGPaintDefault));
                    break;

                case ColorStyle.Red:
                    rv = new Button(parent, new VGPath(mModalOutline, mClassicStrokeVGPaint, mModalActiveVGPaintRed), new VGPath(mModalOutline, mModalStrokeVGPaint, mModalNormalVGPaintRed));
                    break;

                case ColorStyle.Green:
                    rv = new Button(parent, new VGPath(mModalOutline, mModalStrokeVGPaint, mModalActiveVGPaintGreen), new VGPath(mModalOutline, mModalStrokeVGPaint, mModalNormalVGPaintGreen));
                    break;

            }

            if (rv == null)
                return null;

            SetText(rv, text, kFontSize, kBias);

            rv.Move(x, y);

            return rv;
        }
        #endregion
    }

    public enum ColorStyle
    {
        Default,
        Red,
        Green
    }
}
