using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class ModalWindow : Widget, IModalWindow
    {
        private static VGPath mPath;
        private static uint mCounter;

        protected ModalWindow() : base(null, Application.Screen.Width, Application.Screen.Height )
        {
            Hide();
            
            if(mPath == null)
            {
                mPath = new VGPath(null, new VGSolidColor(new Color { R = 0.0f, G = 0.0f, B = 0.0f, A = 0.8f }));
                VGU.vguRect(mPath.GetPath(), 0, 0, Width, Height);
            }

            mCounter++;
        }

        /// <summary>
        /// Затемнение фона
        /// </summary>
        protected void BlurBackground()
        {
            // затемняем фон
            mPath.Update();
        }

        public new IWidget Parent
        {
            get { return base.Parent; }
            set
            {
                if (value as IWindow != null)
                    base.Parent = value;
            }
        }

        public override bool HandleEvent(Application.EventType aType, object aData)
        {
            foreach (var widget in mChilds)
                widget.HandleEvent(aType, aData);

            return true;
        }

        //public event UserChooseEvent OnCustomerEvent;

        public override void Dispose()
        {
            mCounter--;
            if(mCounter == 0 && mPath != null)
                mPath.Dispose();

            foreach (var widget in mChilds)
            {
                widget.Dispose();
            }

            base.Dispose();
        }
    }
}
