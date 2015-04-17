using System;
using System.Linq;

namespace Cielo.Extensions
{
    internal static class StringExtensions
    {
        public static string OnlyNumbers(this string source)
        {
            return new String(source.Where(Char.IsDigit).ToArray());
        }
    }
}
