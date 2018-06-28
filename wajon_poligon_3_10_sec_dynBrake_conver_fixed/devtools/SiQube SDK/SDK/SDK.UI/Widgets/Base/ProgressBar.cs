using System;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class ProgressBar : Widget
    {
        private readonly IntPtr mPath;
        private readonly IntPtr mPaint;
        private int mPercent;
        private readonly int mRound;
        private const float kLineSize = 1.5f;

        public ProgressBar(IWidget parent, int x, int y, int width, int height, int round)
            : base(parent, x, y, width, height)
        {
            mRound = round;

            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            VGU.vguRoundRect(mPath, 0, 0, Width, Height, mRound, mRound);

            mPaint = VG.vgCreatePaint();

            Status = new TextArea(this, 0, 0, Width, Height);
            Status.SetAlign(Align.Center, new GfxPoint(0, 3));
            Status.OnTextChange += caller => Invalidate();

            Border = new VGSolidColor(Palette.White);
            Background = new VGSolidColor(Palette.Black);
            var percent = new VGLinearGradient(0, 0, 0, Height);
            percent.AddColor(0, new Color(0xE9AE5DFF));
            //percent.AddColor(50, new Color(0xE08F1EFF));
            percent.AddColor(100, new Color(0xE08F1EFF));
            //percent.AddColor(0, new Color(0x00FF00FF));
            //percent.AddColor(100, new Color(0xFF0000FF));
            PercentLine = percent;

        }

        public ITextArea Status { get; private set; }

        public IOpenVGPaint Border { get; set; }
        public IOpenVGPaint Background { get; set; }
        public IOpenVGPaint PercentLine { get; set; }

        protected override void Draw()
        {
            if (!IsVisible)
                return;

            VG.vgLoadIdentity();
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);

            var position = ScreenPosition;
            VG.vgTranslate(position.X, position.Y);

            //VG.vgRotate(mRotate);
            //Status.Rotate(mRotate);

            #region draw percent
            if (mPercent > 0)
            {
                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
                VGU.vguRoundRect(mPath, 0, 0, Width, Height, mRound, mRound);

                // draw percent line
                if(PercentLine != null)
                    PercentLine.SetPaint(VGPaintMode.VG_FILL_PATH);
                
                VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
                VG.vgFinish();
            }
            #endregion

            #region draw background
            VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
            //VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, RootWindow.Background.Value);
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { 0.0f, 0.0f, 0.0f, 1.0f });
            VG.vgSetPaint(mPaint, VGPaintMode.VG_FILL_PATH);

            var percentWidth = (Width*Percent)/100f;
            VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            VGU.vguRect(mPath, percentWidth, 0, Width - percentWidth, Height);
            VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
            VG.vgFinish();
            #endregion

            #region draw line
            {
                if(Border != null)
                {
                    Border.SetPaint(VGPaintMode.VG_STROKE_PATH);

                    VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, kLineSize);
                    VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                    VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                    VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
                    //VGU.vguRoundRect(mPath, kLineSize / 2f, kLineSize / 2f, Width - kLineSize, Height - kLineSize, mRound, mRound);
                    VGU.vguRoundRect(mPath, 0, 0, Width, Height, mRound, mRound);
                    VG.vgDrawPath(mPath, VGPaintMode.VG_STROKE_PATH);
                    VG.vgFinish();
                }
            }
            #endregion

            //base.Update();
            VG.vgFinish();
        }

        public int Percent
        {
            get { return mPercent; }
            set
            {
                if (value < 0)
                    mPercent = 0;
                else
                    mPercent = (value > 100 ? 100 : value);

                Invalidate();
            }
        }


        public override void Dispose()
        {
            if (Status != null)
                Status.Dispose();

            if (mPath != new IntPtr())
                VG.vgDestroyPath(mPath);

            if (mPaint != new IntPtr())
                VG.vgDestroyPaint(mPaint);
            
            base.Dispose();
        }
    }
}