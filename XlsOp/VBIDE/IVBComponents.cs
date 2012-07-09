using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.VBIDE
{
    public interface IVBComponents : IComObject, IEnumerable<IVBComponent>
    {
        IVBComponent Import(string path);
        void Remove(IVBComponent component);
    }
}
