using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exl.Excel.COM
{
    class ChartImpl : IChart
    {
        private object instance;

        internal ChartImpl(object instance)
        {
            this.instance = instance;
        }

        ChartType IChart.ChartType
        {
            get
            {
                object o = instance.GetType().InvokeMember("ChartType", BindingFlags.GetProperty, null, instance, null);
                return (ChartType)o;
            }
            set
            {
                instance.GetType().InvokeMember("ChartType", BindingFlags.SetProperty, null, instance, new object[] {value});
            }
        }

        bool IChart.HasTitle
        {
            get
            {
                object o = instance.GetType().InvokeMember("HasTitle", BindingFlags.GetProperty, null, instance, null);
                return (bool)o;
            }
            set
            {
                instance.GetType().InvokeMember("HasTitle", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        bool IChart.HasLegend
        {
            get
            {
                object o = instance.GetType().InvokeMember("HasLegend", BindingFlags.GetProperty, null, instance, null);
                return (bool)o;
            }
            set
            {
                instance.GetType().InvokeMember("HasLegend", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        IChartTitle IChart.ChartTitle
        {
            get
            {
                object o = instance.GetType().InvokeMember("ChartTitle", BindingFlags.GetProperty, null, instance, null);
                return new ChartTitleImpl(o);
            }
        }

        IChartArea IChart.ChartArea
        {
            get
            {
                object o = instance.GetType().InvokeMember("ChartArea", BindingFlags.GetProperty, null, instance, null);
                return new ChartAreaImpl(o);
            }
        }

        IPlotArea IChart.PlotArea
        {
            get
            {
                object o = instance.GetType().InvokeMember("PlotArea", BindingFlags.GetProperty, null, instance, null);
                return new PlotAreaImpl(o);
            }
        }
    }
}
