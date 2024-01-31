using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Passenger : Plane
    {
        public int NumberOfPassengers { get; set; }

        public override string PlaneType
        {
            get
            {
                return "Passenger";
            }
        }

        public Passenger(int maxSpeed, int maxAltitude)
            : base(maxSpeed, maxAltitude)
        {
        }
    }
}
