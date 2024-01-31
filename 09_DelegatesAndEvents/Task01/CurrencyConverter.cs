using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    public static class CurrencyConverter
    {
        public delegate void ConversionEventHandler();
        public static event ConversionEventHandler On10000Conversion;

        public static void EURToUSD(decimal amount)
        {
            decimal currencyRate = 1.16093M;
            Console.WriteLine($"\n{amount} EUR is converted to {amount * currencyRate} USD");
            if (amount >= 10000)
            {
                On10000Conversion?.Invoke();
            }
        }

        public static void USDToEUR(decimal amount)
        {
            decimal currencyRate = 0.861382M;
            Console.WriteLine($"\n{amount} USD is converted to {amount * currencyRate} EUR");
            if (amount >= 10000)
            {
                On10000Conversion?.Invoke();
            }
        }
    }
}
