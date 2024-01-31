using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class InvalidMonthNumberException : Exception
    {
        public InvalidMonthNumberException() : base() { }
        public InvalidMonthNumberException(string message) : base(message) { }
    }
}
