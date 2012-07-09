using System;
using System.Reflection;

namespace XlsOp.VBIDE.COM
{
    internal class VBProjectImpl : ComObjectWrapper ,IVBProject
    {
        public VBProjectImpl(object o)
            : base(o)
        {
        }

        IVBComponents IVBProject.VBComponents
        {
            get
            {
                return new VBComponentsImpl(this.GetProperty("VBComponents"));
            }
        }
    }
}
