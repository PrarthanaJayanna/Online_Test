using System;
using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{
    public static class StringFormatter // static class with static method
    {
        // Returns a comma-separated string, wrapping each item in the given quote.
        // Example: Input: ["table", "pen"] with quote ''' => 'table', 'pen'
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            // checking if items is null before we check it's length using .Length
            // since checking .Length on null will throw an exception
            if (items == null || items.Length == 0)
                return string.Empty;

            return string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));
        }
    }
}
