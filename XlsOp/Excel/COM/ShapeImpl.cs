using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exl.Excel.COM
{
    class ShapeImpl : IShape
    {
        private object instance;

        internal ShapeImpl(object instance)
        {
            this.instance = instance;
        }

        Single IShape.Left
        {
            get
            {
                object o = instance.GetType().InvokeMember("Left", BindingFlags.GetProperty, null, instance, null);
                return (Single)o;
            }
            set
            {
                instance.GetType().InvokeMember("Left", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        IChart IShape.Chart
        {
            get
            {
                object o = instance.GetType().InvokeMember("Chart", BindingFlags.GetProperty, null, instance, null);
                return new ChartImpl(o);
            }
        }
    }
}
