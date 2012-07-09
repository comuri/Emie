using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.Office
{
    public interface IGradientStop
    {
        float Position { get; set; }
        IColorFormat Color { get; }
    }
}
