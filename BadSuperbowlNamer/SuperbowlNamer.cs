using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSuperbowlNamer
{
    public class SuperbowlNamer
    {
        static readonly Dictionary<int, string> _romanNumerals = new Dictionary<int, string>() {
            { 1, "I" }, { 4, "IV" }, { 5, "V" }, { 9, "IX" }, { 10, "X" }, { 40, "XL" }, { 50, "L" },
            { 90, "XC" }, { 100, "C" }, { 400, "CD" }, { 500, "D" }, { 900, "CM" }, { 1000, "M" }, {999999999, "" }
        };
       public string ConvertNumber(string input)
        {
            try
            {
                var num = int.Parse(input);
                var baseNum = SuperbowlNamer.RomanBase(num);
                var result = RomanBuilder(baseNum, num);

                return result;
            } catch
            {
                Console.Write("Uh oh you friccin moron, thats not a number.");
                throw (new NonNumberInputException());
            }
            
        }

        static string RomanBuilder(int baseNumber, int num)
        {
            var output = "";
            var remainder = num;
            var baseNum = baseNumber;

            while (remainder > 0)
            {
                output += SuperbowlNamer._romanNumerals[baseNum];
                remainder -= baseNum;
                baseNum = RomanBase(remainder);        
            } 
            return output;
        }

        static int RomanBase(int num)
        {
            var baseNum = 0;
            List<int> romanBases = SuperbowlNamer._romanNumerals.Select(kvp => kvp.Key).ToList();
            for (var i = 0; i < romanBases.Count; i++)
            {
                if (num >= romanBases[i] && num < romanBases[i + 1])
                {
                    baseNum = romanBases[i];
                }
            }

            return baseNum;
        }
       
    }
}
