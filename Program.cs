using System;
using System.Linq;

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

            // Trim whitespaces around each item and remove empty items
            string[] items = args[0]
                .Split(',')
                .Select(item => item.Trim())           // Trim spaces around each item
                .Where(item => !string.IsNullOrEmpty(item))  // Remove empty items
                .ToArray();
            string quote = args[1];

            // Quote can only be one character
            if (string.IsNullOrEmpty(quote) || quote.Length != 1)
            {
                Console.WriteLine("Quote character must be a single character.");
                return;
            }

            string result = StringFormatter.ToCommaSeparatedList(items, quote);

            Console.WriteLine("Formatted list:");
            Console.WriteLine(result);
        }
    }
}