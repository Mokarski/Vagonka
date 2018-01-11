using System;
using System.Collections.Generic;

namespace SDK.UI.Widgets.Base
{
    public struct Style
    {
        public Color    Background;
        public Color    Border;
        public int      BorderWidth;
    }
    
    public static class Palette
    {
        // http://web.forret.com/tools/color_palette.asp

        public static Color LightSkyBlue = new Color(0x87CEFAFF);
        public static Color LightBlue = new Color(0xADD8E6FF);
        public static Color PaleTurquoise = new Color(0xAFEEEEFF);
        public static Color Blue = new Color (0x0000FFFF);
        public static Color Lime = new Color(0x00FF00FF);
        public static Color Red = new Color(0xFF0000FF);
        public static Color Black = new Color(0x000000FF);
        public static Color White = new Color(0xFFFFFFFF);
        public static Color Orange = new Color(0xFFA500FF);
        public static Color LightGrey = new Color(0xD3D3D3FF);
        public static Color Snow = new Color(0xFFFAFAFF);
        public static Color FloralWhite = new Color(0xFFFAF0FF);
        public static Color Gainsboro = new Color(0xDCDCDCFF);
        public static Color DarkSlateGray = new Color(0x2F4F4FFF);
        public static Color DarkGray = new Color(0xA9A9A9FF);
        public static Color Yellow = new Color(0xA9A9A9FF);

        public static Style Window
        {
            get
            {
                return new Style{ Background = new Color(0x1A1D1FFF) };
            }
        }

        public static Style TextArea
        {
            get
            {
                return new Style { Background = new Color(0xFCFCFCFF), Border = new Color(0xC0C0C0FF) };
            }
        }

    }
    
    public class Color
    {               
        public Color(uint rgba)
        {
            R = ((rgba >> 24) & 0xff)/255f;
            G = ((rgba >> 16) & 0xff)/255f;
            B = ((rgba >> 8) & 0xff)/255f;
            A = (rgba & 0xff) / 255f;
        }

        public Color()
        {
            R = G = B = 0.0f;
            A = 1.0f;
        }

        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }

        public float[] Value
        {
            get
            {
                return new[]{R, G, B, A};
            }
            set
            {
                R = value[0];
                G = value[1];
                B = value[2];
                A = value[3];
            }
        }
    }

    public interface IOpenVGPaint : IDisposable
    {
        void SetPaint(VGPaintMode mode);
    }

    public class VGSolidColor : IOpenVGPaint
    {
        private readonly IntPtr mPaint;

        public VGSolidColor(Color color)
        {
            mPaint = VG.vgCreatePaint();
            VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, color.Value);
        }

        public void SetPaint(VGPaintMode mode)
        {
            if (mPaint != IntPtr.Zero)
                VG.vgSetPaint(mPaint, mode);
        }

        public void Dispose()
        {
            if (mPaint != new IntPtr())
                VG.vgDestroyPaint(mPaint);
        }

        public void SetColor(Color color)
        {
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, color.Value);
        }
    }

    public class VGLinearGradient : IOpenVGPaint
    {
        private IntPtr mPaint;
        private readonly List<float> mColorRamps = new List<float>();
        private byte mPercent;


        public VGLinearGradient(float x0, float y0, float x1, float y1)
        {
            Initialize();
            Move(x0, y0, x1, y1);
        }

        private void Initialize()
        {
            mPaint = VG.vgCreatePaint();
            VG.vgSetParameteri(mPaint, (int) VGPaintParamType.VG_PAINT_TYPE, (int) VGPaintType.VG_PAINT_TYPE_LINEAR_GRADIENT);

            VG.vgSetParameteri(mPaint, (int) VGPaintParamType.VG_PAINT_COLOR_RAMP_SPREAD_MODE,
                               (int) VGColorRampSpreadMode.VG_COLOR_RAMP_SPREAD_PAD); // repeat type
            //VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR_RAMP_PREMULTIPLIED, (int)VGboolean.VG_FALSE); // 
            VG.vgSetParameteri(mPaint, (int) VGPaintParamType.VG_PAINT_COLOR_RAMP_PREMULTIPLIED, (int) VGboolean.VG_TRUE); // 
        }

        public bool AddColor(byte percent, Color color)
        {
            if (color == null)
                return false;

            if (percent > 100)
                percent = 100;

            if (mPercent == 100)
                return false;

            if (mPercent < percent || percent == 0)
                mPercent = percent;
            else
                return false;

            mColorRamps.Add(mPercent / 100f);
            mColorRamps.AddRange(color.Value);

            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR_RAMP_STOPS, mColorRamps.Count, mColorRamps.ToArray());

            return true;
        }

        public void Move(float x0, float y0, float x1, float y1)
        {
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_LINEAR_GRADIENT, 4, new[] { x0, y0, x1, y1 });
        }

        public void SetPaint(VGPaintMode mode)
        {
            if (mPaint != IntPtr.Zero)
                VG.vgSetPaint(mPaint, mode);
        }

        public void Dispose()
        {
            if (mPaint != new IntPtr())
                VG.vgDestroyPaint(mPaint);
        }
    }

    public class VGRadialGradient : IOpenVGPaint
    {
        private IntPtr mPaint;
        private readonly List<float> mColorRamps = new List<float>();
        private byte mPercent;


        public VGRadialGradient(float cx, float cy, float radius)
        {
            Initialize();
            Move(cx, cy, cx, cy, radius);
        }

        private void Initialize()
        {
            mPaint = VG.vgCreatePaint();
            VG.vgSetParameteri(mPaint, (int) VGPaintParamType.VG_PAINT_TYPE, (int) VGPaintType.VG_PAINT_TYPE_RADIAL_GRADIENT);

            VG.vgSetParameteri(mPaint, (int) VGPaintParamType.VG_PAINT_COLOR_RAMP_SPREAD_MODE,
                               (int) VGColorRampSpreadMode.VG_COLOR_RAMP_SPREAD_PAD); // repeat type
            VG.vgSetParameteri(mPaint, (int) VGPaintParamType.VG_PAINT_COLOR_RAMP_PREMULTIPLIED, (int) VGboolean.VG_TRUE); // 
            //VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR_RAMP_PREMULTIPLIED, (int)VGboolean.VG_FALSE); // 
        }

        public VGRadialGradient(float cx, float cy, float fx, float fy, float radius)
        {
            Initialize();
            Move(cx, cy, fx, fy, radius);
        }

        public bool AddColor(byte percent, Color color)
        {
            if (color == null)
                return false;

            if (percent > 100)
                percent = 100;

            if (mPercent == 100)
                return false;

            if (mPercent < percent || percent == 0)
                mPercent = percent;
            else
                return false;

            mColorRamps.Add(mPercent / 100f);
            mColorRamps.AddRange(color.Value);

            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR_RAMP_STOPS, mColorRamps.Count, mColorRamps.ToArray());

            return true;
        }

        public void Move(float cx, float cy, float fx, float fy, float radius)
        {
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_RADIAL_GRADIENT, 5, new[] { cx, -cy, fx, -fy, radius });
        }

        public void SetPaint(VGPaintMode mode)
        {
            if (mPaint != IntPtr.Zero)
                VG.vgSetPaint(mPaint, mode);
        }

        public void Dispose()
        {
            if (mPaint != new IntPtr())
                VG.vgDestroyPaint(mPaint);
        }
    }

}