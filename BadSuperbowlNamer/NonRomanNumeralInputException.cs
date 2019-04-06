using System;
using System.Runtime.Serialization;

namespace BadSuperbowlNamer
{
    [Serializable]
    internal class NonRomanNumeralInputException : Exception
    {
        public NonRomanNumeralInputException() : base("A non-Roman numeral input was entered.")
        {

        }
    }
}