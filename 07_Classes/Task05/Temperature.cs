using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    static class Temperature
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            return celsius * (9d / 5d) + 32d;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32d) * (5d / 9d);
        }
    }
}
