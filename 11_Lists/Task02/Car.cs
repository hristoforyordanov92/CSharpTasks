using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Car
    {
        private static Random _random = new Random();

        public string Brand { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public int NumberOfSeats { get; set; }

        public Car(string brand, string model, int numberOfSeats)
        {
            Brand = brand;
            Model = model;
            RegistrationNumber = GetRandomRegistrationNumber();
            NumberOfSeats = numberOfSeats;
        }

        private static string GetRandomRegistrationNumber()
        {
            string regNumber = "";

            regNumber += (char)_random.Next(65, 90) + "" + (char)_random.Next(65, 90) + " ";
            for (int i = 0; i < 4; i++)
            {
                regNumber += _random.Next(0, 9);
            }
            regNumber += " " + (char)_random.Next(65, 90) + "" + (char)_random.Next(65, 90);

            return regNumber;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"{Brand} {Model} with registration number {RegistrationNumber} has {NumberOfSeats} seats.");
        }
    }
}
