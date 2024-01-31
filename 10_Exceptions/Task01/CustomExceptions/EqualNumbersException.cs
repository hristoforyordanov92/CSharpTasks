using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.CustomExceptions
{
    class EqualNumbersException : Exception
    {
        public EqualNumbersException() : base() { }
        public EqualNumbersException(string message) : base(message) { }
    }
}
