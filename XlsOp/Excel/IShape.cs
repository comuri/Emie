using System;
using System.Collections.Generic;
using System.Text;

namespace Exl.Excel
{
    public interface IShape
    {
        Single Left { get; set; }
        IChart Chart { get; }
    }
}
