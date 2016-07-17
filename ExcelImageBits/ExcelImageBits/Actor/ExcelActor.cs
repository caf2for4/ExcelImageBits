using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Drawing;

namespace ExcelImageBits.Actor
{
    class ExcelActor
    {
        static public Size RangeSize { get; private set; }

        static public Excel.Worksheet Sheet
        {
            get
            {
                return (Excel.Worksheet)Globals.ThisAddIn.Application.ActiveSheet;
            }
        }

        static public void setExcelBits(Size size)
        {
            RangeSize = size;

            Excel.Range range = Sheet.Range[Sheet.Cells[1, 1], Sheet.Cells[RangeSize.Width, RangeSize.Height]];
            range.ColumnWidth = Settings.BaseWidth;
            range.RowHeight = Settings.BaseHeight;
        }

        static public void setExcelBitsColor(int x, int y, Color color)
        {
            Excel.Range range = (Excel.Range)Sheet.Cells[x + 1, y + 1];
            range.Interior.Color = ColorTranslator.ToOle(color);
        }


    }
}
