using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Fighter : Plane
    {
        public int NumberOfRockets { get; set; }

        public override string PlaneType
        {
            get
            {
                return "Fighter";
            }
        }

        public Fighter(int maxSpeed, int maxAltitude)
            : base(maxSpeed, maxAltitude)
        {
        }
    }
}
