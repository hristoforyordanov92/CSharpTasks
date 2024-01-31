namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Car> carList = new();

            carList.AddLast(new Car("Opel", "Astra", 4));
            carList.AddLast(new Car("BMW", "M5", 2));
            carList.AddLast(new Car("Audi", "A8", 4));
            carList.AddLast(new Car("Ford", "Mondeo", 4));
            carList.AddLast(new Car("Skoda", "Octavia", 4));

            foreach (var car in carList)
            {
                car.PrintCarInfo();
            }
        }
    }
}
