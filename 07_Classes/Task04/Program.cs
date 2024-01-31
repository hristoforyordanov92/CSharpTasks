namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower
            {
                Name = "Flowey",
                Color = "yellow",
                Height = 30
            };

            flower.Bloom();
        }
    }
}
