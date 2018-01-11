using System.Collections.Generic;
using System.Linq;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class InisibleWindow : Window
    {
        public InisibleWindow() : base("invisible", Application.Screen.Width, Application.Screen.Height)
        {
            Background = null;
        }

        public new void Redraw(bool force = false)
        {
            foreach (var widget in mChilds)
            {
                ((Widget)widget).Redraw();
            }
        }
    }
    
    public abstract class Window : Widget, IWindow
    {
        private readonly List<ModalWindow> mModalWindows = new List<ModalWindow>();
        protected Color mBackground;
        private ModalWindow mVisibleModal;

        protected Window(string name, int width, int height)
        {
            mBackground = Palette.Window.Background;

            Name = name;
            Resize(width, height);
        }

        public void AddModal(ModalWindow modalWindow)
        {
            modalWindow.Parent = this;

            lock (mModalWindows)
                mModalWindows.Add(modalWindow);
        }

        protected override void Draw()
        {
            if (Background != null)
            {
                VG.vgSetfv(VGParamType.VG_CLEAR_COLOR, 4, Background.Value);
                VG.vgClear(0, 0, Width, Height);
                VG.vgFinish();
            }

            #region calibrate lines
            {
                /*
                    VG.vgLoadIdentity();
                    VG.vgSetParameteri(mPanelBorderColor, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
                    VG.vgSetParameterfv(mPanelBorderColor, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { 1.0f, 1.0f, 1.0f, 1.0f });

                    VG.vgSetPaint(mPanelBorderColor, VGPaintMode.VG_STROKE_PATH);
                    VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                    const float kLineSize = 1.0f;
                    VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, kLineSize);
                    VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                    VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                    VGU.vguLine(mPath, 10, 0, 10, Height);
                    VGU.vguLine(mPath, Width - 10, 0, Width - 10, Height);

                    VGU.vguLine(mPath, 0, 10, Width, 10);
                    VGU.vguLine(mPath, 0, Height - 10, Width, Height - 10);


                    VG.vgDrawPath(mPath, VGPaintMode.VG_STROKE_PATH);
                    VG.vgFinish();
                 */
            }
            #endregion
        }

        public new void Update()
        {
            //Console.WriteLine("->> {1}: draw: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));
            Redraw();

            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
            VG.vgLoadIdentity();

            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_IMAGE_USER_TO_SURFACE);
            VG.vgLoadIdentity();

            VG.vgSetfv(VGParamType.VG_CLEAR_COLOR, 4, new[]{1.0f, 1.0f, 0.0f, 0.0f});
            VG.vgClear(0, 0, Width, Height);
            VG.vgFinish();
            //Console.WriteLine("<<- {1}: draw: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));

            //Console.WriteLine("->> {1}: update: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));
            base.Update();
            //Console.WriteLine("<<- {1}: update: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));

            #region Popup window
            ModalWindow popup = null;
            lock (mModalWindows)
            {
                if (mVisibleModal != null)
                {
                    if (mVisibleModal.IsVisible)
                        popup = mVisibleModal;
                }
                
                if(popup == null)
                {
                    foreach (var modalWindow in mModalWindows.Where(modalWindow => modalWindow.IsVisible))
                    {
                        mVisibleModal = modalWindow;
                        popup = mVisibleModal;
                    }
                }
            }

            if (popup == null) return;

            // отрисовываем модальное окно
            popup.Update();
            #endregion
        }

        public Color Background
        {
            get { return mBackground; }
            set
            {
                if (value != null)
                    mBackground = value;
            }
        }

        public override bool HandleEvent(Application.EventType aType, object aData)
        {
            ModalWindow popup;

            lock (mModalWindows)
                popup = mModalWindows.FirstOrDefault(w => w.IsVisible);

            if (popup != null)
                return popup.HandleEvent(aType, aData);

            for (var i = 0; i < mChilds.Count; i++)
            {
                var child = mChilds[mChilds.Count - 1 - i];
                if (child.IsVisible)
                    if (!(child is ModalWindow))
                        if (child.HandleEvent(aType, aData))
                            return true;
            }

            return false;
        }

        public override void Dispose()
        {
            foreach (var modal in mModalWindows)
                modal.Dispose();

            foreach (var widget in mChilds)
                widget.Dispose();

            base.Dispose();
        }
    }
}
