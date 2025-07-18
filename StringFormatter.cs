using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{
    public static class StringFormatter // static class with static method
    {
        // Returns a comma-separated string, wrapping each item in the given quote.
        // Example: Input: ["table", "pen"] with quote ''' => Output: 'table', 'pen'
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            StringBuilder qry = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

            if (items.Length > 1)
            {
                for (int i = 1; i < items.Length; i++)
                {
                    qry.Append(string.Format(", {0}{1}{0}", quote, items[i]));
                }
            }

            return qry.ToString();
        }
    }
}
