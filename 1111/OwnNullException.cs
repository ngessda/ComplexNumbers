using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class OwnNullException : DivideByZeroException
    {
        public OwnNullException(string Message)
            : base(Message)
        {
        }
    }
}
