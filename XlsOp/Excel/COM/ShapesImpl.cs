using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Exl.Excel.COM
{
    class ShapesImpl : IShapes
    {
        private object instance;

        internal ShapesImpl(object instance)
        {
            this.instance = instance;
        }

        IShape IShapes.AddChart(ChartType chartType, float left, float top, float width, float heighbor)
        {
            object o = instance.GetType().InvokeMember("AddChart", BindingFlags.InvokeMethod, null, instance, new object[] {chartType, left, top, width, heighbor});
            return new ShapeImpl(o);
        }
    }
}
