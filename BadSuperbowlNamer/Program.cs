using System;

namespace BadSuperbowlNamer
{
    class Program
    {
        static void Main(string[] args)
        {
            var namer = new SuperbowlNamer();
            Console.WriteLine("Please enter a Superbowl number to convert and press enter.");
            var input = Console.ReadLine();
            var output = namer.ConvertNumber(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
