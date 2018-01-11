using System;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class TextArea : Widget, ITextArea
    {
        private ITextRender mFontRender;
        private readonly IntPtr mPaint;
        private string mText;

        private static int _id;

        public TextArea(IWidget parent, int x, int y, int width, int height)
            : base(parent, width, height)
        {
            // create a paint
            mPaint = VG.vgCreatePaint();
            Name = string.Format("textArea{0}", _id++);

            Init(x, y);
        }

        private void Init(int x, int y)
        {
            Text = "";

            SetFont(null, Palette.Black, 12);
            SetAlign(Align.Left);

            Move(x, y);

            OnTextChange += caller => caller.Invalidate();
        }

        public string Text
        {
            get { return mText; }
            set
            {
                if(mText == value)
                    return;

                mText = value;
                if (OnTextChange != null)
                    OnTextChange(this);
            }
        }

        public string FontName { get; private set; }
        public Align TextAlign { get; private set; }
        public int FontSize { get; private set; }
        public Color FontColor { get; private set; }
        public GfxPoint TextOffset { get; private set; }
        public float TextWidth { get { return mFontRender.GetEscapement(Text)[0]*FontSize; } }

        public void SetFont(string font, Color color, int size)
        {
            FontName = font ?? "default";
            mFontRender = Application.GetInstance().GetTextRender(FontName);
            FontSize = size;

            FontColor = color;

            if (OnTextChange != null)
                OnTextChange(this);
        }

        public void SetFont(int size)
        {
            SetFont(null, FontColor, size);
        }

        public void SetFont(Color color)
        {
            SetFont(null, color, FontSize);
        }

        public void SetFont(Color color, int size)
        {
            SetFont(null, color, size);
        }

        protected override void Draw()
        {
            //VG.vgSetfv(VGParamType.VG_CLEAR_COLOR, 4, new[] { 0.0f, 1.0f, 0.0f, 0.5f });
            //VG.vgClear(0, 0, Width, Height);
            //VG.vgFinish();

            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
            VG.vgLoadIdentity();

            #region draw text

            if (Text == null) return;

            VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, FontColor.Value);
            VG.vgSetPaint(mPaint, VGPaintMode.VG_FILL_PATH);

            float[] glyphOrigin = { 0.0f, 0.0f };

            // set glyph matrices
            VG.vgSetfv(VGParamType.VG_GLYPH_ORIGIN, 2, glyphOrigin);
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_GLYPH_USER_TO_SURFACE);
            VG.vgLoadIdentity();

            var widthText = (TextWidth > Width) ? Width : TextWidth;
            switch (TextAlign)
            {
                case Align.Left:
                    VG.vgTranslate(TextOffset.X, TextOffset.Y);
                    break;

                case Align.Center:
                    VG.vgTranslate((Width - widthText + TextOffset.X) / 2f, TextOffset.Y);       
                    break;

                case Align.Right:
                    VG.vgTranslate((Width - widthText - TextOffset.X), TextOffset.Y);
                    break;
            }

            VG.vgTranslate(RotateCenter.X, RotateCenter.Y);
            VG.vgRotate(mRotate);
            VG.vgTranslate(-RotateCenter.X, -RotateCenter.Y);

            VG.vgScale(FontSize, FontSize);

            mFontRender.RenderText(Text);
            VG.vgFinish();

            #endregion
        }

        public override void Dispose()
        {
            if (mPaint != new IntPtr())
                VG.vgDestroyPaint(mPaint);

            base.Dispose();
        }

        public void SetAlign(Align align, GfxPoint offset)
        {
            TextOffset = offset ?? new GfxPoint(0, 0);
            TextAlign = align;

            if (OnTextChange != null)
                OnTextChange(this);
        }

        public void SetAlign(Align align)
        {
            SetAlign(align, TextOffset);
        }

        public event TextEvent OnTextChange;
    }
}

