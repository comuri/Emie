using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Exl.Office;
using Exl.Office.COM;

namespace Exl.Excel.COM
{
    internal class LineFormatImpl : ILineFormat
    {
        private object instance;

        internal LineFormatImpl(object instance)
        {
            this.instance = instance;
        }

        LineStyle ILineFormat.Style
        {
            get
            {
                object o = instance.GetType().InvokeMember("Style", BindingFlags.GetProperty, null, instance, null);
                return (LineStyle)o;
            }
            set
            {
                instance.GetType().InvokeMember("Style", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        TriState ILineFormat.Visible
        {
            get
            {
                object o = instance.GetType().InvokeMember("Visible", BindingFlags.GetProperty, null, instance, null);
                return (TriState)o;
            }
            set
            {
                instance.GetType().InvokeMember("Visible", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        float ILineFormat.Weight
        {
            get
            {
                object o = instance.GetType().InvokeMember("Weight", BindingFlags.GetProperty, null, instance, null);
                return (float)o;
            }
            set
            {
                instance.GetType().InvokeMember("Weight", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        IColorFormat ILineFormat.ForeColor
        {
            get
            {
                object o = instance.GetType().InvokeMember("ForeColor", BindingFlags.GetProperty, null, instance, null);
                return new ColorFormatImpl(o);
            }
        }
    }
}
