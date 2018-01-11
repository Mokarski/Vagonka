using System;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets
{
    public class ListItem : Widget
    {
        private readonly float mRound;

        private readonly IntPtr mPath = IntPtr.Zero;
        private readonly IntPtr mPaint = IntPtr.Zero;
        private readonly IntPtr mCache = IntPtr.Zero;
        private bool mIsRealUpdate;
        private readonly TextArea mText;
        private bool mActivated;

        public ListItem(string aName, int x, int y, int width, int height, float round)
            : base(null, aName)
        {
            X = x;
            Y = y;

            Width = width;
            Height = height;

            mRound = round;

            const int kSize = 20;
            const int kBias = 3;
            mText = new TextArea(this, "", null, 0, (Height - kSize) / 2 + kBias, Width, Height) { Text = "---", Size = kSize, Align = Align.Center };
            AddChild(mText);

            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            mPaint = VG.vgCreatePaint();

            mCache = VG.vgCreateImage(PixelFormat, Width, Height, VGImageQuality.VG_IMAGE_QUALITY_NONANTIALIASED);

            mIsRealUpdate = true;
        }

        public string Text
        {
            get
            {
                return mText != null ? mText.Text : "";
            }
            set
            {
                if (mText == null) return;

                mText.Text = value;
                Invalidate();
            }
        }

        public bool Activated
        {
            get
            {
                return mActivated;
            }
            set
            {
                if (mActivated == value)
                    return;

                mActivated = value;
                Invalidate();
            }
        }

        public override void Invalidate()
        {
            mIsRealUpdate = true;
            base.Invalidate();
        }

        public override void Update()
        {
            if (!IsVisible)
                return;
            
            if (Width == 0 || Height == 0)
                return;
            
            if (!mIsRealUpdate)
            {
                // copy image from mCache
                VG.vgSetPixels(X, Y, mCache, 0, 0, Width, Height);
                return;
            }
            
            mIsRealUpdate = false;
            VG.vgLoadIdentity();
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);

            #region draw line
            {
                VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);

                float lineSize;
                if (!mActivated)
                {
                    
                    VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, ParentWindow.Background.Value);
                    lineSize = 10.0f;
                }
                else
                {
                    VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { 0xe0 / 255f, 0x8f / 255f, 0x1e / 255f, 1.0f });
                    lineSize = 2.0f;
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

            #region fill rect
            {
                var colStops = new float[25];// xRGBA

                VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_LINEAR_GRADIENT);

                if (!mActivated)
                {
                    colStops[0] = 0.0f; colStops[1] = 0xb3 / 255f; colStops[2] = 0xb4 / 255f; colStops[3] = 0xb5 / 255f; colStops[4] = 1.0f;
                    colStops[5] = 0.20f; colStops[6] = 0xb3 / 255f; colStops[7] = 0xb4 / 255f; colStops[8] = 0xb5 / 255f; colStops[9] = 1.0f;
                    colStops[10] = 0.80f; colStops[11] = 0x8a / 255f; colStops[12] = 0x8b / 255f; colStops[13] = 0x8c / 255f; colStops[14] = 1.0f;
                    colStops[15] = 1.0f; colStops[16] = 0x8a / 255f; colStops[17] = 0x8b / 255f; colStops[18] = 0x8c / 255f; colStops[19] = 1.0f;
                }
                else
                {
                    colStops[0] = 0.0f; colStops[1] = 0xef / 255f; colStops[2] = 0xf0 / 255f; colStops[3] = 0xf0 / 255f; colStops[4] = 1.0f;
                    colStops[5] = 0.20f; colStops[6] = 0xef / 255f; colStops[7] = 0xf0 / 255f; colStops[8] = 0xf0 / 255f; colStops[9] = 1.0f;
                    colStops[10] = 0.80f; colStops[11] = 0xb6 / 255f; colStops[12] = 0xb6 / 255f; colStops[13] = 0xb6 / 255f; colStops[14] = 1.0f;
                    colStops[15] = 1.0f; colStops[16] = 0xb6 / 255f; colStops[17] = 0xb6 / 255f; colStops[18] = 0xb6 / 255f; colStops[19] = 1.0f;
                }

                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_LINEAR_GRADIENT, 4, new float[] { X, Y + Height, X, Y });
                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR_RAMP_STOPS, 20, colStops);

                VG.vgSetPaint(mPaint, VGPaintMode.VG_FILL_PATH);

                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 1.0f);
                VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                var lineSize = 10.0f;
                VGU.vguRoundRect(mPath, X + (lineSize / 2f), Y + (lineSize / 2f), Width - lineSize, Height - lineSize, mRound, mRound);
                //VGU.vguRoundRect(mPath, X, Y, Width, Height, mRound, mRound);
                VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
                VG.vgFinish();
            }
            #endregion

            base.Update();

            // copy render image to cache
            VG.vgGetPixels(mCache, 0, 0, X, Y, Width, Height);
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