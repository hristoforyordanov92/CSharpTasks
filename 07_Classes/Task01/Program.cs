using Vehicles;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Opel", "Astra", "Blue", new DateTime(1993, 5, 14), 4, false);
            Car car2 = new Car("BMW", "5", "Black/Red", new DateTime(2003, 9, 1), 4, false);

            car1.PrintProperties();
            car2.PrintProperties();
        }
    }
}
