using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace XlsOp.Office.COM
{
    class GradientStopsImpl : IGradientStops
    {
        private object instance;

        internal GradientStopsImpl(object instance)
        {
            this.instance = instance;
        }

        IGradientStop IGradientStops.this[int i]
        {
            get
            {
                object o = instance.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, instance, new object[]{i + 1});
                return new GradientStopImpl(o);
            }
        }
    }
}
