namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carList = new List<Car>
            {
                new Car("Opel", "Astra", 4),
                new Car("BMW", "M5", 2),
                new Car("Audi", "A8", 4),
                new Car("Ford", "Mondeo", 4),
                new Car("Skoda", "Octavia", 4),
            };

            foreach (var car in carList)
            {
                car.PrintCarInfo();
            }

            Console.WriteLine();
        }
    }
}
