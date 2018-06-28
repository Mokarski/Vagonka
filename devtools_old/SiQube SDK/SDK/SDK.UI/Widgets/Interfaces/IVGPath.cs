using System;
using SDK.UI.Widgets.Base;

namespace SDK.UI.Widgets.Interfaces
{
    public interface IVGPath : IDisposable
    {
        void Update();
        IntPtr GetPath();

        float StrokeWidth { set; get; }

        void SetStroke(IOpenVGPaint color,
                        float[] dashPattern,
                        VGCapStyle capStyle,
                        VGJoinStyle joinStyle);

        void SetFill(IOpenVGPaint color);

        GfxRect Bounds { get; }

        float X { get; }
        float Y { get; }
        int Width { get; }
        int Height { get; }

        float Scale { get; set; }

    }
}