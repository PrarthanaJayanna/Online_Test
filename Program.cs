using System;
using PointsBet_Backend_Online_Code_Test;  // Reference to class library namespace

namespace PointsBet_Backend_Online_Code_Test_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a comma-separated list of items as the first argument.");
                return;
            }

            string[] items = args[0].Split(',');
            string quote = "'";

            string result = StringFormatter.ToCommaSeparatedList(items, quote);

            Console.WriteLine("Formatted list:");
            Console.WriteLine(result);
        }
    }
}