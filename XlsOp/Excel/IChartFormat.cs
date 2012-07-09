using System;
using System.Collections.Generic;
using System.Text;

namespace Exl.Excel
{
    public interface IChartFormat
    {
        IFillFormat Fill { get; }
        ILineFormat Line { get; }
    }
}
