using System;
using System.Reflection;

namespace XlsOp.Office.COM
{
    class ColorFormatImpl : IColorFormat
    {
        private object instance;

        internal ColorFormatImpl(object instance)
        {
            this.instance = instance;
        }

        int IColorFormat.RGB
        {
            get
            {
                object o = instance.GetType().InvokeMember("RGB", BindingFlags.GetProperty, null, instance, null);
                return (int)o;
            }
            set
            {
                object o = instance.GetType().InvokeMember("RGB", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }
    }
}
