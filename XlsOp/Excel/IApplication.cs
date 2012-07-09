using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.Excel
{
    public interface IApplication : IComObject
    {
        IWorkbooks Workbooks { get; }
        bool Visible { get; set; }
        void Quit();
    }
}
