using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.VBIDE
{
    public interface IVBProject : IComObject
    {
        IVBComponents VBComponents { get; }
    }
}
