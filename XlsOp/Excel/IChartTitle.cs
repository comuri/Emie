using System;
using System.Collections.Generic;
using System.Text;

namespace Exl.Excel
{
    public interface IChartTitle
    {
        string Text { get; set; }
        ICharacters Characters { get; }
    }
}
