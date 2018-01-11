using System.Linq;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class Button : Widget
    {
        private IWidget mActive;
        private IWidget mNormal;
        private ButtonState? mFixState;

        public Button(IWidget parent, int width, int height) : base(parent, width, height) { }
        public Button(IWidget parent, int x, int y, int width, int height) : base(parent, x, y, width, height) { }

        public void Init(IWidget active, IWidget normal)
        {
            mActive = active;
            mNormal = normal;

            Update();
        }

        public ButtonState? FixState
        {
            get { return mFixState; }
            set
            {
                if (value == mFixState) return;

                mFixState = value;
                Invalidate();
            }
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

            switch (mFixState)
            {
                // отрисовка по текущему состоянию
                case null:
                    if (State == ButtonState.Released)
                    {
                        if (mNormal != null)
                            mNormal.Update();
                    }
                    else
                    {
                        if (mActive != null)
                            mActive.Update();
                    }
                    break;

                // заблокировано в отжатом состоянии
                case ButtonState.Released:
                    if (mNormal != null)
                        mNormal.Update();
                    break;

                // заблокировано в нажатом состоянии
                default:
                    if (mActive != null)
                        mActive.Update();
                    break;
            }

            VG.vgFinish();

            //Console.WriteLine("<<- {1}: to surface: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));

            foreach (var widget in mChilds.Where(widget => !(widget is ModalWindow)))
                widget.Update();
        }  
    }
}