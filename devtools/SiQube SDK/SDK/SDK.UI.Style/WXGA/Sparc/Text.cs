using System;
using System.Collections.Generic;
using System.Linq;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Style.WXGA.Sparc
{
    #region отсмотреть
    /*
    public class List : Table
    {
        private readonly int mCountOfVisibleLines;
        private List<string[]> mData;

        private int mDataIndex;

        public List(IWidget parent, int countLines, int x, int y, int firstWidth = 200) : base(parent)
        {
            mCountOfVisibleLines = countLines;

            var line = new TableLine(this, 22);

            Width = 320;

            line.AddColumn(firstWidth, null, Align.Left, 21, Palette.Black, new GfxPoint(4, 4));
            line.AddColumn(Width - firstWidth, null, Align.Left, 21, Palette.Black, new GfxPoint(4, 4));
            SetBackground(Palette.LightSkyBlue, Palette.TextArea.Background);
            SetBorder(1, Palette.DarkGray);

            AddLine(line);
            for (var i = 0; i < countLines - 1; i++)
            {
                AddLine(new TableLine(line));
            }

            base.Move(x, y);

            OnIndexChange += s =>
                                 {
                                     ActiveLine = GetLineById(mCountOfVisibleLines - (mDataIndex % mCountOfVisibleLines) - 1); 
                                 };

            Init();
        }

        public Action<string> OnIndexChange;

        public string[] GetColumn(int id)
        {
            var rv = mData.Select(data => data[id]).ToList();
            return rv.ToArray();
        }

        public string[] CurrentSelection()
        {
            return mData[mDataIndex];
        }


        private void Init()
        {
            OnPress += caller =>
                           {
                               var line = GetLineByCell(caller);

                               if (line == ActiveLine)
                               {
                                   if (OnDoublePress != null)
                                       OnDoublePress(this);
                               }

                               ActiveLine = line;

                               mDataIndex = (mDataIndex / mCountOfVisibleLines) * mCountOfVisibleLines + (mCountOfVisibleLines - GetLineId(ActiveLine) - 1);
                               OnIndexChange(GetInfo());
                           };

            //OnPaint += caller => ActiveLine = GetLineById(mDataIndex);

            mData = new List<string[]>();
        }

        private string GetInfo()
        {
            var rv = (mData.Count > mDataIndex ? (mDataIndex + 1) : mData.Count).ToString("") + " / " + mData.Count.ToString("");
            return rv;
        }

        public ButtonEvent OnDoublePress { get; set; }

        public bool Add(string[] data)
        {
            if (data != null)
            {
                mData.Add(data);

                OnIndexChange(GetInfo());
                return true;
            }

            return false;
        }

        public void DeleteAll()
        {
            mData.Clear();
        }

        public bool DeleteActive()
        {
            if(mDataIndex < mData.Count)
            {
                mData.RemoveAt(mDataIndex);
                mDataIndex--;

                if (mDataIndex < 0)
                    mDataIndex = 0;

                if (mData.Count > 0)
                    ActiveLine = GetLineById(mDataIndex % mCountOfVisibleLines);

                OnIndexChange(GetInfo());

                return true;
            }

            return false;
        }


        public bool Up()
        {
            if (mDataIndex > 0)
            {
                mDataIndex--;

                OnIndexChange(GetInfo());
                return true;
            }

            return false;
        }

        public bool Down()
        {
            if (mDataIndex < mData.Count - 1)
            {
                mDataIndex++;

                OnIndexChange(GetInfo());
                return true;
            }

            return false;
        }

        public bool PageUp()
        {
            if (mDataIndex - mCountOfVisibleLines > 0)
                mDataIndex -= mCountOfVisibleLines;
            else
                mDataIndex = 0;

            OnIndexChange(GetInfo());

            return true;
        }

        public bool PageDown()
        {
            if (mDataIndex + mCountOfVisibleLines < mData.Count - 1)
                mDataIndex += mCountOfVisibleLines;
            else
            {
                var tmp = mDataIndex;
                if(mData.Count > mDataIndex)
                    mDataIndex = ((mData.Count - 1) / mCountOfVisibleLines) * mCountOfVisibleLines;

                if (mDataIndex == 0)
                    mDataIndex = tmp;
            }

            OnIndexChange(GetInfo());

            return true;
        }

        public override void Update()
        {
            var dataBias = (mDataIndex / mCountOfVisibleLines) * mCountOfVisibleLines;
            for (var i = 0; i < mCountOfVisibleLines; i++)
            {
                var line = GetLineById(mCountOfVisibleLines - i - 1);
                foreach (var t in line.Text)
                {
                    t.Text = "";
                }
            }

            if (mData.Count > 0)
            {
                //if (ActiveLine == null)
                //    ActiveLine = GetLineById(mDataIndex / mCountOfVisibleLines);
                
                for (var i = 0; i < mCountOfVisibleLines; i++)
                {
                    var line = GetLineById(mCountOfVisibleLines - i - 1);
                    for (var j = 0; j < line.Text.Length; j++)
                    {

                        if ((dataBias + i) < mData.Count)
                        {
                            if (mData[dataBias + i].Length >= j)
                                line.Text[j].Text = mData[dataBias + i][j];
                        }
                        else
                            line.Text[j].Text = "";
                    }
                }
            }


            base.Update();
        }

    }
    */
    #endregion

    public class List : Table
    {
        private readonly int mCountOfVisibleLines;
        private List<string[]> mData;

        private int mDataIndex;

        public List(IWidget parent, int countLines, int x, int y, int firstWidth = 200)
            : base(parent)
        {
            mCountOfVisibleLines = countLines;

            var line = new TableLine(this, 53);

            Resize(800, 0);
            //Width = 800;

            line.AddColumn(firstWidth, null, Align.Left, 35, Palette.Black, new GfxPoint(4, 4));
            line.AddColumn(Width - firstWidth, null, Align.Left, 35, Palette.Black, new GfxPoint(4, 4));
            //SetBackground(Palette.LightSkyBlue, Palette.TextArea.Background);
            SetBackground(Palette.LightBlue, Palette.TextArea.Background);
            SetBorder(1, Palette.DarkGray);

            AddLine(line);
            for (var i = 0; i < countLines - 1; i++)
            {
                AddLine(new TableLine(line));
            }

            base.Move(x, y);

            OnIndexChange += s =>
            {
                ActiveLine = GetLineById(mCountOfVisibleLines - (mDataIndex % mCountOfVisibleLines) - 1);
            };

            Init();
        }

        public Action<string> OnIndexChange;

        public string[] GetColumn(int id)
        {
            var rv = mData.Select(data => data[id]).ToList();
            return rv.ToArray();
        }

        public string[] CurrentSelection()
        {
            return mData[mDataIndex];
        }


        private void Init()
        {
            OnPress += caller =>
            {
                var line = GetLineByCell(caller);

                if (line == ActiveLine)
                {
                    if (OnDoublePress != null)
                        OnDoublePress(this);
                }

                ActiveLine = line;

                mDataIndex = (mDataIndex / mCountOfVisibleLines) * mCountOfVisibleLines + (mCountOfVisibleLines - GetLineId(ActiveLine) - 1);
                OnIndexChange(GetInfo());
            };

            //OnPaint += caller => ActiveLine = GetLineById(mDataIndex);

            mData = new List<string[]>();
        }

        private string GetInfo()
        {
            var rv = (mData.Count > mDataIndex ? (mDataIndex + 1) : mData.Count).ToString("") + " / " + mData.Count.ToString("");
            return rv;
        }

        public ButtonEvent OnDoublePress { get; set; }

        public bool Add(string[] data)
        {
            if (data != null)
            {
                mData.Add(data);

                OnIndexChange(GetInfo());
                return true;
            }

            return false;
        }

        public void DeleteAll()
        {
            mData.Clear();
        }

        public bool DeleteActive()
        {
            if (mDataIndex < mData.Count)
            {
                mData.RemoveAt(mDataIndex);
                mDataIndex--;

                if (mDataIndex < 0)
                    mDataIndex = 0;

                if (mData.Count > 0)
                    ActiveLine = GetLineById(mDataIndex % mCountOfVisibleLines);

                OnIndexChange(GetInfo());

                return true;
            }

            return false;
        }


        public bool Up()
        {
            if (mDataIndex > 0)
            {
                mDataIndex--;

                OnIndexChange(GetInfo());
                return true;
            }

            return false;
        }

        public bool Down()
        {
            if (mDataIndex < mData.Count - 1)
            {
                mDataIndex++;

                OnIndexChange(GetInfo());
                return true;
            }

            return false;
        }

        public bool PageUp()
        {
            if (mDataIndex - mCountOfVisibleLines > 0)
                mDataIndex -= mCountOfVisibleLines;
            else
                mDataIndex = 0;

            OnIndexChange(GetInfo());

            return true;
        }

        public bool PageDown()
        {
            if (mDataIndex + mCountOfVisibleLines < mData.Count - 1)
                mDataIndex += mCountOfVisibleLines;
            else
            {
                var tmp = mDataIndex;
                if (mData.Count > mDataIndex)
                    mDataIndex = ((mData.Count - 1) / mCountOfVisibleLines) * mCountOfVisibleLines;

                if (mDataIndex == 0)
                    mDataIndex = tmp;
            }

            OnIndexChange(GetInfo());

            return true;
        }

        public override void Draw()
        {
            var dataBias = (mDataIndex / mCountOfVisibleLines) * mCountOfVisibleLines;
            for (var i = 0; i < mCountOfVisibleLines; i++)
            {
                var line = GetLineById(mCountOfVisibleLines - i - 1);
                foreach (var t in line.Text)
                {
                    t.Text = "";
                }
            }

            if (mData.Count > 0)
            {
                //if (ActiveLine == null)
                //    ActiveLine = GetLineById(mDataIndex / mCountOfVisibleLines);

                for (var i = 0; i < mCountOfVisibleLines; i++)
                {
                    var line = GetLineById(mCountOfVisibleLines - i - 1);
                    for (var j = 0; j < line.Text.Length; j++)
                    {

                        if ((dataBias + i) < mData.Count)
                        {
                            if (mData[dataBias + i].Length >= j)
                                line.Text[j].Text = mData[dataBias + i][j];
                        }
                        else
                            line.Text[j].Text = "";
                    }
                }
            }


            //base.Update();
        }

    }

    public static class Text
    {
        public static TableLine InputArea(IWidget parent, string label, int x, int y, int width = 440, int height = 30)
        {
            var rv = new TableLine(parent, height);
            rv.AddColumn(width, null, Align.Left, 20, Palette.Black, new GfxPoint(5, 5));

            var outline = VGPath.OpenVGPath();
            VGU.vguRoundRect(outline, 0, 0, width, height, 5, 5);

            rv.AddVGPath(new VGPath(outline, new VGSolidColor(Palette.LightGrey), new VGSolidColor(Palette.TextArea.Background)));
            rv.Move(x, y);

            var hitLabel = new TextArea(rv, 0, 0, rv.Width, rv.Height);
            hitLabel.SetAlign(Align.Left, new GfxPoint(5, 5));
            hitLabel.SetFont(Palette.DarkSlateGray, 20);
            hitLabel.Text = label;

            rv.OnPaint += caller =>
                              {
                                  if (string.IsNullOrEmpty(rv.Text[0].Text))
                                      hitLabel.Show();
                                  else
                                      hitLabel.Hide();
                              };


            return rv;
        }

        public static TableLine DateTime(IWidget parent, int x, int y)
        {
            const int kHeight = 30;

            var rv = new TableLine(parent, kHeight);
            rv.AddColumn(25, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // hour
            rv.AddColumn(10, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // :
            rv.AddColumn(25, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // minute
            rv.AddColumn(0, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // :
            rv.AddColumn(0, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // seconds
            rv.AddColumn(15, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // " - "

            rv.AddColumn(25, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // day
            rv.AddColumn(10, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // "/"
            rv.AddColumn(25, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // month
            rv.AddColumn(10, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // "/"
            rv.AddColumn(55, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // year

            //rv.AddColumn(30, null, Align.Center, 20, Palette.Black, new GfxPoint(5, 5)); // seconds

            var outline = VGPath.OpenVGPath();
            VGU.vguRoundRect(outline, 0, 0, rv.Width, kHeight, 5, 5);

            rv.AddVGPath(new VGPath(outline, new VGSolidColor(Palette.LightGrey), new VGSolidColor(Palette.TextArea.Background)));
            rv.Move(x, y);

            foreach (var label in rv.Text)
            {
                label.SetFont(Palette.Black, 25);
                label.SetAlign(Align.Center);
            }

            //rv.OnShow += caller =>
                              {
                                  rv.Text[0].Text = "09"; 
                                  rv.Text[1].Text = ":";
                                  rv.Text[2].Text = "00";
                                  rv.Text[3].Text = ":";
                                  rv.Text[4].Text = "00";
                                  rv.Text[5].Text = " - ";


                                  rv.Text[6].Text = "01";
                                  rv.Text[7].Text = "/";
                                  rv.Text[8].Text = "03";
                                  rv.Text[9].Text = "/";
                                  rv.Text[10].Text = "2014";
                                  //rv.Text[0].Text = ":";
                                  //rv.Text[0].Text = "14";

                              }



            rv.OnPress += caller =>
                              {
                                  var cell = caller as TextArea;
                                  if (cell != null)
                                      cell.SetFont(Palette.Red);
                              };

            return rv;
        }

        public static TextArea[] Label(IWidget parent, string text, int size, int x, int y, int width = 1280, int lineHeight = 30, Align align = Align.Center, Color color = null)
        {
            var lines = text.Split(new[] { "\\r", "\\n" }, StringSplitOptions.RemoveEmptyEntries);

            var rv = new List<TextArea>();
            for (var i = 0; i < lines.Length; i++)
            {
                var line = new TextArea(parent, x, y + lineHeight * i, width, lineHeight) { Text = lines[lines.Length - i - 1] };
                line.SetAlign(align, new GfxPoint(0, 5));
                line.SetFont(color ?? Palette.White, size); // new Color(0xD1D3D4FF)

                rv.Add(line);
            }

            return rv.ToArray();
        }

        public static TextArea Clock(IWidget parent)
        {
            var rv = new TextArea(parent, Application.Screen.Width - 100, Application.Screen.Height - 45, 80, 35) { Text = System.DateTime.Now.ToString("HH:mm") };
            rv.SetAlign(Align.Left);
            rv.SetFont(new Color(0xD1D3D4FF), 35);

            return rv;
        }


        public static Table ReportTable(IWidget parent, int countLines, int x, int y, int firstWidth = 200)
        {
            var rv = new Table(parent);
            var line = new TableLine(rv, 22);

            const int kWidth = 320;

            line.AddColumn(firstWidth, null, Align.Left, 21, Palette.Black, new GfxPoint(4, 4));
            line.AddColumn(kWidth - firstWidth, null, Align.Left, 21, Palette.Black, new GfxPoint(4, 4));
            rv.SetBackground(null, Palette.TextArea.Background);
            rv.SetBorder(1, Palette.DarkGray);



            rv.AddLine(line);
            for (var i = 0; i < countLines - 1; i++)
            {
                rv.AddLine(new TableLine(line));
            }

            rv.Move(x, y);


            return rv;
        }



    }
}
