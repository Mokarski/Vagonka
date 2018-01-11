using System.IO;
using SDK.UI.Widgets.Base;

namespace SDK.UI.Widgets
{
    public class ProgressBarImages : Widget
    {
        private readonly string mRootImageDirUrl;
        private uint mPercent;
        private readonly TextArea mTextArea;


        public ProgressBarImages(string aName, string aRootImageDirUrl, int x, int y)
            : base(aName)
        {
            X = x;
            Y = y;

            mRootImageDirUrl = aRootImageDirUrl;
            mTextArea = new TextArea("", null, X, Y + 8, 300, 10) { Align = AlignType.Center };
        }

        public Color TextColor
        {
            get
            {
                return mTextArea != null ? mTextArea.Color : new Color();
            }
            set
            {
                if (mTextArea != null)
                    mTextArea.Color = value;
            }
        }

        public string Text
        {
            get
            {
                return mTextArea != null ? mTextArea.Text : "";
            }
            set
            {
                if (mTextArea != null)
                    mTextArea.Text = value;
            }
        }

        public override void Update()
        {
            VG.vgSeti(VGParamType.VG_IMAGE_MODE, (int)VGImageMode.VG_DRAW_IMAGE_NORMAL);
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_IMAGE_USER_TO_SURFACE);

            VG.vgLoadIdentity();
            VG.vgTranslate(X, Y);

            // draw bg
            int width, height;
            var image = CopyImageToVgBuffer(File.ReadAllBytes(Path.Combine(mRootImageDirUrl, @"generic/progressbar/bg.raw")), out width, out height);
            VG.vgDrawImage(image);
            VG.vgDestroyImage(image);

            // draw left border
            if (Percent > 0)
            {
                image = CopyImageToVgBuffer(File.ReadAllBytes(Path.Combine(mRootImageDirUrl, @"generic/progressbar/left.raw")), out width, out height);
                VG.vgDrawImage(image);
                VG.vgDestroyImage(image);
            }

            // draw right border
            VG.vgTranslate(300, 0);
            if (Percent == 100)
            {
                image = CopyImageToVgBuffer(File.ReadAllBytes(Path.Combine(mRootImageDirUrl, @"generic/progressbar/right.raw")), out width, out height);
                VG.vgDrawImage(image);
                VG.vgDestroyImage(image);
            }

            if (Percent > 0)
            {
                VG.vgTranslate(-293, 1);
                VG.vgScale(1.465f * Percent, 1.0f);
                image = CopyImageToVgBuffer(File.ReadAllBytes(Path.Combine(mRootImageDirUrl, @"generic/progressbar/1.raw")), out width, out height);
                VG.vgDrawImage(image);
                VG.vgDestroyImage(image);
            }

            mTextArea.Update();
        }

        public uint Percent
        {
            get { return mPercent; }
            set { mPercent = value > 100 ? 100 : value; }
        }


        public override void Dispose()
        {
            if (mTextArea != null)
                mTextArea.Dispose();
        }
    }
}