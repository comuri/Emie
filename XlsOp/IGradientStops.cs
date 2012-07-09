using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exl.Office
{
    public interface IGradientStops
    {
        IGradientStop this[int i] { get; }
    }
}
