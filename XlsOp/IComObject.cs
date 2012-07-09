using System;

namespace XlsOp
{
    public interface IComObject : IDisposable
    {
        object Instance { get; }
    }
}
