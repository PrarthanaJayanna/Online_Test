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

            // Check if the quote is valid (only a single character allowed)
            if (string.IsNullOrEmpty(quote) || quote.Length != 1)
            {
                throw new ArgumentException("Quote character must be a single character.");
            }

            // Trim whitespace around each item and remove any empty items
            items = items.Select(item => item?.Trim()).Where(item => !string.IsNullOrEmpty(item)).ToArray();

            // Check if there are any valid items left after trimming and removing empty ones
            if (items.Length == 0)
            {
                return string.Empty;  // Return empty if all items are empty after trimming
            }

            return string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));
        }
    }
}
