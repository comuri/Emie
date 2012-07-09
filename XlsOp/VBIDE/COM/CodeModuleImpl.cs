using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.VBIDE.COM
{
    internal class CodeModuleImpl : ComObjectWrapper, ICodeModule, ILineCollection
    {
        public CodeModuleImpl(object o)
            : base(o)
        {
        }

        public ILineCollection Lines
        {
            get
            {
                return this;
            }
        }

        public int CountOfLines
        {
            get
            {
                return (int)this.GetProperty("CountOfLines");
            }
        }

        void ICodeModule.DeleteLines(int startLine, int count)
        {
            this.InvokeMethod("DeleteLines", startLine, count);
        }

        void ICodeModule.InsertLines(int line, string s)
        {
            this.InvokeMethod("InsertLines", line, s);
        }

        string ILineCollection.this[int startLine, int count]
        {
            get
            {
                return (string)this.GetProperty("Lines", startLine, count);
            }
        }
    }
}
