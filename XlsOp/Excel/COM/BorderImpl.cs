using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exl.Excel.COM
{
    class BorderImpl : IBorder
    {
        private object instance;

        internal BorderImpl(object instance)
        {
            this.instance = instance;
        }

        long IBorder.Color
        {
            get
            {
                object o = instance.GetType().InvokeMember("Color", BindingFlags.GetProperty, null, instance, null);
                return (long)o;
            }
            set
            {
                instance.GetType().InvokeMember("Color", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }
    }
}
