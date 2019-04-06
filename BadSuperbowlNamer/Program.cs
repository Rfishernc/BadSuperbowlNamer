using System;

namespace BadSuperbowlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 1 to convert a number to Roman numeral or enter 2 to convert a Roman numeral to a number.");
            var selection = Console.ReadLine();
            if (selection == "1")
            {
                NumberToRoman();
            }
            else if (selection == "2")
            {
                RomanToNumber();
            }
            else
            {
                Console.WriteLine("You cant follow directions dumbass.");
                Console.ReadLine();
            }
        }
        static void NumberToRoman()
        {
            var namer = new SuperbowlNamer();
            Console.WriteLine("Please enter a Superbowl number to convert and press enter.");
            var input = Console.ReadLine();
            var output = namer.ConvertNumber(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        static void RomanToNumber()
        {
            var namer = new SuperbowlNamer();
            Console.WriteLine("Please enter a Superbowl Roman numeral to convert and press enter.");
            var input = Console.ReadLine();
            var output = namer.ConvertRoman(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
