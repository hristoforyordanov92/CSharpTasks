namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthNumber;
            while (true)
            {
                try
                {
                    Console.Write("Enter the number of the month (from 1 to 12): ");
                    monthNumber = int.Parse(Console.ReadLine());
                    if (monthNumber < 1 || monthNumber > 12)
                    {
                        throw new InvalidMonthNumberException("Invalid month number! Month number must be from 1 to 12.");
                    }
                    Console.WriteLine($"Month number {monthNumber} is {(Month)monthNumber}");
                    Console.WriteLine();
                    //break; //neverending fun!
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    continue;
                }
            }
        }
    }
}
