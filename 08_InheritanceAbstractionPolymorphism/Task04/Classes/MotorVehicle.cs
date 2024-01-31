using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04.Classes
{
    abstract class MotorVehicle
    {
        public string Name { get; set; }
        public short ManifactureYear { get; set; }
        public string RegistrationNumber { get; set; }
        public string Engine { get; set; }

        public void Drive(int speedKph)
        {
            Console.WriteLine($"{Name} is driving with {speedKph} km/h.");
        }
        public abstract short GetYears();
    }
}
