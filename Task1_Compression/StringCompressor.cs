using System.Text;
using System.Text.RegularExpressions;

namespace Task1_Compression
{
    public static class StringCompressor
    {
        public static string Compress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            StringBuilder result = new StringBuilder();
            int count = 1;

            for (int i = 1; i <= input.Length; i++)
            {
                if (i < input.Length && input[i] == input[i - 1])
                    count++;
                else
                {
                    result.Append(input[i - 1]);
                    if (count > 1)
                        result.Append(count);
                    count = 1;
                }
            }

            return result.ToString();
        }

        public static string Decompress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            StringBuilder result = new StringBuilder();
            Regex regex = new Regex(@"([a-z])(\d*)");

            foreach (Match match in regex.Matches(input))
            {
                char symbol = match.Groups[1].Value[0];
                int count = string.IsNullOrEmpty(match.Groups[2].Value) ? 1 : int.Parse(match.Groups[2].Value);
                result.Append(new string(symbol, count));
            }

            return result.ToString();
        }
    }
}
