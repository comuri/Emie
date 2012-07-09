using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.Excel.COM
{
    public class Application : ComObjectWrapper, IApplication
    {
        private Application(object o)
            : base(o)
        {
        }

        IWorkbooks IApplication.Workbooks
        {
            get
            {
                return new WorkbooksImpl(this.GetProperty("Workbooks"));
            }
        }

        bool IApplication.Visible
        {
            get
            {
                return (bool)this.GetProperty("Visible");
            }
            set
            {
                this.SetProperty("Visible", value);
            }
        }

        void IApplication.Quit()
        {
            this.InvokeMethod("Quit");
        }

        public static IApplication newInstance()
        {
            Type excelType = Type.GetTypeFromProgID("Excel.Application");
            return new Application(Activator.CreateInstance(excelType));
        }
    }
}
