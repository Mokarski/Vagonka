using System;
using System.Collections.Generic;
using System.Linq;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets
{
    public static class Utils
    {
        //            window.SetParent(CreateLargeButton(340, 125, new[] { "Button1", "txt" }, new Color { R = 0f, G = 1f, B = 0f }));
        //            window.SetParent(CreateLargeButton(340, 185, new[] { "Button1", "txt" }, new Color { R = 153/255f, G = 217/255f, B = 234/255f }));
        //            var downButton = CreateLargeButton(340, 5, new[] {"Далее"}, new Color {R = 1f, G = 0f, B = 0f});
        //            var upButton = CreateLargeButton(340, 65, new[] {"Button1", "txt"}, null);

        public static Button PickButton(int x, int y, string text, Color color)
        {
            const int kWidth = 45;
            const int kHeight = kWidth;
            const float kRound = 10f;

            var btn = new Button("pickButton", x, y, kWidth, kHeight, kRound);

            if (color != null)
                btn.PressColor = color;


            const int kSize = 32;
            const int kBias = 5;
            btn.AddChild(new TextArea(btn, "", null, x, (btn.Height - kSize) / 2 + kBias + y, btn.Width, btn.Height) { Text = text, Size = kSize, Align = Align.Center });


            return btn;
        }

        public static Button ModalButton(int x, int y, string[] text, Color color)
        {
            const int kWidth = 90;
            const int kHeight = 35;
            const float kRound = 10f;

            var btn = new Button("modalButton", x, y, kWidth, kHeight, kRound);

            if (color != null)
                btn.PressColor = color;

            switch (text.Length)
            {
                case 1:
                    {
                        const int kSize = 22;
                        const int kBias = 5;
                        btn.AddChild(new TextArea(btn, "", null, x, (btn.Height - kSize) / 2 + kBias + y, btn.Width, btn.Height) { Text = text[0], Size = kSize, Align = Align.Center });
                    }
                    break;

                case 2:
                    {
                        const int kSize = 18;
                        const int kBias = 0;
                        btn.AddChild(new TextArea(btn, "", null, x, (btn.Height - kSize) + kBias + y, btn.Width, btn.Height) { Text = text[0], Size = kSize, Align = Align.Center });
                        btn.AddChild(new TextArea(btn, "", null, x, btn.Height - (kSize * 2) + kBias + y, btn.Width, btn.Height) { Text = text[1], Size = kSize, Align = Align.Center });
                    }
                    break;

                case 3:
                    {
                        const int kSize = 13;
                        const int kBias = -2;
                        btn.AddChild(new TextArea(btn, "", null, x, (btn.Height - kSize) + kBias + y, btn.Width, btn.Height) { Text = text[0], Size = kSize, Align = Align.Center });
                        btn.AddChild(new TextArea(btn, "", null, x, btn.Height - (kSize * 2) + kBias + y, btn.Width, btn.Height) { Text = text[1], Size = kSize, Align = Align.Center });
                        btn.AddChild(new TextArea(btn, "", null, x, btn.Height - (kSize * 3) + kBias + y, btn.Width, btn.Height) { Text = text[2], Size = kSize, Align = Align.Center });
                    }
                    break;
            }

            return btn;
        }

        public static Button ClassicButton(int x, int y, string[] text, Color color)
        {
            //const int kWidth = 125; // TA
            //const int kHeight = 45; // TA

            const int kWidth = 115;
            const int kHeight = 40;
            const float kRound = 20f;

            var btn = new Button("classicButton", x, y, kWidth, kHeight, kRound);

            if (color != null)
                btn.PressColor = color;

            switch (text.Length)
            {
                case 1:
                    {
                        const int kSize = 22;
                        const int kBias = 5;
                        btn.AddChild(new TextArea(btn, "", null, 0, (btn.Height - kSize) / 2 + kBias, btn.Width, btn.Height) { Text = text[0], Size = kSize, Align = Align.Center });
                    }
                    break;

                case 2:
                    {
                        const int kSize = 18;
                        const int kBias = 0;
                        btn.AddChild(new TextArea(btn, "", null, 0, (btn.Height - kSize) + kBias, btn.Width, btn.Height) { Text = text[0], Size = kSize, Align = Align.Center });
                        btn.AddChild(new TextArea(btn, "", null, 0, btn.Height - (kSize * 2) + kBias, btn.Width, btn.Height) { Text = text[1], Size = kSize, Align = Align.Center });
                    }
                    break;

                case 3:
                    {
                        const int kSize = 13;
                        const int kBias = -2;
                        btn.AddChild(new TextArea(btn, "", null, 0, (btn.Height - kSize) + kBias, btn.Width, btn.Height) { Text = text[0], Size = kSize, Align = Align.Center });
                        btn.AddChild(new TextArea(btn, "", null, 0, btn.Height - (kSize * 2) + kBias, btn.Width, btn.Height) { Text = text[1], Size = kSize, Align = Align.Center });
                        btn.AddChild(new TextArea(btn, "", null, 0, btn.Height - (kSize * 3) + kBias, btn.Width, btn.Height) { Text = text[2], Size = kSize, Align = Align.Center });
                    }
                    break;
            }

            return btn;
        }

        public static Button LargeButton(int x, int y, string[] text, Color color)
        {
            const int kWidth = 235;
            const int kHeight = 90;
            const float kRound = 20f;

            var btn = new Button("largeButton", x, y, kWidth, kHeight, kRound);

            if (color != null)
                btn.PressColor = color;

            switch (text.Length)
            {
                case 1:
                    {
                        const int kSize = 28;
                        const int kBias = 5;
                        btn.AddChild(new TextArea(btn, "", null, 0, (btn.Height - kSize) / 2 + kBias, btn.Width, btn.Height) { Text = text[0], Size = kSize, Align = Align.Center });
                    }
                    break;

                case 2:
                    {
                        const int kSize = 18;
                        const int kBias = 0;

                        btn.AddChild(new TextArea(btn, "", null, 0, (btn.Height - kSize) + kBias, btn.Width, btn.Height) { Text = text[0], Size = kSize, Align = Align.Center });
                        btn.AddChild(new TextArea(btn, "", null, 0, btn.Height - (kSize * 2) + kBias, btn.Width, btn.Height) { Text = text[1], Size = kSize, Align = Align.Center });
                    }
                    break;
            }

            return btn;
        }
    }

    public class FlatButton : Widget
    {
        private readonly float mRound;

        private readonly IntPtr mPath = IntPtr.Zero;
        private readonly IntPtr mPaint = IntPtr.Zero;

        public FlatButton(string aName, int x, int y, int width, int height, float round)
            : base(null, aName)
        {
            X = x;
            Y = y;

            Width = width;
            Height = height;

            mRound = round;

            const float kColor = 252f / 256f;
            PressColor = new Color { R = kColor, G = kColor, B = kColor };

            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            mPaint = VG.vgCreatePaint();
        }

        public Color PressColor { get; set; }


        public override void Update()
        {
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
            VG.vgLoadIdentity();

            #region fill rect
            {
                VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);

                if (State == ButtonState.Released)
                {
                    VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, PressColor.Value);
                }
                else
                {
                    var release = new Color
                                        {
                                            A = PressColor.A,
                                            R = PressColor.R * 0.7f,
                                            G = PressColor.G * 0.7f,
                                            B = PressColor.B * 0.7f
                                        };
                    VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, release.Value);
                }

                VG.vgSetPaint(mPaint, VGPaintMode.VG_FILL_PATH);

                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 1.0f);
                VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                VGU.vguRoundRect(mPath, X, Y, Width, Height, mRound, mRound);
                VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
            }
            #endregion

            base.Update();
        }


        public override void Dispose()
        {
            if (mPath != new IntPtr())
                VG.vgDestroyPath(mPath);

            if (mPaint != new IntPtr())
                VG.vgDestroyPaint(mPaint);
        }
    }

    public class Button : Widget
    {
        private readonly float mRound;

        private readonly IntPtr mPath = IntPtr.Zero;
        private readonly IntPtr mPaint = IntPtr.Zero;

        public Button(string aName, int x, int y, int width, int height, float round)
            : base(null, aName)
        {
            X = x;
            Y = y;

            Width = width;
            Height = height;

            mRound = round;

            const float kColor = 252f / 256f;
            PressColor = new Color { R = kColor, G = kColor, B = kColor };

            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            mPaint = VG.vgCreatePaint();
        }

        public Color PressColor { get; set; }

        public override void Update()
        {
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
            VG.vgLoadIdentity();

            #region fill rect
            {
                var colStops = new float[25];// xRGBA


                colStops[0] = 0.0f; colStops[1] = PressColor.R * 0.7f; colStops[2] = PressColor.G * 0.7f; colStops[3] = PressColor.B * 0.7f; colStops[4] = PressColor.A * 1.0f;
                colStops[5] = 0.2f; colStops[6] = PressColor.R * 1.0f; colStops[7] = PressColor.G * 1.0f; colStops[8] = PressColor.B * 1.0f; colStops[9] = PressColor.A * 1.0f;

                // Fill with linear gradient paint 
                //VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
                VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_LINEAR_GRADIENT);
                //VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_RADIAL_GRADIENT);

                if (State == ButtonState.Pressed)
                {
                    //VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, PressColor.Value);

                    colStops[1] = PressColor.R * 0.4f;
                    colStops[2] = PressColor.G * 0.4f;
                    colStops[3] = PressColor.B * 0.4f;
                    colStops[6] = PressColor.R * 0.7f;
                    colStops[7] = PressColor.G * 0.7f;
                    colStops[8] = PressColor.B * 0.7f;
                    VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_LINEAR_GRADIENT, 4, new float[] { X, Y, X, Y + Height });
                    //VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_RADIAL_GRADIENT, 5, new float[] { mX + mWidth / 2, mY,
                    //                                                                                             mX + mWidth / 2, mY + mHeight * 2,
                    //                                                                                             mWidth  });
                }
                else
                {
                    //VG.vgTranslate(3,-3);
                    //VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, ReleaseColor.Value);

                    colStops[1] = PressColor.R * 0.7f;
                    colStops[2] = PressColor.G * 0.7f;
                    colStops[3] = PressColor.B * 0.7f;
                    colStops[6] = PressColor.R * 1.0f;
                    colStops[7] = PressColor.G * 1.0f;
                    colStops[8] = PressColor.B * 1.0f;
                    VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_LINEAR_GRADIENT, 4, new float[] { X, Y, X, Y + Height });
                    //VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_RADIAL_GRADIENT, 5, new float[] { mX + mWidth / 2, mY,
                    //                                                                                             mX + mWidth / 2, mY - mHeight * 2,
                    //                                                                                             mWidth  });
                }

                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR_RAMP_STOPS, 10, colStops);

                VG.vgSetPaint(mPaint, VGPaintMode.VG_FILL_PATH);

                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 1.0f);
                VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                VGU.vguRoundRect(mPath, X, Y, Width, Height, mRound, mRound);
                VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
                VG.vgFinish();
            }
            #endregion

            #region draw line
            {
                VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { 1.0f, 1.0f, 1.0f, 1.0f });
                VG.vgSetPaint(mPaint, VGPaintMode.VG_STROKE_PATH);

                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 3.0f);
                VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                VGU.vguRoundRect(mPath, X, Y, Width, Height, mRound, mRound);
                VG.vgDrawPath(mPath, VGPaintMode.VG_STROKE_PATH);
                VG.vgFinish();
            }
            #endregion


            base.Update();
        }


        public override void Dispose()
        {
            if (mPath != new IntPtr())
                VG.vgDestroyPath(mPath);

            if (mPaint != new IntPtr())
                VG.vgDestroyPaint(mPaint);
        }
    }

    public class SparcButton : Widget
    {
        private readonly float mRound;

        private readonly IntPtr mPath = IntPtr.Zero;
        private readonly IntPtr mPaint = IntPtr.Zero;
        private readonly IntPtr mCache = IntPtr.Zero;
        private bool mIsRealUpdate;
        private readonly List<Widget> mPressLock = new List<Widget>();

        public SparcButton(string aName, int x, int y, int width, int height, float round, string url)
            : base(null, aName)
        {
            X = x;
            Y = y;

            Width = width;
            Height = height;

            mRound = round;

            //const float kColor = 252f / 256f;
            //PressColor = new Color { R = kColor, G = kColor, B = kColor };

            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            mPaint = VG.vgCreatePaint();

            mCache = VG.vgCreateImage(PixelFormat, Width + 2 , Height + 2, VGImageQuality.VG_IMAGE_QUALITY_NONANTIALIASED);
            
            mIsRealUpdate = true;
            IsVisible = true;
        }
        
        public void AddLock(IWidget widget)
        {
            mPressLock.Add((Widget) widget);
        }


        public bool IsLock()
        {
            return mPressLock.Any(widget => widget.State == ButtonState.Pressed);
        }

        //public Color PressColor { get; set; }

        public override void Invalidate()
        {
            mIsRealUpdate = true;
            base.Invalidate();
        }

        public override void Update()
        {
            if (Width == 0 || Height == 0)
                return;

            if (!IsVisible)
                return;

            VG.vgLoadIdentity();
            if (!mIsRealUpdate)
            {
                // copy image from mCache
                VG.vgSetPixels(X - 1, Y - 1, mCache, 0, 0, Width + 2, Height + 2);
                return;
            }

            mIsRealUpdate = false;

            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);

            #region fill rect
            {
                var colStops = new float[25];// xRGBA

                VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_LINEAR_GRADIENT);

                if (State == ButtonState.Released)
                {
                    colStops[0] = 0.0f; colStops[1] = 0x2c / 255f; colStops[2] = 0x2d / 255f; colStops[3] = 0x2f / 255f; colStops[4] = 1.0f;
                    colStops[5] = 0.20f; colStops[6] = 0x34 / 255f; colStops[7] = 0x35 / 255f; colStops[8] = 0x37 / 255f; colStops[9] = 1.0f;
                    colStops[10] = 0.80f; colStops[11] = 0x34 / 255f; colStops[12] = 0x35 / 255f; colStops[13] = 0x37 / 255f; colStops[14] = 1.0f;
                    colStops[15] = 1.0f; colStops[16] = 0x43 / 255f; colStops[17] = 0x43 / 255f; colStops[18] = 0x47 / 255f; colStops[19] = 1.0f;
                }
                else
                {
                    colStops[0] = 0.0f; colStops[1] = 0x47 / 255f; colStops[2] = 0x49 / 255f; colStops[3] = 0x4d / 255f; colStops[4] = 1.0f;
                    colStops[5] = 0.20f; colStops[6] = 0x2e / 255f; colStops[7] = 0x30 / 255f; colStops[8] = 0x32 / 255f; colStops[9] = 1.0f;
                    colStops[10] = 0.80f; colStops[11] = 0x2e / 255f; colStops[12] = 0x30 / 255f; colStops[13] = 0x32 / 255f; colStops[14] = 1.0f;
                    colStops[15] = 1.0f; colStops[16] = 0x16 / 255f; colStops[17] = 0x19 / 255f; colStops[18] = 0x19 / 255f; colStops[19] = 1.0f;
                }

                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_LINEAR_GRADIENT, 4, new float[] { X, Y, X, Y + Height });
                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR_RAMP_STOPS, 20, colStops);

                VG.vgSetPaint(mPaint, VGPaintMode.VG_FILL_PATH);

                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 1.0f);
                VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                VGU.vguRoundRect(mPath, X, Y, Width, Height, mRound, mRound);
                VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
                VG.vgFinish();
            }
            #endregion

            #region draw line
            {
                VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
                var lineSize =  1.0f;

                if (State == ButtonState.Released)
                    VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { 0x6b / 255f, 0x6c / 255f, 0x6c / 255f, 1.0f });
                else
                {
                    lineSize = 3.0f;
                    VG.vgSetParameterfv(mPaint, (int) VGPaintParamType.VG_PAINT_COLOR, 4,
                                        IsLock()
                                            ? new[] {0xd9/255f, 0x11/255f, 0x07/255f, 1.0f} // red
                                            : new[] {0x31/255f, 0xa3/255f, 0x1f/255f, 1.0f}); // freen
                }

                VG.vgSetPaint(mPaint, VGPaintMode.VG_STROKE_PATH);

                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, lineSize);
                VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                VGU.vguRoundRect(mPath, X + (lineSize / 2f), Y + (lineSize / 2f), Width - lineSize, Height - lineSize, mRound, mRound);
                VG.vgDrawPath(mPath, VGPaintMode.VG_STROKE_PATH);
                VG.vgFinish();
            }
            #endregion


            base.Update();

            // copy render image to cache
            VG.vgGetPixels(mCache, 0, 0, X - 1, Y - 1, Width + 2, Height + 2);
        }


        public override void Dispose()
        {
            if (mPath != new IntPtr())
                VG.vgDestroyPath(mPath);

            if (mPaint != new IntPtr())
                VG.vgDestroyPaint(mPaint);

            if (mCache != new IntPtr())
                VG.vgDestroyImage(mCache);

        }
    }
}