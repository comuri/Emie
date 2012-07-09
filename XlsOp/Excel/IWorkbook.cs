using System;
using System.Collections.Generic;
using XlsOp.VBIDE;

namespace XlsOp.Excel
{
    public interface IWorkbook : IComObject
    {
        IVBProject VBProject { get; }
        //IWorksheet ActiveSheet { get; }
        void Save();
        void Close();
    }
}
