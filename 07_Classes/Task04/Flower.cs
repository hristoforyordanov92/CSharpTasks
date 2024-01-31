using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal struct Flower
    {
        private string name;
        private string color;
        private int height;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public void Bloom()
        {
            Console.WriteLine($"{Name} just bloomed! It has a nice {Color} color and is {Height} centimeters tall!");
        }
    }
}
