using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car
    {
        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private DateTime _productionDate;
        public DateTime ProductionDate
        {
            get { return _productionDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("The car can not be produced in the future.");
                    _productionDate = DateTime.Now;
                }
                else
                {
                    _productionDate = value; 
                }
            }
        }

        private sbyte _seatsNumber;
        public sbyte SeatsNumber
        {
            get
            {
                return _seatsNumber;
            }
            set
            {
                if (value >= 1)
                {
                    _seatsNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid number of seats! Must have atleast 1 seat.");
                    _seatsNumber = 1;
                }
            }
        }

        private bool _isDiesel;
        public bool IsDiesel
        {
            get { return _isDiesel; }
            set { _isDiesel = value; }
        }

        public Car(string brand, string model, string color, DateTime productionDate, sbyte seatsNumber, bool isDiesel)
        {
            Brand = brand;
            Model = model;
            Color = color;
            ProductionDate = productionDate;
            SeatsNumber = seatsNumber;
            IsDiesel = isDiesel;
        }

        public void PrintProperties()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Production date: {ProductionDate.ToShortDateString()}");
            Console.WriteLine($"Number of seats: {SeatsNumber}");
            Console.WriteLine($"Is diesel: {IsDiesel}");
            Console.WriteLine();
        }
    }
}
