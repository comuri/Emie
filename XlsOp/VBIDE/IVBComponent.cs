using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.VBIDE
{
    public interface IVBComponent : IComObject
    {
        ComponentType Type { get; }
        string Name { get; }
        ICodeModule CodeModule { get; }
        void Export(string path);
    }
}
