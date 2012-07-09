using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace XlsOp.VBIDE.COM
{
    internal class VBComponentImpl : ComObjectWrapper ,IVBComponent
    {
        public VBComponentImpl(object o)
            : base(o)
        {
        }

        ComponentType IVBComponent.Type
        {
            get
            {
                return (ComponentType)this.GetProperty("Type");
            }
        }

        string IVBComponent.Name
        {
            get
            {
                return (string)this.GetProperty("Name");
            }
        }

        ICodeModule IVBComponent.CodeModule
        {
            get
            {
                return new CodeModuleImpl(this.GetProperty("CodeModule"));
            }
        }

        void IVBComponent.Export(string path)
        {
            this.InvokeMethod("Export", path);
        }
    }
}
