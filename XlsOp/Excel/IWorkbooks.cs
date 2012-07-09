using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.Excel
{
    public interface IWorkbooks : IComObject, IEnumerable<IWorkbook>
    {
        IWorkbook Open(string path);
        IWorkbook Add();
    }
}
