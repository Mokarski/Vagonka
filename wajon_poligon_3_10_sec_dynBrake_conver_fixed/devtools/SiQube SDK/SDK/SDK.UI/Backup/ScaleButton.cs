using System;
using System.IO;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets
{
    public class ScaleButton : Widget
    {

        private readonly string mImageUrl;

        public ScaleButton(string aName, string aImageFileName, int x, int y, float xScale, float yScale)
            : base(null, aName)
        {
            X = x;
            Y = y;
            mImageUrl = aImageFileName;
            mScaleX = xScale;
            mScaleY = yScale;

            /*
            int width, height;
            GetImageSize(mImageUrl, out width, out height);

            Width = (int)(mScaleX * width);
            Height = (int)(mScaleY * height);
            EffectToLeft = false;
            */

            /*
            var asserts = new Asserts();

            asserts.Assert(upHeight == downHeight, "upHeight == downHeight", Asserts.Mode.Warning, Asserts.Mode.Exception);
            asserts.Assert(upWidth == downWidth, "upHeight == downHeight", Asserts.Mode.Warning, Asserts.Mode.Exception);
            */
        }

        public bool EffectToLeft { get; set; }

        public override void Update()
        {
            VG.vgSeti(VGParamType.VG_IMAGE_MODE, (int)VGImageMode.VG_DRAW_IMAGE_NORMAL);
            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_IMAGE_USER_TO_SURFACE);
            VG.vgLoadIdentity();


            if (State == ButtonState.Released)
            {
                VG.vgTranslate(X, Y);
                VG.vgScale(mScaleX, mScaleY);
            }
            else
            {
                if (EffectToLeft)
                    VG.vgTranslate(X - ((Width/mScaleX) - Width), Y);
                else
                    VG.vgTranslate(X, Y);
            }

            /*
            int width;
            int height;
            var image = CopyImageToVgBuffer(File.ReadAllBytes(mImageUrl), out width, out height);
            if (image != IntPtr.Zero)
            {
                VG.vgDrawImage(image);
                VG.vgDestroyImage(image);
            }
            */

            base.Update();
        }

        private void ChangeZLevel()
        {
            if (Application.GetInstance().GetFocusedWindow() == null) return;
            
            IWidget rv = this;
            while (rv != null)
            {

                if (rv.Parent == null)
                {
                    rv.SetTopZlevel(this);
                    return;
                }
                rv = rv.Parent;
            }
        }

        public override bool HandleEvent(Application.EventType aType, object aData)
        {
            var mouseData = (MouseData)aData;
            switch (aType)
            {
                case Application.EventType.MouseDown:
                    {
                        if (State != ButtonState.Pressed)
                        {
                            if ((mouseData.X >= X && mouseData.X <= X + Width) && (mouseData.Y >= Y && mouseData.Y <= Y + Height))
                            {
                                // меняем внутреннее состояние
                                State = ButtonState.Pressed;

                                // оповещаем всех о смене состояния
                                if (OnPress != null)
                                    OnPress();

                                // перерисовываем
                                ChangeZLevel();
                                Invalidate();
                            }
                        }
                    }
                    return true;

                case Application.EventType.MouseUp:
                    {
                        if (State == ButtonState.Pressed)
                        {
                            State = ButtonState.Released;

                            // оповещаем всех о смене состояния
                            if (OnRelease != null)
                                OnRelease();

                            // перерисовываем
                            Invalidate();
                        }
                    }
                    return true;
            }

            return false;
        }

        private float mScaleX;
        private float mScaleY;

        public override void Dispose()
        {
        }
    }
}