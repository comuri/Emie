using System;
using System.Collections.Generic;
using System.Text;

namespace Exl.Excel
{
    public interface IFont
    {
        string Name { get; set; }
        float Size { get; set; }
        bool Bold { get; set; }
        bool Italic { get; set; }
    }
}
