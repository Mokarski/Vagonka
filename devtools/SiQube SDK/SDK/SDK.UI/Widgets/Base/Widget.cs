using System;
using System.Collections.Generic;
using System.Linq;
using SDK.Common;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class Widget : IWidget
    {
        protected Application mApplication;
        internal RenderBuffer mRenderBuffer;
        public bool IsDirty { get; protected set; }

        public bool SwapDebug { get; set; }

        public void Activate(bool status)
        {
            if (status == IsActive)
                return;

            IsActive = status;

            if (IsActive)
            {
                if (OnActivate != null)
                    OnActivate(this);
                else
                    Invalidate();

                return;
            }

            mCheckHoldKey.Stop();

            if (OnDeactivate != null)
                OnDeactivate(this);
            else
                Invalidate();
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public GfxPoint RotateCenter
        {
            get { return mRotateCenter; }
            set
            {
                if (value == mRotateCenter)
                    return;

                mRotateCenter = value;
                Invalidate();
            }
        }

        public void Rotate(int angle)
        {
            if (mRotate == angle)
                return;

            mRotate = angle;
            Invalidate();
        }

        public ButtonState State { get; private set; }
        public int HotKeycode { get; set; }

        private DateTime mPreviousReleaseEvent;
        private const uint kDoubleClickTimeout = 1500;
        private const int kHoldKeyTimeout = 1000;

        public int HoldKeyTimeout { set { mCheckHoldKey.SetTimeout(value); } get { return mCheckHoldKey.GetTimeout(); } }

        private readonly DelayedTask mCheckHoldKey = new DelayedTask(kHoldKeyTimeout); 

        public virtual bool HandleEvent(Application.EventType aType, object aData)
        {
            var point = ScreenPosition;
            switch (aType)
            {
                case Application.EventType.MouseDown:
                    {
                        if (IsVisible && IsActive)
                            if (State != ButtonState.Pressed)
                            {
                                var mouseData = (MouseData)aData;
                                //Console.WriteLine("{0},{1}", mouseData.X, mouseData.Y);

                                if ((mouseData.X >= point.X && mouseData.X <= point.X + Width) && (mouseData.Y >= point.Y && mouseData.Y <= point.Y + Height))
                                {
                                    // меняем внутреннее состояние
                                    State = ButtonState.Pressed;

                                    mCheckHoldKey.Start();

                                    // оповещаем всех о смене состояния
                                    if (OnPress != null)
                                    {
                                        OnPress(this);
                                        return true;
                                    }
                                }
                            }
                    }
                    break;

                case Application.EventType.MouseUp:
                    {
                        if (IsVisible && IsActive)
                            if (State == ButtonState.Pressed)
                            {
                                State = ButtonState.Released;

                                mCheckHoldKey.Stop();

                                var isHandled = false;
                                // оповещаем всех о смене состояния
                                if (DateTime.Now.Subtract(mPreviousReleaseEvent).TotalMilliseconds < kDoubleClickTimeout)
                                {
                                    if (OnDoubleClick != null)
                                    {
                                        OnDoubleClick(this);
                                        isHandled = true;
                                    }
                                }

                                // оповещаем всех о смене состояния
                                if (OnRelease != null)
                                {
                                    OnRelease(this);
                                    isHandled = true;
                                }

                                mPreviousReleaseEvent = DateTime.Now;
                                return isHandled;
                            }
                    }
                    break;

                case Application.EventType.KeyboardPress:
                    {
                        if (IsVisible && IsActive)
                            if (HotKeycode == ((KeyboardData)aData).Keycode)
                                if (State != ButtonState.Pressed)
                                {
                                    // меняем внутреннее состояние
                                    State = ButtonState.Pressed;

                                    mCheckHoldKey.Start();

                                    // оповещаем всех о смене состояния
                                    if (OnPress != null)
                                    {
                                        OnPress(this);
                                        return true;
                                    }
                                }
                    }
                    break;

                case Application.EventType.KeyboardRelease:
                    {
                        if (IsVisible && IsActive)
                            if (HotKeycode == ((KeyboardData)aData).Keycode)
                                if (State == ButtonState.Pressed)
                                {
                                    State = ButtonState.Released;

                                    mCheckHoldKey.Stop();

                                    var isHandled = false;
                                    // оповещаем всех о смене состояния
                                    if (DateTime.Now.Subtract(mPreviousReleaseEvent).TotalMilliseconds < kDoubleClickTimeout)
                                    {
                                        if (OnDoubleClick != null)
                                        {
                                            OnDoubleClick(this);
                                            isHandled = true;
                                        }                                        
                                    }

                                    // оповещаем всех о смене состояния
                                    if (OnRelease != null)
                                    {
                                        OnRelease(this);
                                        isHandled = true;
                                    }

                                    mPreviousReleaseEvent = DateTime.Now;
                                    return isHandled;
                                }
                    }
                    break;

                case Application.EventType.KeyHold:
                    {
                        if (IsVisible && IsActive)
                            if (ReferenceEquals(this, aData))
                            {
                                mCheckHoldKey.Stop();

                                // оповещаем всех о смене состояния
                                if (OnHold != null)
                                {
                                    OnHold(this);
                                    return true;
                                }

                                return false;
                            }
                    }
                    break;
            }

            return false;
        }

        protected void Resize(int width, int height)
        {
            if (Width == width && Height == height)
                return;

            if(width != 0)
                Width = width;

            if(height != 0)
                Height = height;

            if (mRenderBuffer != null)
                mRenderBuffer.Dispose();

            if (Width == 0 || Height == 0) return;

            mRenderBuffer = new RenderBuffer(Width, Height, PixelFormat);
            Invalidate();
        }

        private void InitWidget(int x = 0, int y = 0, int width = 0, int height = 0)
        {
            Name = "unknown";
            State = ButtonState.Released;

            Move(x, y);
            Resize(width, height);
            RotateCenter = new GfxPoint(0, 0);
            //RotateCenter = new GfxPoint(Width / 2, Height / 2);
            Rotate(0);

            IsVisible = true;
            IsActive = true;

            mCheckHoldKey.OnTimeout += sender => 
                mApplication.PostEvent(Application.EventType.KeyHold, this);
        }

        protected internal void AddChild(IWidget aChild)
        {
            mChilds.Add(aChild);
            Invalidate();
        }

        protected internal void RemoveChild(IWidget aChild)
        {
            mChilds.Remove(aChild);
            Invalidate();
        }

        protected internal Widget()
        {
            mApplication = Application.GetInstance();
            InitWidget();
        }

        protected internal Widget(IWidget parent)
        {
            mApplication = Application.GetInstance();
            Parent = parent;
            InitWidget();
        }

        protected internal Widget(IWidget parent, int width, int height)
        {
            mApplication = Application.GetInstance();
            Parent = parent;
            InitWidget(0, 0, width, height);
        }

        protected internal Widget(IWidget parent, int x, int y, int width, int height)
        {
            mApplication = Application.GetInstance();
            Parent = parent;
            InitWidget(x, y, width, height);
        }

        //public static VGImageFormat PixelFormat = VGImageFormat.VG_sABGR_8888; //
        public static VGImageFormat PixelFormat = VGImageFormat.VG_sRGBA_8888; //        

        public virtual void Invalidate()
        {
            if(IsDirty)
                return;

            IsDirty = true;
            
            if(this as IWindow != null)
                mApplication.PostEvent(Application.EventType.Invalidate, this);
            else
                mApplication.PostEvent(Application.EventType.Invalidate, RootWindow);
        }

        public string Name
        {
            get
            {
                if (Parent != null)
                    return (Parent.Name + "." + mName);

                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public void Show(bool update = false)
        {
            IsVisible = true;

            if (OnShow != null)
                OnShow(this);

            if (update)
                Update();
        }


        public void Hide(bool update = false)
        {
            IsVisible = false;

            if (OnHide != null)
                OnHide(this);

            if (update)
                Update();
        }

        public bool IsVisible
        {
            get { return mIsVisible && Width != 0 && Height != 0; }
            protected set { mIsVisible = value; }
        }

        /// <summary>
        /// Реагируем или нет на события
        /// </summary>
        public bool IsActive { get; private set; }

        public virtual void Move(int x, int y)
        {
            X = x;
            Y = y;
            
            if(Parent != null)
                Parent.Invalidate();
            else
                Invalidate();            
        }

        private IWidget mParent;
        private bool mIsVisible;

        protected List<IWidget> mChilds = new List<IWidget>();
        protected string mName;
        protected int mRotate;
        private GfxPoint mRotateCenter;

        /// <summary>
        /// Перерисовка контента виджета
        /// </summary>
        protected virtual void Draw()
        {

        }

        /// <summary>
        /// Реальная физическая перерисовка, если виджет имеет ширину и высоту и помечен к перерисовке 
        /// </summary>
        public void Redraw(bool force = false)
        {
            if(Height != 0 && Width != 0 && IsDirty)
            {
                //Console.WriteLine("{1}: redraw: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));

                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                VG.vgLoadIdentity();

                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_IMAGE_USER_TO_SURFACE);
                VG.vgLoadIdentity();

                VG.vgSetfv(VGParamType.VG_CLEAR_COLOR, 4, new[] { 1.0f, 1.0f, 1.0f, 0.0f });
                VG.vgClear(0, 0, Width, Height);
                VG.vgFinish();

                // TODO: swap debug only
                if (SwapDebug)
                    mApplication.Swap();

                Draw();
                VG.vgFinish();

                // TODO: swap debug only
                if (SwapDebug)
                    mApplication.Swap();

                mRenderBuffer.Copy(); // TODO: вместо mRenderBuffer.Activate();

                IsDirty = false;
            }

            foreach (var widget in mChilds)
            {
                ((Widget)widget).Redraw();
            }
        }

        public void Update()
        {
            var pos = ScreenPosition;
            Update(new GfxRect(pos.X, pos.Y, Width, Height));
        }

        public virtual void Update(GfxRect updateArea)
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

            mRenderBuffer.ToSurface();

            //Console.WriteLine("<<- {1}: to surface: {0}", Name, DateTime.Now.ToString("mm:ss.fff"));

            foreach (var widget in mChilds.Where(widget => !(widget is ModalWindow)))
                widget.Update();
        }

        public IWidget Parent
        {
            get { return mParent; }
            set
            {
                if (value != null)
                {
                    if (mParent != null)
                    {
                        ((Widget)(mParent)).RemoveChild(this);
                    }

                    ((Widget)(value)).AddChild(this);

                }

                mParent = value;
            }
        }

        public IWindow RootWindow
        {
            get
            {
                var parent = Parent;

                if (parent != null)
                {
                    while (parent.Parent != null)
                    {
                        parent = parent.Parent;
                    }
                }

                return parent as IWindow;
            }
        }

        public void SetTopZlevel(IWidget aChild)
        {
            for (var i = 0; i < mChilds.Count; i++)
            {
                if (mChilds[i] != aChild) continue;

                var last = mChilds[mChilds.Count - 1];
                mChilds[i] = last;
                mChilds[mChilds.Count - 1] = aChild;
            }

            Invalidate();
        }

        public GfxPoint ScreenPosition
        {
            get
            {
                if (Parent != null)
                {
                    var rv = Parent.ScreenPosition;
                    return new GfxPoint(X + rv.X, Y + rv.Y);
                }

                return new GfxPoint(X, Y);
            }
        }

        public ButtonEvent OnPress { get; set; }
        public ButtonEvent OnRelease { get; set; }
        public ButtonEvent OnHold { get; set; }
        public ButtonEvent OnDoubleClick { get; set; }

        public PaintEvent OnShow { get; set; }
        public PaintEvent OnHide { get; set; }
        public PaintEvent OnDeactivate { get; set; }
        public PaintEvent OnActivate { get; set; }
        public PaintEvent OnPaint { get; set; }

        public virtual void Dispose()
        {
            if (mRenderBuffer != null)
                mRenderBuffer.Dispose();

            /*
            foreach (var path in mStaticElement.Where(path => path != null))
            {
                path.Dispose();
            }
            */

            foreach (var child in mChilds.Where(child => child != null))
            {
                child.Dispose();
            }
        }
    }
}
