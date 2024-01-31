using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task04.Classes
{
    class Car : MotorVehicle
    {
        public byte NumberOfWheels { get; set; }

        public override short GetYears()
        {
            int age = DateTime.Now.Year - ManifactureYear;
            Console.WriteLine($"The car is {age} years old.");
            return (short)age;
        }

        public void StartTurbo()
        {
            Console.WriteLine($"{Name} has started its turbo!");
        }
    }
}
