using System;
using PointsBet_Backend_Online_Code_Test;  // Reference to class library namespace

namespace PointsBet_Backend_Online_Code_Test_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: dotnet run <comma-separated-items> <quote-character>");
                Console.WriteLine("Example: dotnet run \"table,pen,book\" \"'\"");
                return;
            }

            string[] items = args[0].Split(',');
            string quote = args[1];

            string result = StringFormatter.ToCommaSeparatedList(items, quote);

            Console.WriteLine("Formatted list:");
            Console.WriteLine(result);
        }
    }
}