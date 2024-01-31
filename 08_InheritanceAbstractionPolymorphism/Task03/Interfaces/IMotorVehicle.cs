using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03.Interfaces
{
    interface IMotorVehicle
    {
        string Name { get; set; }
        short ManifactureYear { get; set; }
        string RegistrationNumber { get; set; }
        string Engine { get; set; }

        void Drive(int speedKph);
        short GetYears();
    }
}
