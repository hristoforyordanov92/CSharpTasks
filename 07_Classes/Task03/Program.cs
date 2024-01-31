namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (between 10 and 30000): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (n > 30000 || n < 10)
            {
                if (n > 30000)
                {
                    Console.Write("You are above the maximum allowed value.\nEnter a new number (between 10 and 30000): ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                else if (n < 10)
                {
                    Console.Write("You are below the minimum allowed value.\nEnter a new number (between 10 and 30000): ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"The sum of all numbers from 1 to {n} is {RecursionSum(n)}.");
            Console.WriteLine();
        }

        static int RecursionSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return RecursionSum(n - 1) + n;
        }
    }
}
