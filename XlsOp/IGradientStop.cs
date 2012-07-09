using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exl.Office
{
    public interface IGradientStop
    {
        float Position { get; set; }
        IColorFormat Color { get; }
    }
}
