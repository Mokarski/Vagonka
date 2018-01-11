using System;
using SDK.UI.Widgets.Base;

namespace SDK.UI.Widgets
{
    public class ItemBorder : Widget
    {
        private readonly float mRound;
        private readonly int mParamWidth;

        private readonly IntPtr mPath = IntPtr.Zero;
        private readonly IntPtr mPaint = IntPtr.Zero;

        public ItemBorder(string aName, int x, int y, int width, int height, float round, int paramWidth)
            : base(null, aName)
        {
            X = x;
            Y = y;

            Width = width;
            Height = height;

            mRound = round;
            mParamWidth = paramWidth;

            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            mPaint = VG.vgCreatePaint();

        }

        public override void Update()
        {
            if (Width == 0 || Height == 0)
                return;

            VG.vgLoadIdentity();
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);

            #region draw line
            {
                VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);

                //VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { 0xe0 / 255f, 0x8f / 255f, 0x1e / 255f, 1.0f });
                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { 0xef / 255f, 0xf0 / 255f, 0xf0 / 255f, 1.0f });
                var lineSize = 2.0f;

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


                colStops[0] = 0.0f; colStops[1] = 0xe9 / 255f; colStops[2] = 0xae / 255f; colStops[3] = 0x5d / 255f; colStops[4] = 1.0f;
                colStops[5] = 0.20f; colStops[6] = 0xe9 / 255f; colStops[7] = 0xae / 255f; colStops[8] = 0x5d / 255f; colStops[9] = 1.0f;
                colStops[10] = 0.80f; colStops[11] = 0xe0 / 255f; colStops[12] = 0x8f / 255f; colStops[13] = 0x1e / 255f; colStops[14] = 1.0f;
                colStops[15] = 1.0f; colStops[16] = 0xe0 / 255f; colStops[17] = 0x8f / 255f; colStops[18] = 0x1e / 255f; colStops[19] = 1.0f;


                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_LINEAR_GRADIENT, 4, new float[] { X, Y + Height, X, Y });
                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR_RAMP_STOPS, 20, colStops);

                VG.vgSetPaint(mPaint, VGPaintMode.VG_FILL_PATH);

                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 1.0f);
                VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                var lineSize = 10.0f;
                VGU.vguRoundRect(mPath, X + Width - mParamWidth - lineSize, Y + (lineSize / 2f), mParamWidth + (lineSize / 2f), Height - lineSize, 5.0f, 5.0f);
                //VGU.vguRoundRect(mPath, X + Width - mParamWidth - lineSize, Y + (lineSize / 2f), mParamWidth + (lineSize / 2f), Height - lineSize, mRound, mRound);
                VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
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
}