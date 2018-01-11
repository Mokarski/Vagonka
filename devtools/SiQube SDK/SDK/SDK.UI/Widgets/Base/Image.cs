using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using SDK.Common;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class Image : Widget, IImage
    {
        private const int kAccuratePoint = 10000;
        private int mScaleX = kAccuratePoint;
        private int mScaleY = kAccuratePoint;
        private string mUrl;
        private static int mId;

        public Image(IWidget parent, int x, int y)
            : base(parent, x, y, 0, 0)
        {
            Name = string.Format("image{0}", mId++);
        }

        private void LoadImage()
        {
            try
            {
                if (!File.Exists(Path.Combine(Application.ResourceUrl, mUrl))) {
                    Console.Write("Image file not found:");
                    Console.Write(Path.Combine(Application.ResourceUrl, mUrl));
                    return;
		}

                var data = File.ReadAllBytes(mUrl);

                var height = XpBitConverter.ToInt32(data, 0);
                var width = XpBitConverter.ToInt32(data, 4);

                var size = data.Length - 8;
                var raw = Marshal.AllocHGlobal(size);
                Marshal.Copy(data, 8, raw, size);

                //mCache = VG.vgCreateImage(PixelFormat, Width, Height, VGImageQuality.VG_IMAGE_QUALITY_BETTER);
                //VG.vgImageSubData(mCache, raw, 4 * Width, PixelFormat, 0, 0, Width, Height);
                VG.vgWritePixels(raw, 4 * width, VGImageFormat.VG_sBGRA_8888, 0, 0, width, height);
                //VG.vgWritePixels(raw, 4*width, PixelFormat, 0, 0, width, height);

                Marshal.FreeHGlobal(raw);
            }
            catch (Exception ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        public bool Load(string url)
        {
            if (!File.Exists(Path.Combine(Application.ResourceUrl, url))) {
                    Console.Write("Image file not found:");
                    Console.Write(Path.Combine(Application.ResourceUrl, url));
                    return false;
            }

            if (mUrl == Path.Combine(Application.ResourceUrl, url))
                return true;

            mUrl = Path.Combine(Application.ResourceUrl, url);
            var data = new byte[8];
            File.OpenRead(mUrl).Read(data, 0, 8);

            var height = XpBitConverter.ToInt32(data, 0);
            var width = XpBitConverter.ToInt32(data, 4);
            Resize(width, height);

            return true;
        }

        public void Scale(float scaleX, float scaleY)
        {
            mScaleX = (int)(scaleX * kAccuratePoint);
            mScaleY = (int)(scaleY * kAccuratePoint);

            Invalidate();
        }

        protected override void Draw()
        {
            LoadImage();
        }

        public override void Update(GfxRect updateArea)
        {
            if (!IsVisible)
                return;

            if (OnPaint != null)
                OnPaint(this);

            //Console.WriteLine("->> {1}: to surface: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));

            var position = ScreenPosition;
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_IMAGE_USER_TO_SURFACE);

            VG.vgLoadIdentity();
            VG.vgTranslate(position.X, position.Y);

            if (mRotate != 0)
            {
                VG.vgTranslate(RotateCenter.X, RotateCenter.Y);
                VG.vgRotate(mRotate);
                VG.vgTranslate(-RotateCenter.X, -RotateCenter.Y);
            }

            if (mScaleX != kAccuratePoint || mScaleY != kAccuratePoint)
            {
                var sx = mScaleX / (kAccuratePoint * 1.0f);
                var sy = mScaleY / (kAccuratePoint * 1.0f);
                VG.vgScale(sx, sy);
            }

            mRenderBuffer.ToSurface();

            Console.WriteLine("<<- {1}: to surface: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));

            foreach (var widget in mChilds.Where(widget => !(widget is ModalWindow)))
                widget.Update();
        }
    }
}
