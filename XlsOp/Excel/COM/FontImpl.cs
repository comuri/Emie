using System;
using System.Reflection;

namespace Exl.Excel.COM
{
    class FontImpl : IFont
    {
        private object instance;

        internal FontImpl(object instance)
        {
            this.instance = instance;
        }

        string IFont.Name
        {
            get
            {
                object o = instance.GetType().InvokeMember("Name", BindingFlags.GetProperty, null, instance, null);
                return (string)o;
            }
            set
            {
                instance.GetType().InvokeMember("Name", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        float IFont.Size
        {
            get
            {
                object o = instance.GetType().InvokeMember("Size", BindingFlags.GetProperty, null, instance, null);
                return (float)o;
            }
            set
            {
                instance.GetType().InvokeMember("Size", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        bool IFont.Bold
        {
            get
            {
                object o = instance.GetType().InvokeMember("Bold", BindingFlags.GetProperty, null, instance, null);
                return (bool)o;
            }
            set
            {
                instance.GetType().InvokeMember("Bold", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        bool IFont.Italic
        {
            get
            {
                object o = instance.GetType().InvokeMember("Italic", BindingFlags.GetProperty, null, instance, null);
                return (bool)o;
            }
            set
            {
                instance.GetType().InvokeMember("Italic", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }
    }
}
