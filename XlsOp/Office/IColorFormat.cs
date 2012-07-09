using System;
using System.Collections.Generic;
using System.Text;

namespace XlsOp.Office
{
    public class RGBUtil
    {
        public static int RGB(byte r, byte g, byte b)
        {
            return (b << 16) | (g << 8) | (r << 0);
        }
    }

    public interface IColorFormat
    {
        int RGB { get; set; }
    }
}
