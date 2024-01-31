namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pass = new Passenger(400, 1400);
            Console.WriteLine();

            // nothing should happen for these lower values
            pass.SetSpeed(200);
            pass.SetAltitude(1000);
            Console.WriteLine();

            // these will invoke the event
            pass.SetSpeed(450);
            pass.SetAltitude(1500);
            Console.WriteLine();

            var fight = new Fighter(800, 2400);
            Console.WriteLine();

            // nothing should happen for these lower values
            fight.SetSpeed(500);
            fight.SetAltitude(2000);
            Console.WriteLine();

            // these will invoke the event
            fight.SetSpeed(900);
            fight.SetAltitude(3000);
            Console.WriteLine();
        }
    }
}
