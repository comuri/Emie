
using Excel = XlsOp.Excel;
using VB = XlsOp.VBIDE;

namespace Emie
{
    internal interface ICommand
    {
        void invoke(Excel.IWorkbook workbook);
    }
}
