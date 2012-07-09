using System;
using System.Collections.Generic;
using System.Reflection;
using Exl.Office;
using Exl.Office.COM;

namespace Exl.Excel.COM
{
    class FillFormatImpl : IFillFormat
    {
        private object instance;

        internal FillFormatImpl(object instance)
        {
            this.instance = instance;
        }

        IGradientStops IFillFormat.GradientStops
        {
            get
            {
                object o = instance.GetType().InvokeMember("GradientStops", BindingFlags.GetProperty, null, instance, null);
                return new GradientStopsImpl(o);
            }
        }

        void IFillFormat.OneColorGradient(GradientStyle style, int variant, float degree)
        {
            instance.GetType().InvokeMember("OneColorGradient", BindingFlags.InvokeMethod, null, instance, new object[] { style, variant, degree });
        }

        void IFillFormat.TwoColorGradient(GradientStyle style, int variant)
        {
            instance.GetType().InvokeMember("TwoColorGradient", BindingFlags.InvokeMethod, null, instance, new object[] { style, variant });
        }
    }
}
