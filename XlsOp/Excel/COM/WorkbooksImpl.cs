using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace XlsOp.Excel.COM
{
    public class WorkbooksImpl : ComObjectWrapper, IWorkbooks, IEnumerable<IWorkbook>
    {
        public WorkbooksImpl(object o)
            : base(o)
        {
        }

        IWorkbook IWorkbooks.Open(string path)
        {
            return new WorkbookImpl(this.InvokeMethod("Open", path));
        }

        IWorkbook IWorkbooks.Add()
        {
            return new WorkbookImpl(this.InvokeMethod("Add"));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumeratorImpl();
        }

        IEnumerator<IWorkbook> IEnumerable<IWorkbook>.GetEnumerator()
        {
            return this.GetEnumeratorImpl();
        }

        private IEnumerator<IWorkbook> GetEnumeratorImpl()
        {
            int count = (int)this.GetProperty("Count");
            List<IWorkbook> workbooks = new List<IWorkbook>(count);
            for (int i = 1; i <= count; i++)
                workbooks.Add(new Excel.COM.WorkbookImpl(this.InvokeMethod("Item", i)));
            return workbooks.GetEnumerator();
        }
    }
}
