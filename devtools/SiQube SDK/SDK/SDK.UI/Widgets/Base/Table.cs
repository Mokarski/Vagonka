using System;
using System.Collections.Generic;
using System.Linq;
using SDK.UI.Widgets.Interfaces;

namespace SDK.UI.Widgets.Base
{
    public class Table : Widget, ITable
    {
        private readonly List<ITableLine> mLines = new List<ITableLine>();
        private int mBorderWidth;
        private Color mActiveLineColor;
        private Color mNormaLineColor;
        private readonly IntPtr mPath;
        private readonly IntPtr mPaint;
        private static int mId;

        public Table(IWidget parent) : base(parent)
        {
            mPath = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_S_16, 1, 0, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
            mPaint = VG.vgCreatePaint();

            Name = string.Format("table{0}", mId++);
        }

        public void AddLine(ITableLine line)
        {
            line.Parent = this;
            line.Move(0, Height);
    
            // берем макимальную ширину и добавляем высоту строки
            Resize(Width > line.Width ? Width : line.Width, Height + line.Height);

            line.OnPress = CellPressed;
            line.OnRelease = CellReleased;

            mLines.Add(line);

            for (var i = 0; i < mLines.Count; i++)
                mLines[i].Name = (mLines.Count - i).ToString("");

            // add new borders to mPath
            foreach (var cell in line.Text)
            {
                VGU.vguRect(mPath, cell.X, line.Y, cell.Width, cell.Height);
            }
        }

        private void CellReleased(IWidget caller)
        {
            if (OnRelease != null)
                OnRelease(caller);

            Invalidate();
        }

        private void CellPressed(IWidget caller)
        {
            if (OnPress != null)
                OnPress(caller);

            Invalidate();
        }

        public void SetBackground(Color active, Color nornal)
        {
            mActiveLineColor = active;
            mNormaLineColor = nornal;

            Invalidate();
        }

        public void SetBorder(int width, Color color)
        {
            mBorderWidth = width;

            VG.vgSetParameteri(mPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
            VG.vgSetParameterfv(mPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, color == null ? Palette.Black.Value : color.Value);

            Invalidate();
        }

        public override bool HandleEvent(Application.EventType aType, object aData)
        {
            
            for (var i = 0; i < mChilds.Count; i++)
            {
                if(mChilds[i].HandleEvent(aType, aData))
                    return true;
            }

            return false;
        }

        protected override void Draw()
        {
            if (!IsVisible)
                return;

            if (OnPaint != null)
                OnPaint(this);

            //var position = ScreenPosition;

            #region fill default background
            if (mNormaLineColor != null)
            {
                VG.vgSetfv(VGParamType.VG_CLEAR_COLOR, 4, mNormaLineColor.Value);
                VG.vgClear(0, 0, Width, Height);

                VG.vgFinish();
            }
            #endregion

            #region fill active cells
            if (mActiveLineColor != null)
            {
                VG.vgSetfv(VGParamType.VG_CLEAR_COLOR, 4, mActiveLineColor.Value);
                if(ActiveLine != null)
                    VG.vgClear(ActiveLine.X, ActiveLine.Y, ActiveLine.Width, ActiveLine.Height);
                else if (ActiveCell != null)
                    VG.vgClear(ActiveCell.X, ActiveCell.Y, ActiveCell.Width, ActiveCell.Height);

                VG.vgFinish();
            }
            #endregion

            VG.vgFinish();

            #region draw grid

            if (mBorderWidth != 0)
            {
                VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, mBorderWidth);
                VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int)VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                VG.vgLoadIdentity();
                //VG.vgTranslate(position.X, position.Y);
                VG.vgSetPaint(mPaint, VGPaintMode.VG_STROKE_PATH);
                VG.vgDrawPath(mPath, VGPaintMode.VG_STROKE_PATH);
                VG.vgFinish();
            }

            #endregion
            VG.vgFinish();
        }

        public ITableLine GetLineByCell(IWidget caller)
        {
            return mLines.FirstOrDefault(line => line.Text.Any(cell => cell == caller));
        }

        public ITableLine GetLineById (int id)
        {
            return id < mLines.Count ? mLines[id] : null;
        }

        public TextArea GetCellById(int rowId, int columnId )
        {
            TextArea rv = null;
            
            var line =  rowId < mLines.Count ? mLines[rowId] : null;
            if(line != null)
                rv = columnId < line.Text.Length ? line.Text[columnId] : null;

            return rv;
        }

        public int GetLineId(ITableLine line)
        {
            if (line == null)
                return -1;

            for (var i = 0; i < mLines.Count; i++)
            {
                if (mLines[i] == line)
                    return i;
            }

            return -1;
        }

        public ITableLine ActiveLine { get; set; }
        public ITextArea ActiveCell { get; set; }
    }
}