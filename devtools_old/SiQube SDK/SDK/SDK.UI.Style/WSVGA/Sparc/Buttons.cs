using System;
using System.Collections.Generic;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WSVGA.Sparc
{

    static public class Buttons
    {
        public class ButtonPanel
        {
            private readonly List<Button> mLeft;
            private readonly List<Button> mRight;
            private readonly List<Button> mDown;
            private readonly char[] mLeftHotkeys = new[] { '1', '2', '3', '4' };
            private readonly char[] mDownHotkeys = new[] { 'Q', 'W', 'E', 'R', 'T', 'Y'};
            private readonly char[] mRightHotkeys = new[] { 'A', 'S', 'D', 'F' };


            const int kButtonBiasY = 127;//132
            //const int kButtonBiasY = 110;//132
            const int kButtonBiasX = 148;

            private const int kButtonSideY = 480; // 635, 503, 371, 239, 107
            //private const int kButtonSideY = 425; // 635, 503, 371, 239, 107
            private const int kButtonDownX = 65;
            private const int kButtonBias = -5;

            public ButtonPanel(IWidget parent, string[] left, string[] down, string[] right)
            {
                mLeft = new List<Button>();
                for (var i = 0; i < mLeftHotkeys.Length; i++)
                {
                    mLeft.Add(SideButton(parent, left[i], kButtonBias, kButtonSideY - kButtonBiasY * i));
                    mLeft[i].HotKeycode = mLeftHotkeys[i];
                }

                mRight = new List<Button>();
                for (var i = 0; i < mRightHotkeys.Length; i++)
                {
                    mRight.Add(SideButton(parent, right[i], Application.Screen.Width - kButtonBias - mLeft[0].Width, kButtonSideY - kButtonBiasY * i));
                    mRight[i].HotKeycode = mRightHotkeys[i];

                }

                mDown = new List<Button>();
                for (var i = 0; i < mDownHotkeys.Length; i++)
                {
                    mDown.Add(DownButton(parent, down[i], kButtonDownX + kButtonBiasX * i, kButtonBias));
                    mDown[i].HotKeycode = mDownHotkeys[i];
                }
            }

            public Button[] Left { get { return mLeft.ToArray(); } }
            public Button[] Right { get { return mRight.ToArray(); } }
            public Button[] Down { get { return mDown.ToArray(); } }
        }
        
        
        private static VGLinearGradient SetPaint(Color up, Color down, int height)
        {
            var rv = new VGLinearGradient(0, 0, 0, height);
            rv.AddColor(0, down);
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

            var tmp = new List<TextArea>();

            for (var i = 0; i < lines.Length; i++)
            {
                var line = new TextArea(rv, 0,
                                        (int)((rv.Height + allTextHeight * i - fontSize * fontCoefficient) / (lines.Length + 1)),// - (lines.Length == 1 ? 0 : kFontBiasY),
                                        rv.Width, rv.Height) { Text = lines[lines.Length - i - 1] };

                line.SetAlign(Align.Center, new GfxPoint(0, kFontBiasY));   
                tmp.Add(line);
            }

            foreach (var area in tmp)
            {
                area.SetFont(rv.IsActive ? Palette.White : new Color(0x808285FF), fontSize);
            }

            rv.OnActivate = rv.OnDeactivate = caller =>
                                {
                                    foreach (var area in tmp)
                                    {
                                        area.SetFont(rv.IsActive ? Palette.White : new Color(0x808285FF), fontSize);                                        
                                    }

                                    if(rv as Button != null)
                                        ((Button)(rv)).Invalidate();
                                };
        }

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

            const int kWidth = 120;
            const int kHeight = 75;
            const int kRound = 12;

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

            var rv = Button(parent, text, mClassicOutline);
            rv.Move(x, y);

            return rv;
        }

        #endregion


        private static void InitDown()
        {
            if (mDownInitialized)
                return;

            const int kWidth = 107;
            const int kHeight = 60;
            const int kRound = 12;

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

            var rv = Button(parent, text, mDownOutline);
            rv.Move(x, y);

            return rv;
        }

        private static Button Button(IWidget parent, string text, IntPtr path)
        {
            var isActivated = !(text == "резерв" || text == "");

            var contour = new VGPath(path, new VGSolidColor(new Color(0x00AEEFFF)), mClassicActiveVGPaintDefault){StrokeWidth = 3.0f};

            var rv = new Button(parent, contour, new VGPath(path, null, new VGSolidColor(new Color((uint) (isActivated ? 0x3B3C3DFF : 0x3B3C3D6F)))));
            
            rv.Activate(isActivated);

            const int kFontSize = 25;
            const float kBias = 1.0f;
            SetText(rv, text, kFontSize, kBias);

            return rv;
        }
    }

    public enum ColorStyle
    {
        Default,
        Red,
        Green
    }
}
