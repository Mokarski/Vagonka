using System;

namespace SDK.UI.Widgets.Interfaces
{

    public class GfxPoint
    {
        public int X;
        public int Y;

        public GfxPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public GfxPoint() {}

        public override string ToString()
        {
            return "X: " + X + ", Y: " + Y;
        }
    }

    public class GfxSize
    {
        public int Width;
        public int Height;

        public GfxSize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return "W: " + Width + ", H: " + Height;
        }
    }

    public class GfxRect
    {
        public int Width;
        public int Height;
        public int X;
        public int Y;

        public GfxRect(int x, int y, int width, int height)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }

        public GfxPoint Position
        {
            get
            {
                return new GfxPoint(X, Y);
            }
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        public GfxSize Dimenstion
        {
            get
            {
                return new GfxSize(Width, Height);
            }
            set
            {
                Width = value.Width;
                Height = value.Height;
            }
        }

        public override string ToString()
        {
            return "X: " + X + ", Y: " + Y + ", W: " + Width + ", H: " + Height;
        }
    }


    public enum ButtonState
    {
        Released,
        Pressed
    }

    public delegate void ButtonEvent(IWidget caller);
    public delegate void PaintEvent(IWidget caller);

    public interface IWidget : IDisposable
    {
        /// <summary>
        /// Имя виджета, не уникально
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Родительский виджет, если указанный виджет равен null значит данный виджет окно. 
        /// </summary>
        IWidget Parent { get; set; }

        /// <summary>
        /// Корневое окно
        /// </summary>
        IWindow RootWindow { get; }

        /// <summary>
        /// Передвинуть виджет на новые координаты
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Move(int x, int y);

        /// <summary>
        /// Повернуть виджет
        /// </summary>
        /// <param name="angle"></param>
        void Rotate(int angle);

        /// <summary>
        /// Центр поворота виджета - по умолчанию левый нижний угол виджета
        /// </summary>
        GfxPoint RotateCenter { get; set; }

        /// <summary>
        /// Показать виджет
        /// </summary>
        /// <param name="update"></param>
        void Show(bool update);

        /// <summary>
        /// Спрятать виджет
        /// </summary>
        /// <param name="update"></param>
        void Hide(bool update);

        /// <summary>
        /// Виджет видим на экране?
        /// </summary>
        bool IsVisible { get; }

        /// <summary>
        /// Виджет активен для приема сообщений от элементов управления (мышь, кнопка, сеносрный экран)
        /// </summary>
        /// <param name="status"></param>
        void Activate(bool status);
        bool IsActive { get; }

        /// <summary>
        /// Х координата в рамках корневого окна или родительского виджета
        /// </summary>
        int X { get; }
        int Y { get; }

        int Width { get; }
        int Height { get; }

        /// <summary>
        /// Синхронная операцая перерисовки данного виджета
        /// </summary>
        void Update();

        /// <summary>
        /// Пометить текущее графическое представление не соответвующим действительности.
        /// В текущей версии данный вызов просто вызывает Invalidate родителя если Parent != null,
        /// в противном случае уведомляет application
        /// </summary>
        void Invalidate();

        /// <returns>true - событие обработано виджетом, false - событие проигнорировано виджетом</returns>
        bool HandleEvent(Application.EventType aType, object aData);

        /// <summary>
        /// Поставить виджет на самый вверх в стеке виджетов корневого окна
        /// </summary>
        /// <param name="aWidget"></param>
        void SetTopZlevel(IWidget aWidget);

        ButtonEvent OnPress { get; set; }
        ButtonEvent OnRelease { get; set; }
        ButtonEvent OnHold { get; set; }
        ButtonEvent OnDoubleClick { get; set; }

        /// <summary>
        /// Абсолютные координаты виджета в рамках экрана
        /// </summary>
        GfxPoint ScreenPosition { get; }

        /// <summary>
        /// On set window visible 
        /// </summary>
        PaintEvent OnShow { get; set; }

        /// <summary>
        /// On set window invisible
        /// </summary>
        PaintEvent OnHide { get; set; }

        /// <summary>
        /// On set window visible 
        /// </summary>
        PaintEvent OnDeactivate { get; set; }

        /// <summary>
        /// On set window invisible
        /// </summary>
        PaintEvent OnActivate { get; set; }

        /// <summary>
        /// Syncro draw
        /// </summary>
        PaintEvent OnPaint { get; set; }
    }
}
