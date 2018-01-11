using SDK.UI.Widgets.Base;

namespace SDK.UI.Widgets.Interfaces
{
    public interface ITableLine : IWidget
    {
        void AddColumn(int width);
        void AddColumn(int width, string fontName, Align textAlign, int fontSize, Color fontColor, GfxPoint textOffset);
        TextArea[] Text { get; }
    }
    
    public interface ITable : IWidget
    {
        void AddLine(ITableLine line);

        void SetBackground(Color active, Color nornal);
        void SetBorder(int width, Color color);
        
        ITableLine GetLineByCell(IWidget caller);
        
        int GetLineId(ITableLine line);

        /// <summary>
        /// Получить линию таблицы по ее номеру (перечисление)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ITableLine GetLineById(int id);
        
        /// <summary>
        /// Получить ячейку по номерам строки и столбца
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="columnId"></param>
        /// <returns></returns>
        TextArea GetCellById(int rowId, int columnId);

        ITableLine ActiveLine { get; set; }
        ITextArea ActiveCell { get; set; }
    }
}