using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task03.Interfaces;

namespace Task03.Classes
{
    class Motorcycle : IMotorVehicle
    {
        //IMotorVehicle implementation
        public string Name { get; set; }
        public short ManifactureYear { get; set; }
        public string RegistrationNumber { get; set; }
        public string Engine { get; set; }

        public void Drive(int speedKph)
        {
            Console.WriteLine($"{Name} is driving with {speedKph} km/h.");
        }

        public short GetYears()
        {
            int age = DateTime.Now.Year - ManifactureYear;
            Console.WriteLine($"The motorcycle is {age} years old.");
            return (short)age;
        }
    }
}
