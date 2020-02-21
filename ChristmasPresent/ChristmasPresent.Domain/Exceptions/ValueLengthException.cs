using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPresent.Domain
{
    public class ValueLengthException : Exception
    {
        public ValueLengthException(string message) :
            base(message)
        {}
    }
}
