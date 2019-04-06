using System;
using System.Runtime.Serialization;

namespace BadSuperbowlNamer
{
    public class NonNumberInputException : Exception
    {
        public NonNumberInputException() : base("A non-number input was entered.")
        {

        }
    }
}