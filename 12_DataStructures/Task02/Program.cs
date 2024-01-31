namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();

            //Fill queue
            for (int i = 1; i <= 10; i++)
            {
                numbers.Enqueue(i);
            }

            while (numbers.Peek() != 5)
            {
                Console.WriteLine($"Current Peek() is {numbers.Peek()}. Dequeueing...");
                numbers.Dequeue();
            }

            Console.WriteLine($"End of cycle! Current Peek() is {numbers.Peek()}.");
            Console.WriteLine();
        }
    }
}
