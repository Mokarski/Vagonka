using System.Text;
using SDK.UI.Widgets.Base;

namespace SDK.UI.Widgets
{
    public class TextTable : Widget
    {
        private int mX;
        private int mY;
        private int[] mLenghtX;
        private int[] mLenghtY;

        private readonly Color mFontColor;
        private readonly int[] mTextOffset;

        public Color CellDefaultColor { get; set; }

        public static int[] CreateOffset(int i, int size)
        {
            var rv = new int[i];
            for (var j = 0; j < rv.Length; j++)
            {
                rv[j] = size;
            }

            return rv;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aName">Имя</param>
        /// <param name="xPos">Позиция по ОХ</param>
        /// <param name="yPos">Позиция по OY</param>
        /// <param name="xLenght">Длинны столбцов</param>
        /// <param name="yLenght">Высоты строк</param>
        /// <param name="textOffset"> </param>
        /// <param name="color">Цвет шрифта по умолчанию в ячейках</param>
        /// <param name="size">Размер шрифта по умолчанию в ячейках</param>
        public TextTable(string aName, int xPos, int yPos, int[] xLenght, int[] yLenght, int[] textOffset, Color color, int size)
            : base(null, aName)
        {
            Border = true;
            CellBorder = true;
            CellFill = true;
            mFontColor = color ?? new Color();

            if (textOffset != null)
                if(textOffset.Length == 2)
                    mTextOffset = textOffset;

            if (mTextOffset == null)
                mTextOffset = new[]{2, 2};
            
            const float kGreyColor = 252f / 256f;
            CellDefaultColor = new Color { R = kGreyColor, G = kGreyColor, B = kGreyColor };
            Init(xPos, yPos, xLenght, yLenght, size != 0 ? size : 16);
        }

        public TextArea[,] Cells { get; private set; }
        public bool CellBorder { get; set; }
        public bool Border { get; set; }
        public bool CellFill { get; set; }
        public Color[,] CellColors { get; set; }
 


        private static int GetLenght(int pos, int[] lenght)
        {
            var rv = 0;
            for (var i = 0; i < pos; i++)
            {
                rv += lenght[i];
            }

            return rv;
        }

        private void Init(int xPos, int yPos, int[] xLenght, int[] yLenght, int size)
        {

            mX = xPos;
            mY = yPos;
            mLenghtX = xLenght;
            mLenghtY = yLenght;

            Cells = new TextArea[xLenght.Length, yLenght.Length];
            CellColors = new Color[xLenght.Length, yLenght.Length];

            for (var i = 0; i < xLenght.Length; i++) // столбцы
            {
                for (var j = 0; j < yLenght.Length; j++) // строки
                {
                    var name = Encoding.ASCII.GetString(new[] { (byte)(65 + i) });

                    var tdName = name + (j + 1);
                    var tdX = xPos + mTextOffset[0] + GetLenght(i, xLenght);
                    var tdY = yPos + mTextOffset[1] + GetLenght(yLenght.Length - j - 1, mLenghtY);
                    var tdLenght = xLenght[i] - mTextOffset[0];
                   
                    //var table = new TextArea(tdName, null, tdX, tdY, tdLenght) { Size = mFontSize, FontColor = mFontColor };

                    // TODO: debug only
                    var table = new TextArea(this, tdName, null, tdX, tdY, tdLenght, yLenght[i]) { Text = tdName, Size = size, FontColor = mFontColor };
                    AddChild(table);
                    Cells[i, j] = table;
                    CellColors[i, j] = CellDefaultColor;
                }

            }
        }

        public override void Update()
        {
            // render table
            {
                VG.vgSeti(VGParamType.VG_BLEND_MODE, (int) VGBlendMode.VG_BLEND_SRC_OVER);
                VG.vgSeti(VGParamType.VG_FILL_RULE, (int) VGFillRule.VG_NON_ZERO);
                VG.vgSetfv(VGParamType.VG_STROKE_DASH_PATTERN, 0, null);

                // create some paths
                var path0 = VG.vgCreatePath(0, VGPathDatatype.VG_PATH_DATATYPE_F, 1.0f, 0.0f, 0, 0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                // create and set a paint for fill
                var fillPaint = VG.vgCreatePaint();              
                var strokePaint = VG.vgCreatePaint();               

                // set model view matrix
                VG.vgSeti(VGParamType.VG_MATRIX_MODE, (int) VGMatrixMode.VG_MATRIX_PATH_USER_TO_SURFACE);
                VG.vgLoadIdentity();

                #region draw border
                if(Border)
                {
                    VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 5.0f);
                    VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                    VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);

                    VG.vgSetParameteri(strokePaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
                    const float kGreyColor = 192f / 256f;
                    VG.vgSetParameterfv(strokePaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { kGreyColor, kGreyColor, kGreyColor, 1.0f });
                    VG.vgSetPaint(strokePaint, VGPaintMode.VG_STROKE_PATH);

                    var tableLenght = 0;
                    for (var i = 0; i < mLenghtX.Length; i++)
                        tableLenght += mLenghtX[i];


                    VGU.vguRect(path0, (mX - 2.5f), (mY - 2.5f), tableLenght + 5, GetLenght(mLenghtY.Length, mLenghtY) + 5.0f);
                    VG.vgDrawPath(path0, VGPaintMode.VG_STROKE_PATH);
                }
                #endregion

                #region fill cells
                if (CellFill)
                {
                    for (var i = 0; i < mLenghtX.Length; i++)
                        for (var j = 0; j < mLenghtY.Length; j++)
                        {
                            VG.vgSetParameteri(fillPaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
                            VG.vgSetParameterfv(fillPaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, CellColors[i, j].Value);
                            VG.vgSetPaint(fillPaint, VGPaintMode.VG_FILL_PATH);
                            
                            VG.vgClearPath(path0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);
                            VGU.vguRect(path0, mX + GetLenght(i, mLenghtX), mY + GetLenght(j, mLenghtY), mLenghtX[i], mLenghtY[j]);
                            VG.vgDrawPath(path0, VGPaintMode.VG_FILL_PATH);
                        }
                }
                #endregion

                #region draw cells borders
                if (CellBorder)
                {
                    VG.vgSetParameteri(strokePaint, (int)VGPaintParamType.VG_PAINT_TYPE, (int)VGPaintType.VG_PAINT_TYPE_COLOR);
                    VG.vgSetParameterfv(strokePaint, (int)VGPaintParamType.VG_PAINT_COLOR, 4, new[] { 0.0f, 0.0f, 0.0f, 1.0f });
                    VG.vgSetPaint(strokePaint, VGPaintMode.VG_STROKE_PATH);

                    VG.vgClearPath(path0, VGPathCapabilities.VG_PATH_CAPABILITY_ALL);

                    VG.vgSetf(VGParamType.VG_STROKE_LINE_WIDTH, 1.0f);
                    VG.vgSeti(VGParamType.VG_STROKE_CAP_STYLE, (int)VGCapStyle.VG_CAP_BUTT);
                    VG.vgSeti(VGParamType.VG_STROKE_JOIN_STYLE, (int)VGJoinStyle.VG_JOIN_BEVEL);


                    for (var i = 0; i < mLenghtX.Length; i++)
                        for (var j = 0; j < mLenghtY.Length; j++)
                            VGU.vguRect(path0, mX + GetLenght(i, mLenghtX), mY + GetLenght(j, mLenghtY), mLenghtX[i], mLenghtY[j]);

                    VG.vgDrawPath(path0, VGPaintMode.VG_STROKE_PATH);
                }
                #endregion

                VG.vgDestroyPath(path0);
                VG.vgDestroyPaint(strokePaint);
            }

            base.Update();
        }

        public override bool HandleEvent(Application.EventType aType, object aData)
        {
            for (var i = 0; i < mChilds.Count; i++)
                mChilds[i].HandleEvent(aType, aData);

            return true;
        }

        public override void Dispose()
        {
            foreach (var widget in mChilds)
                widget.Dispose();
        }
    }
}