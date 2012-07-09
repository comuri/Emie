using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

namespace XlsOp
{
    public delegate void ComReleaseHandler();

    public class ComObjectWrapper : CriticalFinalizerObject, IComObject
    {
        public event ComReleaseHandler OnBeforeRelease;

        public ComObjectWrapper(object o)
        {
            if (o == null)
                throw new ArgumentNullException();
            if (!Marshal.IsComObject(o))
                throw new ArgumentException();

            this.handle = GCHandle.Alloc(o);
        }

        ~ComObjectWrapper()
        {
            this.Dispose(false);
        }

        public object Instance
        {
            get
            {
                return this.handle.Target;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.handle.IsAllocated) {
                if (this.handle.Target != null) {
                    //OnBeforeRelease();
                    Marshal.ReleaseComObject(this.handle.Target);
                    if (disposing)
                        this.handle.Target = null;
                }
                this.handle.Free();
            }
        }

        protected object InvokeMethod(string symbolName, params object[] args)
        {
            return this.Instance.GetType().InvokeMember(symbolName, BindingFlags.InvokeMethod, null, this.Instance, args);
        }

        protected object GetProperty(string symbolName, params object[] args)
        {
            return this.Instance.GetType().InvokeMember(symbolName, BindingFlags.GetProperty, null, this.Instance, args);
        }

        protected void SetProperty(string symbolName, params object[] args)
        {
            this.Instance.GetType().InvokeMember(symbolName, BindingFlags.SetProperty, null, this.Instance, args);
        }

        private GCHandle handle;
    }
}
