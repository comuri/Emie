using System;
using System.Collections.Generic;
using System.Text;

namespace Exl.Excel
{
    public enum ChartType
    {
        BarStacked = 58
    }

    public interface IChart
    {
        ChartType ChartType { get; set; }
        bool HasTitle { get; set; }
        bool HasLegend { get; set; }
        IChartTitle ChartTitle { get; }
        IChartArea ChartArea { get; }
        IPlotArea PlotArea { get; }
    }
}
