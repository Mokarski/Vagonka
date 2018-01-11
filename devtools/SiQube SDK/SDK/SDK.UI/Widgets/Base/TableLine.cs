using System.Collections.Generic;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    
    /// <summary>
    /// Вспомогательный класс логической упаковки строк для таблиц
    /// </summary>
    public class TableLine : Widget, ITableLine
    {
        private readonly List<TextArea> mCells = new List<TextArea>();

        public TableLine(TableLine duplicate, bool isFullCopy = true)
            : base(duplicate.Parent, 0, duplicate.Height)
        {
            foreach (var child in duplicate.Text)
            {
                AddColumn(child.Width, child.FontName, child.TextAlign, child.FontSize, child.FontColor, child.TextOffset);
            }

            if (!isFullCopy) return;
            FullCopy(duplicate);
        }

        private void FullCopy(TableLine duplicate)
        {
            #region full copy

            // copy text
            for (var i = 0; i < duplicate.Text.Length; i++)
            {
                mCells[i].Text = duplicate.Text[i].Text;
            }

            // copy visible
            IsVisible = duplicate.IsVisible;

            // copy position
            //X = duplicate.X;
            //Y = duplicate.Y;
            Move(duplicate.X, duplicate.Y);

            HotKeycode = duplicate.HotKeycode;
            //State = duplicate.State;
            OnHide = duplicate.OnHide;
            OnShow = duplicate.OnShow;
            OnPaint = duplicate.OnPaint;
            OnPress = duplicate.OnPress;
            OnRelease = duplicate.OnRelease;
            mName = duplicate.mName;

            #endregion
        }

        public TableLine(IWidget parent, int height)
            : base(parent, 0, height)
        {
        }

        public TableLine(int height)
            : base(null, 0, height)
        {
        }

        public void AddColumn(int width, string fontName, Align textAlign, int fontSize, Color fontColor, GfxPoint textOffset)
        {
            var cell = new TextArea(this, Width, 0, width, Height) {Name = "cell"};
            cell.SetAlign(textAlign, textOffset);
            cell.SetFont(fontName, fontColor, fontSize);
            cell.OnPress = CellPressed;
            cell.OnRelease = CellReleased;
            
            mCells.Add(cell);
            
            Resize(Width + width, Height);
        }

        private void CellReleased(IWidget caller)
        {
            if (OnRelease != null)
                OnRelease(caller);
        }

        private void CellPressed(IWidget caller)
        {
            if (OnPress != null)
                OnPress(caller);
        }

        public void AddColumn(int width)
        {
            AddColumn(width, null, Align.Left, 20, Palette.Black, new GfxPoint(1, 1));
        }

        public override bool HandleEvent(Application.EventType aType, object aData)
        {
            for (var i = 0; i < mChilds.Count; i++)
            {
                if (mChilds[i].HandleEvent(aType, aData))
                    return true;                
            }

            return false;
        }

        public TextArea[] Text { get { return mCells.ToArray(); } }
    }
}