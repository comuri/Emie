using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exl.Excel.COM
{
    class FormatImpl : IChartFormat
    {
        private object instance;

        internal FormatImpl(object instance)
        {
            this.instance = instance;
        }

        IFillFormat IChartFormat.Fill
        {
            get
            {
                object o = instance.GetType().InvokeMember("Fill", BindingFlags.GetProperty, null, instance, null);
                return new FillFormatImpl(o);
            }
        }

        ILineFormat IChartFormat.Line
        {
            get
            {
                object o = instance.GetType().InvokeMember("Line", BindingFlags.GetProperty, null, instance, null);
                return new LineFormatImpl(o);
            }
        }
    }
}
