using System;
using System.Globalization;

namespace WeatherMicroservice
{
    public static class Extensions
    {
        
        public static double? TryParse(this string input)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            if (double.TryParse(input, out var result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}