using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.Office
{
    public interface IGradientStops
    {
        IGradientStop this[int i] { get; }
    }
}
