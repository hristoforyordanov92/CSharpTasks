namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var season in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine(season);
            }
        }
    }
}
