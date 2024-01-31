using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04.Classes
{
    class Motorcycle : MotorVehicle
    {
        public override short GetYears()
        {
            int age = DateTime.Now.Year - ManifactureYear;
            Console.WriteLine($"The motorcycle is {age} years old.");
            return (short)age;
        }
    }
}
