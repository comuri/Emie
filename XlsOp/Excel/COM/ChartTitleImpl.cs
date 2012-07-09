using System;
using System.Reflection;

namespace Exl.Excel.COM
{
    class ChartTitleImpl : IChartTitle
    {
        private object instance;

        internal ChartTitleImpl(object instance)
        {
            this.instance = instance;
        }

        string IChartTitle.Text
        {
            get
            {
                object o = instance.GetType().InvokeMember("Text", BindingFlags.GetProperty, null, instance, null);
                return (string)o;
            }
            set
            {
                instance.GetType().InvokeMember("Text", BindingFlags.SetProperty, null, instance, new object[] { value });
            }
        }

        ICharacters IChartTitle.Characters
        {
            get
            {
                object o = instance.GetType().InvokeMember("Characters", BindingFlags.GetProperty, null, instance, null);
                return new CharactersImpl(o);
            }
        }
    }
}
