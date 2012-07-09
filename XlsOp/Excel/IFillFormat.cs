using System;
using System.Collections.Generic;
using System.Text;
using Exl.Office;

namespace Exl.Excel
{
    public enum GradientStyle
    {
        Mixed = -2,
        Horizontal = 1,
        Vertical = 2,
        DiagonalUp = 3,
        DiagonalDown = 4,
        FromCorner = 5,
        FromTitle = 6,
        FromCenter = 7,
    }

    public interface IFillFormat
    {
        IGradientStops GradientStops { get; }
        void OneColorGradient(GradientStyle style, int variant, float degree);
        void TwoColorGradient(GradientStyle style, int variant);
    }
}
