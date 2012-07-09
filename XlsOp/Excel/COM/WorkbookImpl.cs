using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using XlsOp.Excel;
using XlsOp.VBIDE;
using XlsOp.VBIDE.COM;

namespace XlsOp.Excel.COM
{
    class WorkbookImpl : ComObjectWrapper, IWorkbook
    {
        public WorkbookImpl(object o)
            : base(o)
        {
        }

        IVBProject IWorkbook.VBProject
        {
            get
            {
                return new VBProjectImpl(this.GetProperty("VBProject"));
            }
        }

        //IWorksheet IWorkbook.ActiveSheet
        //{
        //    get
        //    {
        //        return new WorksheetImpl(this.GetProperty("ActiveSheet"));
        //    }
        //}

        void IWorkbook.Save()
        {
            this.InvokeMethod("Save");
        }

        void IWorkbook.Close()
        {
            this.InvokeMethod("Close");
        }
    }
}
