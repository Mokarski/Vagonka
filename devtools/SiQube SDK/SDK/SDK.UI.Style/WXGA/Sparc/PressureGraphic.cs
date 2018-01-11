using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WXGA.Sparc
{

    public class PressureGraphic : Widget, IGraphicArea
    {
        internal IntPtr mPath = IntPtr.Zero;
        internal IntPtr mFillPaint = IntPtr.Zero;
        internal IntPtr mStrokePaint = IntPtr.Zero;
        internal List<GraphicsData> mGrapihcs;

        private const int kHeight = 280;

        private Timer mTimer;

        public PressureGraphic(IWidget parent)
            : base(parent, 940, 330)
        {
            //mBackground = new Color(0x121212FF);

            Init();
        }

        //public static class ColorLegend
        //{
        private static readonly uint[] Colors = new uint[]
                                      {
                                          //0x8b8d8fff,
                                          0x2b6d94ff,
                                          0x2b6d94ff,
                                          0x1a7bb3ff,
                                          0x1f86a4ff,
                                          0x249093ff,
                                          0x2ba07eff,
                                          0x31ad6bff,
                                          0x39be52ff,
                                          0x3fcc3fff,
                                          0x44d72fff,
                                          0x49e023ff, // index 10 - normal
                                          0xa4e022ff,
                                          0xb8dc23ff,
                                          0xd0d725ff,
                                          0xe7d227ff,
                                          0xf2d027ff,
                                          0xf2de1eff,
                                          0xf26413ff,
                                          0xf22d08ff,
                                          0xf20000ff // index 19
                                      };

        private VisializationType mType;
        private TextArea[] mHLabels;    
        private TextArea[] mVRuntimeLabels;
        private TextArea[] mVHistoryLabels;
        private ushort mNormal;
        private bool mTimerIsDirty;


        public ushort Max { get; set; }
        public ushort Normal
        {
            get { return mNormal; }
            set
            {
                mNormal = value;

                Grid.Move(40, 20 + mNormal / 2);
            }
        }

        private uint GetColor(ushort data)
        {
            int index;
            if (data <= Normal)
            {
                index = (int)(data * (11.0f / Normal));
            }
            else
            {
                index = 11 + (int)((data - Normal) * (9.0f / (Max - Normal))); // 9 - from normal to max
            }

            if (index > Colors.Length - 1)
                index = Colors.Length - 1;

            return Colors[index];
        }
        //}

        const float kOxWidht = 875f;

        private void ProcessTimerEvent(object state)
        {
            mTimer.Change(Timeout.Infinite, Timeout.Infinite);
            Recalculate(true);
        }

        private void Init()
        {
            mTimer = new Timer(ProcessTimerEvent, null, Timeout.Infinite, Timeout.Infinite);
            
            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            mFillPaint = VG.vgCreatePaint();
            mStrokePaint = VG.vgCreatePaint();

            mGrapihcs = new List<GraphicsData>();

            var color = new VGSolidColor(new Color(0xD1D3D4FF));
            #region Lines & arrows
            {
                var path = VGPath.OpenVGPath();
                VG.vgLoadIdentity();

                const float kXBias = 3f;
                const float kYBias = 12f;

                VGU.vguLine(path, 0, 0, Width - 60, 0); // OX
                //VGU.vguLine(path, 0, 0, 0, Height - 40); // OY
                VGU.vguLine(path, 0, 0, 0, Height - kYBias - 1); // OY



                var yArroyBias = Height - kYBias - 1;
                //var yArroyBias = Height - 40f;

                var pathData = new float[16];
                pathData[0] = -kXBias;
                pathData[1] = yArroyBias; //0f;
                pathData[2] = 0f;
                pathData[3] = yArroyBias + kYBias; // kYBias;
                pathData[4] = kXBias;
                pathData[5] = yArroyBias; //0f;
                VGU.vguPolygon(path, pathData, 3, VGboolean.VG_TRUE);

                var xArroyBias = Width - 60f;
                pathData[0] = xArroyBias;
                pathData[1] = -kXBias;
                pathData[2] = xArroyBias + kYBias;
                pathData[3] = 0f;
                pathData[4] = xArroyBias;
                pathData[5] = kXBias;
                VGU.vguPolygon(path, pathData, 3, VGboolean.VG_TRUE);

                var vgPath = new VGPath(path, color, color);
                vgPath.Move(35, 15);
                Arrows = vgPath;
            }

            #endregion

            #region Grid

            {
                var path = VGPath.OpenVGPath();
                VGU.vguLine(path, 0, 0, Width - 60, 0); // OX   

                var vgPath = new VGPath(path, null, null);
                //vgPath.SetStroke(color);
                vgPath.SetStroke(color, new[] { 2.0f, 2.0f });
                vgPath.StrokeWidth = 0.5f;
                vgPath.Move(40, 20 + 180);

                Grid = vgPath;
            }

            #endregion

            #region childs
            mHLabels = new[]
                             {
                                 new TextArea(this, 15, 0, 36, 18){Text =  "1"},
                                 new TextArea(this, (int) (kOxWidht * 50/177), 0, 36, 18){Text =  "50"},
                                 new TextArea(this, (int) (kOxWidht * 100/177), 0, 36, 18){Text =  "100"},
                                 new TextArea(this, (int) (kOxWidht * 150/177), 0, 36, 18){Text =  "150"}
                             };

            var oyLabel = new TextArea(this, -10, Height, 60, 18) { Text = "P, бар" };
            mVRuntimeLabels = new[]
                             {
                                 oyLabel,
                                 new TextArea(this, -10, 10, 36, 18){Text =  "0"},

                                 new TextArea(this, -10, Height * 50/kHeight, 36, 18){Text =  "100"},
                                 new TextArea(this, -10, Height * 100/kHeight, 36, 18){Text =  "200"},
                                 new TextArea(this, -10, Height * 150/kHeight, 36, 18){Text =  "300"},
                                 new TextArea(this, -10, Height * 200/kHeight, 36, 18){Text =  "400"},
                                 new TextArea(this, -10, Height * 250/kHeight, 36, 18){Text =  "500"}

                             };


            mVHistoryLabels = new[]
                             {
                                 new TextArea(this, -15, Height * 10/kHeight, 45, 18){Text =  ""},
                                 new TextArea(this, -15, Height * 25/kHeight, 45, 18){Text =  ""},

                                 new TextArea(this, -15, Height * 60/kHeight, 45, 18){Text =  ""},
                                 new TextArea(this, -15, Height * 75/kHeight, 45, 18){Text =  ""},

                                 new TextArea(this, -15, Height * 110/kHeight, 45, 18){Text =  ""},
                                 new TextArea(this, -15, Height * 125/kHeight, 45, 18){Text =  ""},

                                 new TextArea(this, -15, Height * 160/kHeight, 45, 18){Text =  ""},
                                 new TextArea(this, -15, Height * 175/kHeight, 45, 18){Text =  ""},

                                 new TextArea(this, -15, Height * 210/kHeight, 45, 18){Text =  ""},
                                 new TextArea(this, -15, Height * 225/kHeight, 45, 18){Text =  ""}
                             };

            foreach (var label in mHLabels)
            {
                label.SetFont(new Color(0xD1D3D4FF), 20);
                label.SetAlign(Align.Right);
            }


            foreach (var label in mVRuntimeLabels)
            {
                label.SetFont(new Color(0xD1D3D4FF), 20);
                label.SetAlign(Align.Right);
            }


            foreach (var label in mVHistoryLabels)
            {
                label.SetFont(new Color(0xD1D3D4FF), 20);
                label.SetAlign(Align.Right);
                label.Hide();
            }

            //mVRuntimeLabels[mVRuntimeLabels.Length - 2].SetFont(new Color(0x5EE82CFF), 20);// "180"

            var oxLabel = new TextArea(this, Width - 20, 0, 60, 18) { Text = "N" };
            oxLabel.SetFont(new Color(0xD1D3D4FF), 20);


            oyLabel.SetFont(new Color(0xD1D3D4FF), 20);
            oyLabel.SetAlign(Align.Left, new GfxPoint(0, 5));
            #endregion

            Move(170, 310);

            //ImageCacheBorder = 50; // work

            Type = VisializationType.Realtime;
        }

        public VisializationType Type
        {
            get { return mType; }
            set
            {
                if (mType == value) return;
                mType = value;

                switch (mType)
                {
                    case VisializationType.Realtime:
                        {
                            foreach (var label in mVHistoryLabels)
                            {
                                label.Hide();
                            }

                            foreach (var label in mVRuntimeLabels)
                            {
                                label.Show();
                            }
                        }
                        break;
                    case VisializationType.History:
                        {
                            foreach (var label in mVRuntimeLabels)
                            {
                                label.Hide();
                            }

                            foreach (var label in mVHistoryLabels)
                            {
                                label.Show();
                            }
                        }
                        break;
                }

                Recalculate(false);
            }
        }

        public override void Draw()
        {
            if (!IsVisible)
                return;

            // draw bg
            if (Background != null)
            {
                VG.vgSetfv(VGParamType.VG_CLEAR_COLOR, 4, Background.Value);
                VG.vgClear(X, Y, Width, Height);
                VG.vgFinish();
            }

            if (Arrows != null)
            {
                Arrows.Update(X, Y);
            }


            VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 1.0f);
            VG.vgSetfv(VGParamType.VG_STROKE_DASH_PATTERN, 0, null);
            VG.vgSetParameterfv(mStrokePaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new Color(0x575959FF).Value);
            VG.vgSetPaint(mStrokePaint, VGPaintMode.VG_STROKE_PATH);

            switch (Type)
            {
                case VisializationType.Realtime:
                    {
                        //mApplication.DebugTimeToConsole("realtime");

                        #region Realtime
                        if (Grid != null)
                        {
                            Grid.Update(X, Y);
                        }

                        VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);


                        // draw rectangles
                        if (mGrapihcs.Count > 0)
                            lock (mGrapihcs)
                            foreach (var data in from data in mGrapihcs where data != null where data.Data != null where data.Data.Length > 0 select data)
                            {
                                VG.vgLoadIdentity();
                                VG.vgTranslate(X + data.Position.X, Y + data.Position.Y); // (40, 20)

                                var size = (data.Data.Length - 1) > (((uint)(kOxWidht)) - data.Position.X) ? (((uint)(kOxWidht)) - data.Position.X) : (data.Data.Length - 1);
                                for (var i = 0; i < size; i++)
                                {
                                    VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                                    var maxY = data.Data[i] < 5 ? 5 : data.Data[i]; // минимальное значение - 5 единиц, чтобы было видно секции    
                                    maxY = data.Data[i] == ushort.MaxValue ? 5 : maxY; // проверяем флаг на наличие датчика
                                    maxY /= 2;

                                    VGU.vguRect(mPath, i * (kOxWidht / 177f), 0, (kOxWidht / 177f), maxY);

                                    var color = (data.Data[i] == ushort.MaxValue)
                                                    ? Palette.White
                                                    : new Color(GetColor(data.Data[i]));

                                    VG.vgSetParameterfv(mFillPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, color.Value);
                                    VG.vgSetPaint(mFillPaint, VGPaintMode.VG_FILL_PATH);
                                    VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);
                                    
                                    VG.vgDrawPath(mPath, VGPaintMode.VG_STROKE_PATH);
                                }
                            }
                        #endregion
                    }
                    break;

                case VisializationType.History:
                    {
                        if (HistoryReports != null)
                            if (HistoryReports.Length > 0)
                            {
                                //Console.WriteLine("history: {0}", HistoryReports.Length);

                                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                                VG.vgLoadIdentity();
                                VG.vgTranslate(X + 40, Y + 20); // (40, 20)

                                foreach (var label in mVHistoryLabels)
                                {
                                    label.Text = "";
                                }

                                var depth = 0;
                                for (var j = 0; j < HistoryReports.Length; j++)
                                {
                                    var data = HistoryReports[j].Restore();

                                    if (j % 5 == 0)
                                    {
                                        //Console.WriteLine("history: {0}", j);
                                        var index = j/5;
                                        var date = HistoryReports[j].Time;
                                        mVHistoryLabels[2*index].Text = date.ToString("HH:mm");
                                        mVHistoryLabels[2*index + 1].Text = date.ToString("dd") + "/" + date.ToString("MM");
                                    }

                                    if (data != null)
                                    {
                                        var size = (data.Length - 1);                                                                

                                        for (var i = 0; i < size; i++)
                                        {
                                            if (data[i] == ushort.MaxValue){ continue; }

                                            VG.vgClearPath(mPath, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                                            const int kRectHeight = 12;
                                            VGU.vguRect(mPath, i * (kOxWidht / 177f), depth * kRectHeight, (kOxWidht / 177f), kRectHeight);

                                            VG.vgSetParameterfv(mFillPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new Color(GetColor(data[i])).Value);
                                            VG.vgSetPaint(mFillPaint, VGPaintMode.VG_FILL_PATH);
                                            VG.vgDrawPath(mPath, VGPaintMode.VG_FILL_PATH);

                                            VG.vgDrawPath(mPath, VGPaintMode.VG_STROKE_PATH);
                                        }
                                    }
                                    else
                                        Console.WriteLine("oooops");

                                    depth++;
                                }
                            }

                    }
                    break;
            }


            //base.Update();
        }

        public void Recalculate(bool syncro)
        {
            //mApplication.DebugTimeToConsole("recalculate");

            if(syncro)
            {
                Invalidate();
                mTimerIsDirty = false;
            }
            else
            {
                if(!mTimerIsDirty)
                {
                    mTimer.Change(500, Timeout.Infinite);
                    mTimerIsDirty = true;
                }
            }
        }

        public Report[] HistoryReports { get; set; }

        public List<GraphicsData> Grapics
        {
            get { return mGrapihcs; }
        }

        public Color Background { get; set; }
        public VGPath Grid { get; set; }
        public VGPath Arrows { get; set; }
    }

    public enum VisializationType
    {
        Realtime,
        History
    }
}