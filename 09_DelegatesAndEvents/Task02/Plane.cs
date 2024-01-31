using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    abstract class Plane
    {
        public delegate void PlaneEventHandler();

        public event PlaneEventHandler AltitudeReached;
        public event PlaneEventHandler SpeedReached;

        public abstract string PlaneType { get; }

        public int CurrentSpeed { get; private set; }
        public int CurrentAltitude { get; private set; }

        public int MaximumSpeed { get; }
        public int MaximumAltitude { get; }

        public Plane(int maxSpeed, int maxAltitude)
        {
            Console.WriteLine($"{PlaneType} plane created. Max speed: {maxSpeed} km/h, Max altitude: {maxAltitude} m ");

            MaximumSpeed = maxSpeed;
            MaximumAltitude = maxAltitude;

            SpeedReached += MaxSpeedWarning;
            AltitudeReached += MaxAltitudeWarning;
        }

        public void SetSpeed(int speed)
        {
            CurrentSpeed = speed;

            Console.WriteLine($"{PlaneType} plane speed set to {CurrentSpeed} km/h.");
            if (CurrentSpeed > MaximumSpeed)
            {
                SpeedReached?.Invoke();
            }
        }

        public void SetAltitude(int altitude)
        {
            CurrentAltitude = altitude;

            Console.WriteLine($"{PlaneType} plane altitude set to {CurrentAltitude} m.");
            if (CurrentAltitude > MaximumAltitude)
            {
                AltitudeReached?.Invoke();
            }
        }

        public void MaxSpeedWarning()
        {
            Console.WriteLine($"{PlaneType} plane reached maximum speed! Must not exceed {MaximumSpeed} km/h. Current speed: {CurrentSpeed} km/h.");
        }

        public void MaxAltitudeWarning()
        {
            Console.WriteLine($"{PlaneType} plane reached maximum altitude! Must not exceed {MaximumAltitude} meters of altitude. Current altitude: {CurrentAltitude} meters.");
        }
    }
}
