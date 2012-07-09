using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exl.Excel.COM
{
    class WorksheetImpl : ComObjectWrapper, IWorksheet
    {
        internal WorksheetImpl(object o)
            : base(o)
        {
        }

        IShapes IWorksheet.Shapes
        {
            get
            {
                return new ShapesImpl(this.GetProperty("Shapes"));
            }
        }
    }
}
