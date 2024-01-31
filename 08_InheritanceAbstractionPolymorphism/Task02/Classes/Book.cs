using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Classes
{
    class Book : BookBase
    {
        private string title;
        private string author;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public void Print(short pageNumber)
        {
            Console.WriteLine($"The page number {pageNumber} will be printed out.");
        }
    }
}
