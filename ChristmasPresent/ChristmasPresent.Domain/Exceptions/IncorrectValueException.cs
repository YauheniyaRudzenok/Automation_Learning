using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPresent.Domain
{
    public class IncorrectValueException : Exception
    {
        public IncorrectValueException (string message):
            base(message)
        { }
    }
}
