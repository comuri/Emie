using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.VBIDE
{
    public interface ILineCollection
    {
        string this[int startLine, int count] { get; }
    }

    public interface ICodeModule : IComObject
    {
        ILineCollection Lines { get; }
        int CountOfLines { get; }
        void DeleteLines(int startLine, int count);
        void InsertLines(int line, string s);
    }
}
