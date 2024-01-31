using Task03.Classes;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                Engine = "76D2G17DG267GID21OIJSIAG7G1JO",
                ManifactureYear = 1993,
                Name = "Opel Astra",
                NumberOfWheels = 4,
                RegistrationNumber = "GG 6666 GG"
            };
            car1.Drive(120);
            car1.GetYears();
            car1.StartTurbo(); //Opel Astra with turbo? lol
            Console.WriteLine();

            Motorcycle moto1 = new Motorcycle()
            {
                Engine = "HD821G6D72H9J21DJH8Y12G81",
                ManifactureYear = 2003,
                Name = "Honda Hornet CB 600 F",
                RegistrationNumber = "HU 6969 II"
            };
            moto1.Drive(200);
            moto1.GetYears();
            Console.WriteLine();
        }
    }
}
