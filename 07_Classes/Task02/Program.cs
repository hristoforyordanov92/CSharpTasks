namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto1 = new Motorcycle
            {
                Brand = "Honda",
                Model = "Hornet CB 600 F",
                Color = "White/Red",
                ProductionYear = new DateTime(2003, 1, 1),
                MaxSpeed = 220
            };

            Motorcycle moto2 = new Motorcycle
            {
                Brand = "Honda",
                Model = "CBR 1000 Fireblade",
                Color = "White/Black",
                ProductionYear = new DateTime(2008, 1, 1),
                MaxSpeed = 300
            };

            Motorcycle moto3 = new Motorcycle
            {
                Brand = "Simson",
                Model = "SR1",
                Color = "Black",
                ProductionYear = new DateTime(1955, 1, 1),
                MaxSpeed = 50
            };
        }
    }
}
