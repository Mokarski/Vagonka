using System;
using System.Collections.Generic;
using System.Globalization;
using SDK.SignalsFactory;
using SDK.SignalsFactory.Interface;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WVGA.Sparc
{
    public class Angle
    {
        private static float RecalculateAngle(int arg, int z)
        {
            const float kRange = 1023.0f;
            // normalization and calculate angle between the board and the horizontal plain
            if (arg > kRange)
                arg = (int)kRange;
            else if (arg < -kRange)
                arg = (int)(-kRange);


            var rv = (float)Math.Asin(arg / kRange);
            if (rv >= 0)
                if (z < 0)
                    rv = (float)(Math.PI - rv);
                else
                    if (z < 0)
                        rv = (float)(-Math.PI - rv);

            //(float)((roll * 180.0) / (Math.PI))
            return (float)((rv * 180.0) / (Math.PI));
        }

        public static float[] GetValue(int x, int y, int z)
        {
            return new[] { RecalculateAngle(x, z), RecalculateAngle(y, z) };
        }
    }


    public interface IInfoIcon
    {
        float MaxValue { get; set; }
        //void SetValue(float arg, string format);
        //void SetColor(float[] color);
    }

    #region radial icon
    public class RadialInfoIcon : Widget, IInfoIcon
    {
        private readonly ISignal mSensor;
        private readonly string mDescription;
        private readonly string mPhysical;
        private static IntPtr mPath;
        private static bool mInitialized;
        private Image mImageBg;
        private Image mImageFg;
        private static IntPtr mCircle;
        private byte mPercent = 10;
        private TextArea mActiveArea;

        public RadialInfoIcon(IWidget parent, ISignal sensor, int x, int y, string description, string physical)
            : base(parent, 100, 100)
        {
            mSensor = sensor;
            mDescription = description;
            mPhysical = physical;
            Init(x, y);
            mImageBg.Load("wvga.infoicon.bg.raw");
            mImageFg.Load("wvga.infoicon.fg.raw");
        }

        private void Init(int x, int y)
        {
            InitBackground();

            mPaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, Palette.Red.Value);

            mImageBg = new Image(this, 8, 25);
            mImageFg = new Image(this, 8, 25);
            Text.Label(this, mDescription, 14, 0, 0, Width, 14);
            Text.Label(this, mPhysical, 15, 0, Height - 36, Width, 15);

            mActiveArea = new TextArea(this, 0, (int)(Height * 0.38f), Width, 30);
            mActiveArea.SetAlign(Align.Center, new GfxPoint(0, 5));
            mActiveArea.SetFont(Palette.White, 35);

            AddVGPath(new VGPath(mPath, null, new VGSolidColor(new Color(0x2c2d2eff))));

            Format = "{0:0}";
            SetValue(0);
            mSensor.OnUpdate += sensor => SetValue(sensor.Value / 10.0f);

            Move(x, y);
        }

        private void InitBackground()
        {
            if (mInitialized)
                return;

            const int kRound = 10;

            mPath = VGPath.OpenVGPath();
            VGU.vguRoundRect(mPath, 0, 0, Width, Height, kRound, kRound);

            mCircle = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_F, 1.0f, 0.0f, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

            mInitialized = true;
        }

        private IntPtr mPaint;

        private float Cos(float angle)
        {
            return (float)Math.Cos((angle * Math.PI) / 180.0f);
        }

        private float Sin(float angle)
        {
            return (float)Math.Sin((angle * Math.PI) / 180.0f);
        }

        private void VguArc(IntPtr path, float x, float y, float width, float height, float startAngle, float angleExtent)
        {
            var commands = new List<byte>();
            var parameters = new List<float>();

            var dataArc = new float[5];
            float rx = width / 2, ry = height / 2;

            var last = startAngle + angleExtent;

            VG.vgClearPath(path, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);


            commands.Add((byte)VGPathCommand.VG_MOVE_TO_ABS);
            parameters.AddRange(new[] { x + Cos(startAngle) * rx, y + Sin(startAngle) * ry });

            dataArc[0] = rx;
            dataArc[1] = ry;
            dataArc[2] = 0.0f;

            if (angleExtent > 0)
            {

                var angle = startAngle + 180;
                while (angle < last)
                {
                    dataArc[3] = x + Cos(angle) * rx;
                    dataArc[4] = y + Sin(angle) * ry;
                    commands.Add((byte)VGPathCommand.VG_SCCWARC_TO_ABS);
                    parameters.AddRange(dataArc);

                    angle += 180.0f;
                }

                dataArc[3] = x + Cos(last) * rx;
                dataArc[4] = y + Sin(last) * ry;
                commands.Add((byte)VGPathCommand.VG_SCCWARC_TO_ABS);
                parameters.AddRange(dataArc);

            }
            else
            {
                var angle = startAngle - 180;
                while (angle > last)
                {
                    dataArc[3] = x + Cos(angle) * rx;
                    dataArc[4] = y + Sin(angle) * ry;
                    commands.Add((byte)VGPathCommand.VG_SCWARC_TO_ABS);
                    parameters.AddRange(dataArc);

                    angle -= 180.0f;
                }

                dataArc[3] = x + Cos(last) * rx;
                dataArc[4] = y + Sin(last) * ry;
                commands.Add((byte)VGPathCommand.VG_SCWARC_TO_ABS);
                parameters.AddRange(dataArc);
            }

            VG.vgAppendPathData(path, commands.Count, commands.ToArray(), parameters.ToArray());
            VG.vgDrawPath(path, VGPaintMode.VG_STROKE_PATH);
            VG.vgFinish();
        }

        public override void Draw()
        {
            /*
            var screen = ScreenPosition;
            foreach (var path in mStaticElement)
                path.Update(screen.X, screen.Y);

            mImageBg.Update();
            */
            //base.Update();
            #region draw circle

            {
                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                VG.vgLoadIdentity();

                VG.vgClearPath(mCircle, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 6.0f);
                VG.vgSetPaint(mPaint, VGPaintMode.VG_STROKE_PATH);
                VG.vgSetfv(VGParamType.VG_STROKE_DASH_PATTERN, 0, null);

                const float kFullScale = -250;
                VguArc(mCircle, X + Width / 2, Y + Height / 2 + 5, 74, 74, 215, kFullScale * (Percent / 100.0f));
            }

            #endregion

            mImageFg.Update();

            VG.vgFinish();
        }

        private byte Percent
        {
            get { return mPercent; }
            set
            {
                mPercent = (byte)(value > 100 ? 100 : value);
            }
        }

        public float MaxValue { get; set; }

        public float[] Color
        {
            set
            {
                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, value);
            }
        }
        public string Format { get; set; }

        public void SetValue(float arg)//, string format = "{0:0.0}")
        {
            Percent = (byte)(arg * 100.0f / MaxValue);
            mActiveArea.Text = string.Format(CultureInfo.InvariantCulture, Format, arg);
        }

        public void SetColor(float[] color)
        {
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, color);
        }
    }
    #endregion

    #region linear icon
    public class LinearInfoIcon : Widget, IInfoIcon
    {
        private readonly ISignal mSensor;
        private readonly string mDescription;
        private static IntPtr mPath;
        private static bool mInitialized;

        private static IntPtr mLinear;
        private byte mPercent = 10;
        private TextArea mActiveArea;

        private void Init(int x, int y)
        {
            InitBackground();

            Text.Label(this, mDescription, 14, 0, 0, Width, 14);
            //Text.Label(this, "100%", 14, 0, 0, Width, 14);
            //Text.Label(this, "0%", 14, 0, 0, Width, 14);

            mPaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, (new Color(0xEDAB18ff)).Value);

            Format = "{0:0}";
            mActiveArea = new TextArea(this, Width - 40, (int)(Height * 0.45f), 40, 30);//
            SetValue(0);

            mActiveArea.SetAlign(Align.Left, new GfxPoint(0, 5));
            mActiveArea.SetFont(Palette.White, 22);

            AddVGPath(new VGPath(mPath, null, new VGSolidColor(new Color(0x2c2d2eff))));

            {
                var i = VGPath.OpenVGPath();
                VGU.vguRect(i, 0, 0, 45, 59);
                var rv = new VGPath(i, new VGSolidColor(new Color(0x6d6e71ff)), new VGSolidColor(new Color(0x414041ff))) { StrokeWidth = 1.0f };
                rv.Move(X + 12, Y + 32);
                AddVGPath(rv);
            }

            mSensor.OnUpdate += sensor => SetValue(sensor.Value / 10.0f);


            Move(x, y);
        }

        private readonly float[] mDashPattern = new[] { 1.0f, 1.0f };
        private IntPtr mPaint;

        public LinearInfoIcon(IWidget parent, ISignal sensor, int x, int y, string description)
            : base(parent, 100, 100)
        {
            mSensor = sensor;
            mDescription = description;
            Init(x, y);
        }

        private void InitBackground()
        {
            if (mInitialized)
                return;

            const int kRound = 10;

            mPath = VGPath.OpenVGPath();
            VGU.vguRoundRect(mPath, 0, 0, Width, Height, kRound, kRound);

            mLinear = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_F, 1.0f, 0.0f, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

            mInitialized = true;
        }

        public override void Draw()
        {
            //base.Update();
            #region draw circle

            {
                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                VG.vgLoadIdentity();

                VG.vgClearPath(mLinear, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 40.0f);
                VG.vgSetPaint(mPaint, VGPaintMode.VG_STROKE_PATH);
                VG.vgSetfv(VGParamType.VG_STROKE_DASH_PATTERN, mDashPattern.Length, mDashPattern);


                const float kFullScale = 55;
                var rv = kFullScale * (Percent / 100.0f);
                VGU.vguLine(mLinear, X + 35, Y + 35, X + 35, Y + 35 + rv);
                VG.vgDrawPath(mLinear, VGPaintMode.VG_STROKE_PATH);
                VG.vgFinish();
            }

            #endregion

            VG.vgFinish();
        }

        private byte Percent
        {
            get { return mPercent; }
            set
            {
                mPercent = (byte)(value > 100 ? 100 : value);
            }
        }

        public float MaxValue { get; set; }

        public string Format { get; set; }

        public float[] Color
        {
            set
            {
                VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, value);
            }
        }

        private void SetValue(float arg)
        {
            Percent = (byte)(arg * 100.0f / MaxValue);
            mActiveArea.Text = string.Format(CultureInfo.InvariantCulture, Format, arg);
        }
    }
    #endregion

    #region speed icon
    public class SpeedIcon : Widget
    {
        private readonly ISignal mSensor;
        private readonly byte mCount;
        private IntPtr mActivePaint;
        private IntPtr mDefaultPaint;
        private IntPtr mPath;
        private byte mSpeed;
        private List<TextArea[]> mText;

        public SpeedIcon(IWidget parent, ISignal sensor, int x, byte count)
            : base(parent)
        {
            mSensor = sensor;
            mCount = count;

            Init(x);
        }

        private void Init(int x)
        {
            //Width = 16;
            //Height = mCount * (Width + 5) - 5;
            //Y = (Application.Screen.Height - Height) / 2 + 10;

            Resize(16, mCount * (Width + 5) - 5);
            

            mPath = VGPath.OpenVGPath();

            mActivePaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mActivePaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, (new Color(0x2EBF0EFF)).Value);

            mDefaultPaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mDefaultPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, (new Color(0x3B3C3DFF)).Value);

            mText = new List<TextArea[]>();

            for (var i = 0; i < mCount; i++)
            {
                mText.Add(Text.Label(this, string.Format("{0}", i + 1), 17, -1, (i * (Width + 5)) - 3, 16, 16));
            }

            SetSpeed(0);
            mSensor.OnUpdate += sensor => SetSpeed((byte)sensor.Value);

            Move(x, (Application.Screen.Height - Height) / 2 + 10);
        }

        private void SetSpeed(byte speed)
        {
            mSpeed = (byte) (speed + 1);
        }

        public override void Draw()
        {
            {
                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                VG.vgLoadIdentity();


                for (var i = 0; i < mCount; i++)
                {
                    VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                    if (i == (mSpeed - 1))
                    {
                        VG.vgSetPaint(mActivePaint, VGPaintMode.VG_FILL_PATH);
                        mText[i][0].SetFont(Palette.Black);
                    }
                    else
                    {
                        VG.vgSetPaint(mDefaultPaint, VGPaintMode.VG_FILL_PATH);
                        mText[i][0].SetFont(Palette.White);
                    }

                    VGU.vguRoundRect(mPath, X, Y + i * (Width + 5), Width, Width, 5, 5);
                    VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
                    VG.vgFinish();
                }
            }
            //base.Update();
        }

    }
    #endregion

    #region vagon icon
    public class VagonIcon : Widget
    {
        private readonly ISignal mPump;
        private readonly ISignal mUz2;
        private readonly ISignal mUz3;
        private readonly ISignal mUz4;
        private readonly ISignal mUz5;
        private readonly ISignal mConveyor;

        internal class Rect
        {
            public IntPtr Path;
            public float[] Color { get; set; }
        }

        private readonly Image mImage;
        private readonly List<Rect> mRects = new List<Rect>();
        private readonly float[] mDefaultColor = new Color(0x1f1f1fFF).Value;
        private readonly float[] mActiveColor = new Color(0x2EC90EFF).Value;
        private readonly float[] mFaultColor = new Color(0xE3AB1FFF).Value;
        private readonly IntPtr mPaint;

        public VagonIcon(IWidget parent, ISignal pump, ISignal uz2, ISignal uz3, ISignal uz4, ISignal uz5, ISignal conveyor, int y)
            : base(parent)
        {
            mPump = pump;
            #region насосная станция
            mPump.OnUpdate += sensor =>
            {
                switch (sensor.ValueAsInt)
                {
                    case 0:// stop
                        {
                            EngineNormal(0);
                        }
                        break;
                    case 1:// active
                        {
                            EngineActive(0);
                        }
                        break;
                    case 2:// fault
                        {
                            EngineFault(0);
                        }
                        break;
                }
            };
            #endregion

            mUz2 = uz2;
            #region ПЧН 1
            mUz2.OnUpdate += sensor =>
            {
                switch (sensor.ValueAsInt)
                {
                    case 0:// stop
                        {
                            EngineNormal(1);
                        }
                        break;
                    case 1:// active
                        {
                            EngineActive(1);
                        }
                        break;
                    case 2:// fault
                        {
                            EngineFault(1);
                        }
                        break;
                }
            };
            #endregion

            mUz3 = uz3;
            #region ПЧН 2
            mUz3.OnUpdate += sensor =>
            {
                switch (sensor.ValueAsInt)
                {
                    case 0:// stop
                        {
                            EngineNormal(2);
                        }
                        break;
                    case 1:// active
                        {
                            EngineActive(2);
                        }
                        break;
                    case 2:// fault
                        {
                            EngineFault(2);
                        }
                        break;
                }
            };
            #endregion

            mUz4 = uz4;
            #region ПЧН 3
            mUz4.OnUpdate += sensor =>
            {
                switch (sensor.ValueAsInt)
                {
                    case 0:// stop
                        {
                            EngineNormal(3);
                        }
                        break;
                    case 1:// active
                        {
                            EngineActive(3);
                        }
                        break;
                    case 2:// fault
                        {
                            EngineFault(3);
                        }
                        break;
                }
            };
            #endregion

            mUz5 = uz5;
            #region ПЧН4
            mUz5.OnUpdate += sensor =>
            {
                switch (sensor.ValueAsInt)
                {
                    case 0:// stop
                        {
                            EngineNormal(4);
                        }
                        break;
                    case 1:// active
                        {
                            EngineActive(4);
                        }
                        break;
                    case 2:// fault
                        {
                            EngineFault(4);
                        }
                        break;
                }
            };
            #endregion

            mConveyor = conveyor;
            #region конвейер
            mConveyor.OnUpdate += sensor =>
            {
                switch (sensor.ValueAsInt)
                {
                    case 0:// stop
                        {
                            EngineNormal(5);
                        }
                        break;
                    case 1:// active
                        {
                            EngineActive(5);
                        }
                        break;
                    case 2:// fault
                        {
                            EngineFault(5);
                        }
                        break;
                }
            };
            #endregion

            mImage = new Image(this, 0, 0);
            const float kScale = 1.0f;
            mImage.Scale(kScale, kScale);
            mImage.Load("./wvga.vagon.raw");

            //Width = (int)(mImage.Width * kScale);
            //Height = (int)(mImage.Height * kScale);
            Resize((int)(mImage.Width * kScale), (int)(mImage.Height * kScale));
            Init(y);

            for (var i = 0; i < 6; i++)
                mRects.Add(new Rect { Path = VGPath.OpenVGPath(), Color = mDefaultColor });

            var pos = ScreenPosition;

            VGU.vguRect(mRects[0].Path, pos.X + 145, pos.Y + mImage.Height - 30, 35, 20);
            VGU.vguRect(mRects[1].Path, pos.X + 75, pos.Y + mImage.Height - 35, 30, 25);
            VGU.vguRect(mRects[2].Path, pos.X + 185, pos.Y + mImage.Height - 35, 30, 25);
            VGU.vguRect(mRects[3].Path, pos.X + 75, pos.Y + 10, 30, 25);
            VGU.vguRect(mRects[4].Path, pos.X + 185, pos.Y + 10, 30, 25);
            VGU.vguRect(mRects[5].Path, pos.X + 10, pos.Y + mImage.Height / 2 - 20, mImage.Width - 20, 40);

            mPaint = VG.vgCreatePaint();
        }

        private void Init(int y)
        {
            Move((Application.Screen.Width - Width) / 2, y);
        }

        public override void Draw()
        {

            //base.Update();

            {
                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                VG.vgLoadIdentity();

                foreach (var rect in mRects)
                {
                    VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, rect.Color);
                    VG.vgSetPaint(mPaint, VGPaintMode.VG_FILL_PATH);

                    VG.vgDrawPath(rect.Path, VGPaintMode.VG_FILL_PATH);
                    VG.vgFinish();
                }
            }

            //base.Update();
        }

        private void EngineFault(int i)
        {
            mRects[i].Color = mFaultColor;
        }

        private void EngineNormal(int i)
        {
            mRects[i].Color = mDefaultColor;
        }

        private void EngineActive(int i)
        {
            mRects[i].Color = mActiveColor;
        }
    }
    #endregion

    // TODO: не привязан
    #region крен-тангаж
    public class AngleInfoIcon : Widget
    {
        private static IntPtr mPath;
        private static bool mInitialized;

        private TextArea mPitchArea;
        private TextArea mRollArea;

        private void Init(int x, int y)
        {
            InitBackground();

            mImage = new Image(this, 9, 25);
            mImage.Load("./wvga.roll_tangage.raw");

            Text.Label(this, "Тангаж", 14, 0, 0, Width, 14);
            Text.Label(this, "Крен", 14, 0, Height - 20, Width, 14);

            mPaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, (new Color(0xEDAB18ff)).Value);

            mPitchArea = new TextArea(this, Width - 25, 80, 24, 30) { Text = "" };
            mPitchArea.SetAlign(Align.Right, new GfxPoint(0, 5));
            mPitchArea.SetFont(Palette.White, 16);
            mPitchArea.OnPaint += caller =>
            {
                ((TextArea)caller).Text = string.Format("{0} ⁰", Pitch);
            };


            mRollArea = new TextArea(this, Width - 25, 5, 24, 30) { Text = "" };
            mRollArea.SetAlign(Align.Right, new GfxPoint(0, 5));
            mRollArea.SetFont(Palette.White, 16);
            mRollArea.OnPaint += caller =>
                                     {
                                         ((TextArea)caller).Text = string.Format("{0} ⁰", Roll);
                                     };

            AddVGPath(new VGPath(mPath, null, new VGSolidColor(new Color(0x2c2d2eff))));

            Move(x, y);
        }

        private IntPtr mPaint;
        private Image mImage;

        public AngleInfoIcon(IWidget parent, int x, int y)
            : base(parent, 100, 100)
        {
            Init(x, y);
        }

        private void InitBackground()
        {
            if (mInitialized)
                return;

            const int kRound = 10;

            mPath = VGPath.OpenVGPath();
            VGU.vguRoundRect(mPath, 0, 0, Width, Height, kRound, kRound);

            mInitialized = true;
        }

        public int Roll { get; set; }
        public int Pitch { get; set; }

    }
    #endregion

    #region filter
    public class FilterInfoIcon : Widget
    {
        private readonly ISignal mSensor;
        private readonly ISignal mStatus;
        private static IntPtr mPath;
        private static bool mInitialized;

        private TextArea mRollArea;

        public int MaxValue { get; set; }

        private void Init(int x, int y)
        {
            InitBackground();

            mImage = new Image(this, 10, 35);
            mImage.Load("./wvga.filter.raw");

            Text.Label(this, "Фильтр\\nв системе смазки", 14, 0, 0, Width, 14);

            mPaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, (new Color(0xEDAB18ff)).Value);


            mRollArea = new TextArea(this, Width - 50, 45, 49, 30) { Text = "" };
            mRollArea.SetAlign(Align.Center, new GfxPoint(0, 5));
            mRollArea.SetFont(Palette.White, 16);

            const int kLimit = 10;
            mRollArea.Text = string.Format("{0}", "Отключен");
            VG.vgSetParameterfv(mFilterPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new Color(0x2EC90Eff).Value);

            mSensor.OnUpdate += sensor =>
                                    {
                                        if (mStatus.ValueAsInt == 0)
                                        {
                                            mRollArea.Text = string.Format("{0}", "Отключен");
                                            VG.vgSetParameterfv(mFilterPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new Color(0x2EC90Eff).Value);
                                        }
                                        else
                                        {
                                            mRollArea.Text = string.Format("{0}", sensor.Value / 10.0f);
                                            //mRollArea.Text = string.Format("{0}", sensor.Value > kLimit ? "Норма" : "Авария");
                                            VG.vgSetParameterfv(mFilterPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4,
                                                sensor.Value > kLimit ? (new Color(0x2EC90Eff)).Value : (new Color(0xE3AB1Fff)).Value);
                                        }
                                    };

            AddVGPath(new VGPath(mPath, null, new VGSolidColor(new Color(0x2c2d2eff))));

            Move(x, y);

            mFilterPath = VGPath.OpenVGPath();
            VGU.vguRect(mFilterPath, mImage.ScreenPosition.X + 1, mImage.ScreenPosition.Y + 1, mImage.Width - 2, mImage.Height - 2);

            mFilterPaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mFilterPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, (new Color(0xEDAB18ff)).Value);


        }

        private IntPtr mPaint;
        private Image mImage;
        private IntPtr mFilterPath;
        private IntPtr mFilterPaint;


        public FilterInfoIcon(IWidget parent, ISignal sensor, ISignal status, int x, int y)
            : base(parent, 100, 100)
        {
            mSensor = sensor;
            mStatus = status;
            Init(x, y);
        }

        private void InitBackground()
        {
            if (mInitialized)
                return;

            const int kRound = 10;

            mPath = VGPath.OpenVGPath();
            VGU.vguRoundRect(mPath, 0, 0, Width, Height, kRound, kRound);

            mInitialized = true;
        }

        //public int Status { get; set; }


        public override void Draw()
        {
            //base.Update();

            VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
            VG.vgLoadIdentity();

            VG.vgSetPaint(mFilterPaint, VGPaintMode.VG_FILL_PATH);

            VG.vgDrawPath(mFilterPath, VGPaintMode.VG_FILL_PATH);
            VG.vgFinish();

            mImage.Update();
        }
    }
    #endregion

    #region voltage
    public class VoltageInfoIcon : Widget
    {
        private readonly ISignal mSensor;
        private static IntPtr mPath;
        private static bool mInitialized;

        private TextArea mRollArea;

        private void Init(int x, int y)
        {
            InitBackground();

            Text.Label(this, "Напряжение\\nв сети", 14, 0, 0, Width, 14);

            mPaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, (new Color(0xEDAB18ff)).Value);


            mRollArea = new TextArea(this, 0, 45, Width, 30) { Text = "" };
            mRollArea.SetAlign(Align.Center, new GfxPoint(0, 5));
            mRollArea.SetFont(Palette.White, 22);
            mRollArea.Text = string.Format("{0:0} В", mSensor.Value);

            mSensor.OnUpdate += sensor =>
                                    {
                                        mRollArea.Text = string.Format("{0:0} В", sensor.Value);
                                    };

            AddVGPath(new VGPath(mPath, null, new VGSolidColor(new Color(0x2c2d2eff))));

            Move(x, y);
        }

        private IntPtr mPaint;

        public VoltageInfoIcon(IWidget parent, ISignal sensor, int x, int y)
            : base(parent, 100, 100)
        {
            mSensor = sensor;
            Init(x, y);
        }

        private void InitBackground()
        {
            if (mInitialized)
                return;

            const int kRound = 10;

            mPath = VGPath.OpenVGPath();
            VGU.vguRoundRect(mPath, 0, 0, Width, Height, kRound, kRound);

            mInitialized = true;
        }

        //public int Voltage { get; set; }
    }
    #endregion

    #region invertor
    public class InvertorInfoIcon : Widget
    {
        //private readonly BroadcastListner mReciever;
        private static IntPtr mPath;
        private static bool mInitialized;

        private void Init(int x, int y)
        {
            InitBackground();

            mPaint = VG.vgCreatePaint();
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, (new Color(0xEDAB18ff)).Value);

            AddVGPath(new VGPath(mPath, new VGSolidColor(new Color(0xD1D3D4FF)), new VGSolidColor(new Color(0x2c2d2eff))) { StrokeWidth = 0.5f });

            var divideLines = VGPath.OpenVGPath();
            const int kBiasY = 44;
            VGU.vguLine(divideLines, 0, 3 * kBiasY, Width - 30, 3 * kBiasY);
            VGU.vguLine(divideLines, 0, 2 * kBiasY, Width - 30, 2 * kBiasY);
            VGU.vguLine(divideLines, 0, kBiasY, Width - 30, kBiasY);
            VGU.vguLine(divideLines, 0, 0, Width - 30, 0);
            var lines = new VGPath(divideLines, new VGSolidColor(new Color(0xD1D3D4FF)), null) { StrokeWidth = 0.5f };
            lines.Move(15, kBiasY);
            AddVGPath(lines);

            const int kBiasX = 47;
            const int kBiasX0 = 60;
            Text.Label(this, "T, ⁰C", 16, kBiasX0, kBiasY * 4, kBiasX, 18);
            Text.Label(this, "I, A", 16, kBiasX0 + kBiasX, kBiasY * 4, kBiasX, 18);
            Text.Label(this, "U, B", 16, kBiasX0 + 2 * kBiasX, kBiasY * 4, kBiasX, 18);
            Text.Label(this, "F, Гц", 16, kBiasX0 + 3 * kBiasX, kBiasY * 4, kBiasX, 18);
            Text.Label(this, "об/мин", 16, kBiasX0 + 4 * kBiasX, kBiasY * 4, kBiasX, 18);

            //Text.Label(this, "ПЧН #1\\nПЧН #2\\nПЧН #3\\nПЧН #4", 18, 15, 22, kBiasX0 - 15, kBiasY, Align.Left);

            mTable = new Table(this);
            mTableLine = new TableLine(kBiasY / 2);
            mTableLine.AddColumn(kBiasX0 - 15, null, Align.Center, 17, Palette.White, new GfxPoint(0, 3));
            //mTableLine.Text[0].Text = "ПЧН #4";
            mTableLine.AddColumn(kBiasX, null, Align.Center, 17, Palette.White, new GfxPoint(0, 3));
            mTableLine.AddColumn(kBiasX, null, Align.Center, 17, Palette.White, new GfxPoint(0, 3));
            mTableLine.AddColumn(kBiasX, null, Align.Center, 17, Palette.White, new GfxPoint(0, 3));
            mTableLine.AddColumn(kBiasX, null, Align.Center, 17, Palette.White, new GfxPoint(0, 3));
            mTableLine.AddColumn(kBiasX, null, Align.Center, 17, Palette.White, new GfxPoint(0, 3));

            mTableStatusLine = new TableLine(kBiasY / 2);
            mTableStatusLine.AddColumn(kBiasX0 - 15, null, Align.Center, 16, new Color(0xD1D3D4FF), new GfxPoint(0, 5));
            mTableStatusLine.Text[0].Text = "статус:";
            mTableStatusLine.AddColumn(kBiasX * 5, null, Align.Center, 17, Palette.White, new GfxPoint(0, 3));

            mTable.AddLine(mTableStatusLine);
            mTable.AddLine(mTableLine);

            mTable.AddLine(new TableLine(mTableStatusLine));
            mTable.AddLine(new TableLine(mTableLine));

            mTable.AddLine(new TableLine(mTableStatusLine));
            mTable.AddLine(new TableLine(mTableLine));

            mTable.AddLine(new TableLine(mTableStatusLine));
            mTable.AddLine(new TableLine(mTableLine));

            //mTable.SetBorder(1, Palette.Lime); // for debug
            mTable.Move(15, 0);

            mTable.GetCellById(7, 0).Text = "Uz 2";
            mTable.GetCellById(5, 0).Text = "Uz 3";
            mTable.GetCellById(3, 0).Text = "Uz 4";
            mTable.GetCellById(1, 0).Text = "Uz 5";


            #region temperature
            mReciever.GetSignal("uz.2.temperature").OnUpdate += sensor => mTable.GetCellById(7, 1).Text = string.Format("{0}", sensor.Value);
            mReciever.GetSignal("uz.3.temperature").OnUpdate += sensor =>
                                                                    {
                                                                        mTable.GetCellById(5, 1).Text = string.Format("{0}", sensor.Value);
                                                                    };
            mReciever.GetSignal("uz.4.temperature").OnUpdate += sensor => mTable.GetCellById(3, 1).Text = string.Format("{0}", sensor.Value);
            mReciever.GetSignal("uz.5.temperature").OnUpdate += sensor => mTable.GetCellById(1, 1).Text = string.Format("{0}", sensor.Value);
            mTable.GetCellById(7, 1).Text = "-";
            mTable.GetCellById(5, 1).Text = "-";
            mTable.GetCellById(3, 1).Text = "-";
            mTable.GetCellById(1, 1).Text = "-";
            #endregion

            #region current
            mReciever.GetSignal("uz.2.current").OnUpdate += sensor => mTable.GetCellById(7, 2).Text = string.Format("{0}", sensor.Value);
            mReciever.GetSignal("uz.3.current").OnUpdate += sensor => mTable.GetCellById(5, 2).Text = string.Format("{0}", sensor.Value);
            mReciever.GetSignal("uz.4.current").OnUpdate += sensor => mTable.GetCellById(3, 2).Text = string.Format("{0}", sensor.Value);
            mReciever.GetSignal("uz.5.current").OnUpdate += sensor => mTable.GetCellById(1, 2).Text = string.Format("{0}", sensor.Value);
            mTable.GetCellById(7, 2).Text = "-";
            mTable.GetCellById(5, 2).Text = "-";
            mTable.GetCellById(3, 2).Text = "-";
            mTable.GetCellById(1, 2).Text = "-";
            #endregion

            #region voltage
            mReciever.GetSignal("uz.2.voltage").OnUpdate += sensor => mTable.GetCellById(7, 3).Text = string.Format("{0}", sensor.Value);
            mReciever.GetSignal("uz.3.voltage").OnUpdate += sensor => mTable.GetCellById(5, 3).Text = string.Format("{0}", sensor.Value);
            mReciever.GetSignal("uz.4.voltage").OnUpdate += sensor => mTable.GetCellById(3, 3).Text = string.Format("{0}", sensor.Value);
            mReciever.GetSignal("uz.5.voltage").OnUpdate += sensor => mTable.GetCellById(1, 3).Text = string.Format("{0}", sensor.Value);
            mTable.GetCellById(7, 3).Text = "-";
            mTable.GetCellById(5, 3).Text = "-";
            mTable.GetCellById(3, 3).Text = "-";
            mTable.GetCellById(1, 3).Text = "-";
            #endregion

            // TODO: привязать к реальным значениям
            #region freq
            mReciever.GetSignal("uz.2.frequency").OnUpdate += sensor => mTable.GetCellById(7, 4).Text = string.Format("{0:F2}", sensor.Value / 100);
            mReciever.GetSignal("uz.3.frequency").OnUpdate += sensor => mTable.GetCellById(5, 4).Text = string.Format("{0:F2}", sensor.Value / 100);
            mReciever.GetSignal("uz.4.frequency").OnUpdate += sensor => mTable.GetCellById(3, 4).Text = string.Format("{0:F2}", sensor.Value / 100);
            mReciever.GetSignal("uz.5.frequency").OnUpdate += sensor => mTable.GetCellById(1, 4).Text = string.Format("{0:F2}", sensor.Value / 100);
            mTable.GetCellById(7, 4).Text = "-";
            mTable.GetCellById(5, 4).Text = "-";
            mTable.GetCellById(3, 4).Text = "-";
            mTable.GetCellById(1, 4).Text = "-";
            #endregion

            #region rpm - энкодера нет физически
            //mReciever.GetSignal("uz.2.speed").OnUpdate += sensor => mTable.GetCellById(7, 5).Text = string.Format("{0}", sensor.Value);
            //mReciever.GetSignal("uz.3.speed").OnUpdate += sensor => mTable.GetCellById(5, 5).Text = string.Format("{0}", sensor.Value);
            //mReciever.GetSignal("uz.4.speed").OnUpdate += sensor => mTable.GetCellById(3, 5).Text = string.Format("{0}", sensor.Value);
            //mReciever.GetSignal("uz.5.speed").OnUpdate += sensor => mTable.GetCellById(1, 5).Text = string.Format("{0}", sensor.Value);
            mTable.GetCellById(7, 5).Text = "-";
            mTable.GetCellById(5, 5).Text = "-";
            mTable.GetCellById(3, 5).Text = "-";
            mTable.GetCellById(1, 5).Text = "-";
            #endregion

            // TODO: по значению
            #region status
            /*
            mReciever.GetSignal("uz.2.error").OnUpdate += sensor => mTable.GetCellById(7, 5).Text = string.Format("0x{0:X4}", sensor.Value);
            mReciever.GetSignal("uz.3.error").OnUpdate += sensor => mTable.GetCellById(5, 5).Text = string.Format("0x{0:X4}", sensor.Value);
            mReciever.GetSignal("uz.4.error").OnUpdate += sensor => mTable.GetCellById(3, 5).Text = string.Format("0x{0:X4}", sensor.Value);
            mReciever.GetSignal("uz.5.error").OnUpdate += sensor => mTable.GetCellById(1, 5).Text = string.Format("0x{0:X4}", sensor.Value);
            */

            mReciever.GetSignal("uz.2.error").OnUpdate += sensor =>
                                                              {
                                                                  mTable.GetCellById(6, 1).SetFont(sensor.Value > 0
                                                                                                            ? Palette.Red
                                                                                                            : Palette.White);
                                                                  mTable.GetCellById(6, 1).Text = string.Format("{0}", sensor.Value);
                                                              };
            mReciever.GetSignal("uz.3.error").OnUpdate += sensor =>
                                                              {
                                                                  mTable.GetCellById(4, 1).SetFont(sensor.Value > 0
                                                                                                            ? Palette.Red
                                                                                                            : Palette.White);
                                                                  mTable.GetCellById(4, 1).Text = string.Format("{0}", sensor.Value);
                                                              };
            mReciever.GetSignal("uz.4.error").OnUpdate += sensor =>
                                                              {
                                                                  mTable.GetCellById(2, 1).SetFont(sensor.Value > 0
                                                                                                            ? Palette.Red
                                                                                                            : Palette.White);
                                                                  mTable.GetCellById(2, 1).Text = string.Format("{0}", sensor.Value);
                                                              };
            mReciever.GetSignal("uz.5.error").OnUpdate += sensor =>
                                                              {
                                                                  mTable.GetCellById(0, 1).SetFont(sensor.Value > 0
                                                                                                            ? Palette.Red
                                                                                                            : Palette.White);
                                                                  mTable.GetCellById(0, 1).Text = string.Format("{0}", sensor.Value);
                                                              };

            mTable.GetCellById(6, 1).Text = "6:1";
            mTable.GetCellById(4, 1).Text = "4:1";
            mTable.GetCellById(2, 1).Text = "2:1";
            mTable.GetCellById(0, 1).Text = "0:1";
            #endregion

            //mReciever.GetSignal("").OnUpdate += sensor => mTable.GetCellById(0, 0).Text = string.Format("{0}", sensor.Value);


            Move(x, y);
        }

        private IntPtr mPaint;
        private Table mTable;
        private TableLine mTableLine;
        private TableLine mTableStatusLine;
        private readonly BroadcastListner mReciever;

        public InvertorInfoIcon(IWidget parent, BroadcastListner reciever)
            : base(parent, 310, 200)
        {
            mReciever = reciever;
            Init(85, 60);
        }

        private void InitBackground()
        {
            if (mInitialized)
                return;

            const int kRound = 10;

            mPath = VGPath.OpenVGPath();
            VGU.vguRoundRect(mPath, 0, 0, Width, Height, kRound, kRound);

            mInitialized = true;
        }
    }

    #endregion
}