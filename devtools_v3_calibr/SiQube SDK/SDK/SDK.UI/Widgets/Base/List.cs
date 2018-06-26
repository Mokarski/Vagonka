using System;
using System.Collections.Generic;
using System.Linq;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class List : Table
    {
        private readonly int mCountOfVisibleLines;
        private List<string[]> mData;

        private int mDataIndex;

        public List(IWidget parent, int countLines, int x, int y, int firstWidth = 200)
            : base(parent)
        {
            mCountOfVisibleLines = countLines;

            var line = new TableLine(this, 22);

            Resize(320, 0);
            //Width = 320;

            line.AddColumn(firstWidth, null, Align.Left, 21, Palette.White, new GfxPoint(4, 4));
            line.AddColumn(Width - firstWidth, null, Align.Left, 21, Palette.White, new GfxPoint(4, 4));
            SetBackground(Palette.LightSkyBlue, new Color(0x121212FF));//Palette.TextArea.Background);
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

        protected override void Draw()
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
}