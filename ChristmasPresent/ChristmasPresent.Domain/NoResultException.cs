using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPresent.Domain
{
    public class NoResultException: Exception
    {
        public NoResultException(string message):
            base(message)
        { }
    }
}
