using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic.Utilities.Exceptions
{
    public class TrafficException : Exception
    {
        public TrafficException()
        {
        }

        public TrafficException(string message)
            : base(message)
        {
        }

        public TrafficException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
