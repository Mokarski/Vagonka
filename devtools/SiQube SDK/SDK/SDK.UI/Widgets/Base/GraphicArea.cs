using System;
using System.Collections.Generic;
using System.Linq;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class GraphicsData
    {
        public Color Color = Palette.Red;
        public GfxPoint Position = new GfxPoint();
        public float StrokeWidth = 1.5f;

        public ushort[] Data;

        public GraphicsData() { }

        public GraphicsData(GraphicsData reflect)
        {
            Color = new Color
                        {
                            A = reflect.Color.A,
                            R = reflect.Color.R,
                            G = reflect.Color.G,
                            B = reflect.Color.B,
                        };
            Position = new GfxPoint(reflect.Position.X, reflect.Position.Y);
            StrokeWidth = reflect.StrokeWidth;

            Data = reflect.Data;
        }
    }

    public interface IGraphicArea
    {
        List<GraphicsData> Grapics { get; }

        Color Background { get; set; }
        VGPath Grid { get; set; }
        VGPath Arrows { get; set; }
    }

    public class GraphicArea : Widget, IGraphicArea
    {
        internal readonly IntPtr mPath = IntPtr.Zero;
        internal readonly IntPtr mPaint = IntPtr.Zero;
        internal readonly List<GraphicsData> mGrapihcs;


        public GraphicArea(IWidget parent, int width, int height)
            : base(parent, width, height)
        {
            //Width = width; // 460
            //Height = height; // 220

            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            mPaint = VG.vgCreatePaint();

            mGrapihcs = new List<GraphicsData>();
        }

        public Color Background { get; set; }

        public VGPath Grid { get; set; }
        public VGPath Arrows { get; set; }

        public List<GraphicsData> Grapics
        {
            get { return mGrapihcs; }
        }

        protected override void Draw()
        {
            // draw bg
            if (Background != null)
            {
                VG.vgSetfv(VGParamType.VG_CLEAR_COLOR, 4, Background.Value);
                VG.vgClear(X, Y, Width, Height);
            }

            if (Grid != null)
            {
                Grid.Update();
            }

            if (Arrows != null)
            {
                Arrows.Update();
            }

            // draw line
            if (mGrapihcs.Count > 0) 
            foreach (var data in from data in mGrapihcs where data != null where data.Data != null where data.Data.Length > 0 select data)
            {
                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                VG.vgLoadIdentity();
                VG.vgTranslate(X + data.Position.X, Y + data.Position.Y); // (40, 20)

                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, data.StrokeWidth);
                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, data.Color != null ? data.Color.Value : Palette.Black.Value);
                VG.vgSetPaint(mPaint, VGPaintMode.VG_STROKE_PATH);

                VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
                var size = (data.Data.Length - 1) > (Width - data.Position.X) ? (Width - data.Position.X) : (data.Data.Length - 1);
                for (var i = 0; i < size; i++)
                    VGU.vguLine(mPath, i, data.Data[i], i + 1, data.Data[i + 1]);

                VG.vgDrawPath(mPath, VGPaintMode.VG_STROKE_PATH);
            }
        }

        public override void Dispose()
        {
            if (mPath != IntPtr.Zero)
                VG.vgDestroyPath(mPath);

            if (mPaint != IntPtr.Zero)
                VG.vgDestroyPaint(mPaint);

            base.Dispose();
        }
    }
}
