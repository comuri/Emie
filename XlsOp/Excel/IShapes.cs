using System;
using System.Collections.Generic;
using System.Text;

namespace Exl.Excel
{
    public interface IShapes
    {
        IShape AddChart(ChartType type, float left, float top, float width, float height);
    }
}
