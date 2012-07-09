using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace XlsOp.VBIDE.COM
{
    internal class VBComponentsImpl : ComObjectWrapper, IVBComponents, IEnumerable<IVBComponent>
    {
        public VBComponentsImpl(object o)
            : base(o)
        {
        }

        IVBComponent IVBComponents.Import(string path)
        {
            return new VBComponentImpl(this.InvokeMethod("Import", path));
        }

        void IVBComponents.Remove(IVBComponent component)
        {
            this.InvokeMethod("Remove", component.Instance);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumeratorImpl();
        }

        IEnumerator<IVBComponent> IEnumerable<IVBComponent>.GetEnumerator()
        {
            return this.GetEnumeratorImpl();
        }

        private IEnumerator<IVBComponent> GetEnumeratorImpl()
        {
            int count = (int)this.GetProperty("Count");
            List<IVBComponent> vbComponents = new List<IVBComponent>(count);
            for (int i = 1; i <= count; i++)
                vbComponents.Add(new VBComponentImpl(this.InvokeMethod("Item", i)));
            return vbComponents.GetEnumerator();
        }
    }
}
