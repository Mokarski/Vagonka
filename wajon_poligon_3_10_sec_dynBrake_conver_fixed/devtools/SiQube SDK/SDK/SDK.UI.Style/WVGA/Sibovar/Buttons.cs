using System;
using System.Collections.Generic;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WVGA.Sibovar
{
    static public class Buttons
    {
        public class ButtonPanel
        {
            private readonly List<Button> mLeft;
            private readonly List<Button> mRight;
            private readonly List<Button> mDown;
            private readonly Button mLArroy;
            private readonly Button mRArroy;
            private readonly int[] mLeftHotkeys = new[]{2, 16, 30};
            //private readonly char[] mLeftHotkeys = new[]{'1', 'Q', 'A'};
            private readonly int[] mRightHotkeys = new[] {7, 21, 35};
            //private readonly char[] mRightHotkeys = new[] {'6', 'Y', 'H'};
            private readonly int[] mDownHotkeys = new[] { 44, 45, 46, 47, 48, 49};
            //private readonly char[] mDownHotkeys = new[] { 'Z', 'X', 'C', 'V', 'B', 'N'};

            const int kButtonBiasY = 64;
            const int kButtonBiasX = 78;
            
            private const int kButtonArroyBiasY = 270;
            private const int kButtonSideY = 186;
            private const int kButtonDownX = 12;
            private const int kButtonBias = -5;

            public ButtonPanel(IWidget parent, string[] left, string[] down, string[] right)
            {
                mLeft = new List<Button>();
                for (var i = 0; i < mLeftHotkeys.Length; i++)
                {
                    mLeft.Add(SideButton(parent, left[i], kButtonBias, kButtonSideY - kButtonBiasY*i));
                    mLeft[i].HotKeycode = mLeftHotkeys[i];
                }

                mRight = new List<Button>();
                for (var i = 0; i < mRightHotkeys.Length; i++)
                {
                    mRight.Add(SideButton(parent, right[i], 480 - kButtonBias - mLeft[0].Width, kButtonSideY - kButtonBiasY * i));
                    mRight[i].HotKeycode = mRightHotkeys[i];

                }

                mDown = new List<Button>();
                for (var i = 0; i < mDownHotkeys.Length; i++)
                {
                    mDown.Add(DownButton(parent, down[i], kButtonDownX + kButtonBiasX * i, kButtonBias));
                    mDown[i].HotKeycode = mDownHotkeys[i];

                }

                mLArroy = SideButton(parent, "left", kButtonBias, kButtonArroyBiasY);
                mLArroy.HotKeycode = 38;// 'L';
                mRArroy = SideButton(parent, "right", 480 - kButtonBias - mLeft[0].Width, kButtonArroyBiasY);
                mRArroy.HotKeycode = 19;// 'R';
            }

            public Button[] Left { get { return mLeft.ToArray(); } }
            public Button[] Right { get { return mRight.ToArray(); } }
            public Button[] Down { get { return mDown.ToArray(); } }
            public Button LArroy { get { return mLArroy; } }
            public Button RArroy { get { return mRArroy; } }
        }
        

        
        private static VGLinearGradient SetPaint(Color up, Color down, int height)
        {
            var rv = new VGLinearGradient(0, 0, 0, height);
            rv.AddColor(0, down);
            //rv.AddColor(30, up);
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
                                        (int)((rv.Height + allTextHeight * i - fontSize * fontCoefficient) / (lines.Length + 1)),// - (lines.Length == 1 ? 0 : kFontBiasY),
                                        rv.Width, rv.Height) { Text = lines[lines.Length - i - 1] };

                line.SetAlign(Align.Center, new GfxPoint(0, kFontBiasY));
                line.SetFont(text == "резерв" ? new Color(0x808285FF) : Palette.White, fontSize);
            }
        }

        #region Quad button

        private static IntPtr mQuadOutline;
        private static bool mQuadInitialized;


        private static VGLinearGradient mQuadActiveVGPaintDefault;

        private static void InitQuad()
        {
            if (mQuadInitialized)
                return;


            const int kButtonsWidth = 62;
            const int kButtonsHeight = 45;
            
            mQuadOutline = VGPath.OpenVGPath();

            VGU.vguRect(mQuadOutline, 0, 0, kButtonsWidth, kButtonsHeight);

            #region default color
            mQuadActiveVGPaintDefault = SetPaint(Palette.Black, new Color(0x58595BFF), kButtonsHeight);
            #endregion

            mQuadInitialized = true;
        }


        public static Button QuadButton(IWidget parent, string text, int x, int y, ColorStyle style = ColorStyle.Default)
        {
            InitQuad();

            const int kFontSize = 15;
            const float kBias = 1.0f;

            var contour = new VGPath(mQuadOutline, new VGSolidColor(new Color(0x00AEEFFF)), mQuadActiveVGPaintDefault) { StrokeWidth = 2.0f };
            var rv = new Button(parent, contour, new VGPath(mQuadOutline, new VGSolidColor(Palette.White), new VGSolidColor(new Color(0x3B3C3DFF))));
            SetText(rv, text, kFontSize, kBias);
            //rv.IsCached = true;

            rv.Move(x, y);

            return rv;
        }

        #endregion

        #region Side button

        private static IntPtr mClassicOutline;
        private static bool mClassicInitialized;


        private static VGLinearGradient mClassicActiveVGPaintDefault;

        private static bool mDownInitialized;
        private static IntPtr mDownOutline;


        private static void InitSide()
        {
            if (mClassicInitialized)
                return;

            const int kWidth = 68;
            const int kHeight = 45;
            const int kRound = 10;

            mClassicOutline = VGPath.OpenVGPath();

            VGU.vguRoundRect(mClassicOutline, 0, 0, kWidth, kHeight, kRound, kRound);

            #region default color
            mClassicActiveVGPaintDefault = SetPaint(Palette.Black, new Color(0x58595BFF), kHeight);
            #endregion

            mClassicInitialized = true;
        }


        public static Button SideButton(IWidget parent, string text, int x, int y, ColorStyle style = ColorStyle.Default)
        {
            InitSide();

            const int kFontSize = 15;
            const float kBias = 1.0f;

            var contour = new VGPath(mClassicOutline, new VGSolidColor(new Color(0x00AEEFFF)), mClassicActiveVGPaintDefault) { StrokeWidth = 1.5f };
            var rv = new Button(parent, contour, new VGPath(mClassicOutline, null, new VGSolidColor(new Color(0x3B3C3DFF))));   
            SetText(rv, text, kFontSize, kBias);
            //rv.IsCached = true;

            rv.Move(x, y);

            return rv;
        }

        #endregion

        #region Down button
        private static void InitDown()
        {
            if (mDownInitialized)
                return;

            const int kWidth = 62;
            const int kHeight = 34;
            const int kRound = 10;

            mDownOutline = VGPath.OpenVGPath();

            VGU.vguRoundRect(mDownOutline, 0, 0, kWidth, kHeight, kRound, kRound);

            #region default color
            mClassicActiveVGPaintDefault = SetPaint(Palette.Black, new Color(0x58595BFF), kHeight);
            #endregion

            mDownInitialized = true;
        }

        public static Button DownButton(IWidget parent, string text, int x, int y, ColorStyle style = ColorStyle.Default)
        {
            InitDown();

            const int kFontSize = 15;
            const float kBias = 1.0f;

            var contour = new VGPath(mDownOutline, new VGSolidColor(new Color(0x00AEEFFF)), mClassicActiveVGPaintDefault) { StrokeWidth = 1.5f };
            var rv = new Button(parent, contour, new VGPath(mDownOutline, null, new VGSolidColor(new Color(0x3B3C3DFF))));//new Color(0x3B3C3DFF)
            SetText(rv, text, kFontSize, kBias);
            //rv.IsCached = true;

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
