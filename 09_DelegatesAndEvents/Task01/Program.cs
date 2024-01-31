namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrencyConverter.On10000Conversion += SendEmail;
            CurrencyConverter.On10000Conversion += StealMoney;
            CurrencyConverter.On10000Conversion += ArrestCriminals;

            CurrencyConverter.EURToUSD(100);
            CurrencyConverter.USDToEUR(500);
            CurrencyConverter.EURToUSD(11000);
            CurrencyConverter.USDToEUR(50000);
        }

        public static void SendEmail()
        {
            Console.WriteLine("You converted 10000 or more of your currency. Be careful!");
        }

        public static void StealMoney()
        {
            Console.WriteLine("A gang tried to steal the money!");
        }

        public static void ArrestCriminals()
        {
            Console.WriteLine("Police launched an attack in order to arrest all criminals.");
        }
    }
}
