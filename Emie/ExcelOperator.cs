using System;
using System.Collections.Generic;
using System.Text;
using Excel = XlsOp.Excel;
using VB = XlsOp.VBIDE;

namespace Emie
{
    internal class ExcelOperator
    {
        private List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void invoke(string excelFilePath, bool saveAfterProcessing)
        {
            try {
                using (Excel.IApplication app = Excel.COM.Application.newInstance())
                using (Excel.IWorkbooks workbooks = app.Workbooks)
                using (Excel.IWorkbook workbook = workbooks.Open(excelFilePath)) {
                    foreach (ICommand command in commands) {
                        command.invoke(workbook);
                    }
                    if (saveAfterProcessing)
                        workbook.Save();
                    app.Quit();
                }
            }
            catch (Exception e) {
            }
        }
    }
}
