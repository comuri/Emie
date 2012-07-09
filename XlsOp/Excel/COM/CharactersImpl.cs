using System;
using System.Reflection;

namespace Exl.Excel.COM
{
    class CharactersImpl : ICharacters
    {
        private object instance;

        internal CharactersImpl(object instance)
        {
            this.instance = instance;
        }

        IFont ICharacters.Font
        {
            get
            {
                object o = instance.GetType().InvokeMember("Font", BindingFlags.GetProperty, null, instance, null);
                return new FontImpl(o);
            }
        }
    }
}
