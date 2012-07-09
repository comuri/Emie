using System;
using System.Reflection;

namespace Exl.Excel.COM
{
    class PlotAreaImpl : IPlotArea
    {
        private object instance;

        internal PlotAreaImpl(object instance)
        {
            this.instance = instance;
        }

        IChartFormat IPlotArea.Format
        {
            get
            {
                object o = instance.GetType().InvokeMember("Format", BindingFlags.GetProperty, null, instance, null);
                return new FormatImpl(o);
            }
        }
    }
}
