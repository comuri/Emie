using System;
using System.Collections.Generic;
using System.Text;

namespace Exl.Excel
{
    public interface IWorksheet
    {
        IShapes Shapes { get; }
    }
}
