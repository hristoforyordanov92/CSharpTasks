using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Classes
{
    abstract class BookBase
    {
        private short published;
        private short numberOfPages;

        public short Published
        {
            get { return published; }
            set { published = value; }
        }
        public short NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }
    }
}
