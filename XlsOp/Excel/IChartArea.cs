using System;
using System.Collections.Generic;
using System.Text;

namespace Exl.Excel
{
    public interface IChartArea
    {
        IBorder Border { get; }
        IChartFormat Format { get; }
    }
}
