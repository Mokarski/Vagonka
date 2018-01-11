using System;
using SDK.UI.Widgets.Base;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets
{
    public class ListWidget : Widget
    {
        public class Item
        {
            public string Column1 = "";
            public string Column2 = "";
            public object Id;
        }


        private uint mSelectedId;

        private readonly int[] mLenghtX;
        private readonly int[] mLenghtY;

        private readonly TextTable mRecords;
        private Color mCellSelectedColor;

        public Color CellSelectedColor
        {
            get { return mCellSelectedColor; }
            set { 
                    mCellSelectedColor = value;
                    for (var i = 0; i < mLenghtX.Length; i++)
                    {
                        mRecords.CellColors[i, mLenghtY.Length - mSelectedId - 1] = mCellSelectedColor;
                    }    
                }
        }

        public int Size {
            set
            {
                foreach (var cell in mRecords.Cells)
                {
                    cell.Size = value;
                }
            }
        }

        public Align Align
        {
            set
            {
                foreach (var cell in mRecords.Cells)
                {
                    cell.Align = value;
                }
            }
        }

        public ListWidget(string name, int x, int y, int[] xLenght, int[] yLenght)
            : base(null, name)
        {
            X = x;
            Y = y;
            mLenghtX = xLenght;
            mLenghtY = yLenght;

            foreach (var i in xLenght)
            {
                Width += i;
            }

            foreach (var i in yLenght)
            {
                Height += i;
            }

            mCellSelectedColor = new Color { R = 36f / 255f, B = 91f / 255f, G = 255f / 255f };

            mSelectedId = 0;
            mRecords = new TextTable("", X, Y, mLenghtX, mLenghtY, new []{4, 4}, null, 18);

            for (var i = 0; i < mLenghtX.Length; i++)
            {
                mRecords.CellColors[i, mLenghtY.Length - mSelectedId - 1] = mCellSelectedColor;
            }            
        }



        private Item[] mItems;
        private object mItemsLock = new object();

        public Item[] Items
        {
            set
            {
                lock (mItemsLock)
                {
                    mItems = value;
                    mSelectedId = 0;

                    ApplyStateChange();
                    Invalidate();
                }
            }

            get { return mItems ?? new Item[0]; }
        }

        
        private void ApplyStateChange()
        {           
            //актуализировать текст
            foreach (var cell in mRecords.Cells)
            {
                cell.Text = "";
            }

           
            lock (mItemsLock)
            {
                if (mItems.Length <= mLenghtY.Length)
                    for (var i = 0; i < mItems.Length; i++)
                    {
                        if (mItems[i] == null) continue;
                        
                        mRecords.Cells[0, i].Text = mItems[i].Column1;

                        if(mLenghtX.Length > 1)
                            mRecords.Cells[1, i].Text = mItems[i].Column2;
                    }
                else
                {
                    var startIndex = (mSelectedId / mLenghtY.Length) * mLenghtY.Length;

                    for (var i = 0; startIndex < mItems.Length && i < mLenghtY.Length; i++, startIndex++)
                    {
                        if (mItems[startIndex] == null) continue;

                        mRecords.Cells[0, i].Text = mItems[startIndex].Column1;

                        if (mLenghtX.Length > 1)
                            mRecords.Cells[1, i].Text = mItems[startIndex].Column2;
                    }
                }
            }

            
            uint colorLineId;
            if ((mSelectedId + 1) <= mLenghtY.Length)
                colorLineId = mSelectedId;
            else
                colorLineId = (uint) (mSelectedId % mLenghtY.Length);
            

            for (var i = 0; i < mLenghtY.Length; i++)
            {
                for (var j = 0; j < mLenghtX.Length; j++)
                {
                    if(i == colorLineId)
                        mRecords.CellColors[j, mLenghtY.Length - i - 1] = mCellSelectedColor;
                    else
                        mRecords.CellColors[j, mLenghtY.Length - i - 1] = mRecords.CellDefaultColor;
                }
            }

            IsPositionChanged = true;

            if (OnSelectionChanged != null)
                OnSelectionChanged();

            Invalidate();
        }   

        public void PageUp()
        {
            if (mItems != null)
                lock (mItemsLock)
                    if (mSelectedId >= mLenghtY.Length)
                    {
                        var i = ((mSelectedId - mLenghtY.Length) / mLenghtY.Length);

                        mSelectedId = (uint) (i * mLenghtY.Length);
                        ApplyStateChange();
                    }
        
        }

        public void Up()
        {
            if (mItems != null)
                lock (mItemsLock)            
                    if (mSelectedId > 0)
                    {
                        mSelectedId--;
                        ApplyStateChange();
                    }
        }

        public void PageDown()
        {
            if (mItems != null)
                lock (mItemsLock)
                    if (((mLenghtY.Length + mSelectedId) / mLenghtY.Length)*mLenghtY.Length < mItems.Length)
                    {
                        var i = ((mLenghtY.Length + mSelectedId) / mLenghtY.Length);
                        mSelectedId = (uint) (i * mLenghtY.Length);

                        ApplyStateChange();
                    }
        }


        public void Down()
        {
            if (mItems != null)
                lock (mItemsLock)
                    if ((mSelectedId + 1) < mItems.Length)
                    {
                        mSelectedId++;
                        ApplyStateChange();
                    }
        }

        private void SelectItemByMousePosition(int y)
        {
            var upperLine = Y + Height;
            var downLine = upperLine;

            for (var i = 0; i < mLenghtY.Length; i++)
            {
                downLine -= mLenghtY[mLenghtY.Length - 1 - i];
                if (y >= downLine && y <= upperLine)
                {
                    var startIndex = (mSelectedId / mLenghtY.Length) * mLenghtY.Length;

                    if(mSelectedId != (uint) (startIndex + i))
                    {
                        mSelectedId = (uint)(startIndex + i);
                        ApplyStateChange(); 
                    }
                }
                upperLine -= mLenghtY[mLenghtY.Length - 1 - i];

            }
        }

        public override bool HandleEvent(Application.EventType aType, object aData)
        {
            var mouseData = (MouseData)aData;

            //Console.WriteLine("{0},{1}", mouseData.X, mouseData.Y);
            switch (aType)
            {
                case Application.EventType.MouseDown:
                    {
                        if (State != ButtonState.Pressed)
                        {
                            if ((mouseData.X >= X && mouseData.X <= X + Width) && (mouseData.Y >= Y && mouseData.Y <= Y + Height))
                            {
                                // меняем внутреннее состояние
                                State = ButtonState.Pressed;

                                SelectItemByMousePosition(mouseData.Y);

                                // оповещаем всех о смене состояния
                                if (OnPress != null)
                                    OnPress();

                                // перерисовываем в ApplyStateChange
                            }
                        }
                    }
                    return true;

                case Application.EventType.MouseUp:
                    {
                        if (State == ButtonState.Pressed)
                        {
                            State = ButtonState.Released;

                            // оповещаем всех о смене состояния
                            if (OnRelease != null)
                                OnRelease();

                            // перерисовываем в ApplyStateChange
                        }
                    }
                    return true;
            }

            return false;
        }

        public uint CurrentId
        {
            get { return mSelectedId; }
        }

        public object CurrentSelection
        {
            get
            {
                try
                {
                    if (mItems != null)
                        return mItems[mSelectedId].Id;
                }
                catch (IndexOutOfRangeException)
                {
                    return null;
                }
                catch (ArgumentOutOfRangeException)
                {
                    return null;
                }
                
                return null;
            }
        }

        public bool IsPositionChanged { get; private set; }

        public Action OnSelectionChanged;

        public override void Update()
        {           
            mRecords.Update();

            if (IsPositionChanged)
                IsPositionChanged = false;

        }

        public override void Dispose()
        {
            mRecords.Dispose();
        }
    }
}