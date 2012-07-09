using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exl.Excel.COM
{
    class ChartAreaImpl : IChartArea
    {
        private object instance;

        internal ChartAreaImpl(object instance)
        {
            this.instance = instance;
        }

        IBorder IChartArea.Border
        {
            get
            {
                object o = instance.GetType().InvokeMember("Border", BindingFlags.GetProperty, null, instance, null);
                return new BorderImpl(o);
            }
        }

        IChartFormat IChartArea.Format
        {
            get
            {
                object o = instance.GetType().InvokeMember("Format", BindingFlags.GetProperty, null, instance, null);
                return new FormatImpl(o);
            }
        }
    }
}
