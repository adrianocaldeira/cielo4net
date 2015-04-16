using System;
using System.Globalization;

namespace Cielo.Extensions
{
    internal static class DecimalExtensions
    {
        public static int SomenteNumeros(this decimal source)
        {
            return Convert.ToInt32(source.ToString(CultureInfo.InvariantCulture).SomenteNumeros());
        }
    }
}