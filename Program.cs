using System;
using PointsBet_Backend_Online_Code_Test;  // Reference to class library namespace

namespace PointsBet_Backend_Online_Code_Test_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "table", "pen", "paper", "book" };
            string quote = "'";

            string result = StringFormatter.ToCommaSeparatedList(items, quote);

            Console.WriteLine("Formatted list:");
            Console.WriteLine(result);
        }
    }
}