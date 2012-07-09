using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace XlsOp.Office.COM
{
    class GradientStopImpl : IGradientStop
    {
        private object instance;

        internal GradientStopImpl(object instance)
        {
            this.instance = instance;
        }

        float IGradientStop.Position
        {
            get
            {
                object o = instance.GetType().InvokeMember("Position", BindingFlags.GetProperty, null, instance, null);
                return (float)o;
            }
            set
            {
                object o = instance.GetType().InvokeMember("Position", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }
        IColorFormat IGradientStop.Color
        {
            get
            {
                object o = instance.GetType().InvokeMember("Color", BindingFlags.GetProperty, null, instance, null);
                return new ColorFormatImpl(o);
            }
        }
    }
}
