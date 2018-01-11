using System;
using System.IO;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets
{


    public class RawButton : Widget
    {
        
        //private IntPtr mUpImg = IntPtr.Zero;
        //private IntPtr mDownImg = IntPtr.Zero;

        private string mUpImageUrl;
        private string mDownImageUrl;

        public RawButton(string aName, string aImageUpFileName, string aImageDownFileName, int x, int y)
            : base(null, aName)
        {
            X = x;
            Y = y;
            mUpImageUrl = aImageUpFileName;
            mDownImageUrl = aImageDownFileName;
            
            /*
            int width, height;
            GetImageSize(mUpImageUrl, out width, out height);
            Width = width;
            Height = height;
            */

            /*
            var asserts = new Asserts();

            asserts.Assert(upHeight == downHeight, "upHeight == downHeight", Asserts.Mode.Warning, Asserts.Mode.Exception);
            asserts.Assert(upWidth == downWidth, "upHeight == downHeight", Asserts.Mode.Warning, Asserts.Mode.Exception);
            */
        }

        public void ChangeUpImg(string aUpImgFile)
        {
            mUpImageUrl = aUpImgFile;
        }

        public void ChangeDownImg(string aDownImgFile)
        {
            mDownImageUrl = aDownImgFile;
        }

        public override void Update()
        {
            VG.vgSeti(VGParamType.VG_IMAGE_MODE, (int)VGImageMode.VG_DRAW_IMAGE_NORMAL);

            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_IMAGE_USER_TO_SURFACE);

            VG.vgLoadIdentity();
            VG.vgTranslate(X, Y);
            /*
            int width, height;
            var image = CopyImageToVgBuffer(File.ReadAllBytes(State == ButtonState.Released ? mUpImageUrl : mDownImageUrl), out width, out height);
            if(image != IntPtr.Zero)
            {
                VG.vgDrawImage(image);
                VG.vgDestroyImage(image);      
            }
            */
            base.Update();
        }

        public override void Dispose()
        {
        }
    }
}
