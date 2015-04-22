using System;
using System.Globalization;

namespace Cielo4Net.Extensions
{
    internal static class DecimalExtensions
    {
        public static int OnlyNumbers(this decimal source)
        {
            return Convert.ToInt32(source.ToString(CultureInfo.InvariantCulture).OnlyNumbers());
        }
    }
}