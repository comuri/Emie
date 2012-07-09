using System;
using System.Collections.Generic;
using System.Text;
using Exl.Office;

namespace Exl.Excel
{
    public enum LineStyle
    {
        Mixed = -2,
        Single = 1,
        ThinThin = 2,
        ThinThick = 3,
        ThickThin = 4,
        ThickBetweenThin = 5,
    }

    public interface ILineFormat
    {
        LineStyle Style { get; set; }
        TriState Visible { get; set; }
        float Weight { get; set; }
        IColorFormat ForeColor { get; }
    }
}
