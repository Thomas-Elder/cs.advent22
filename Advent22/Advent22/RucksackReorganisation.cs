
namespace Advent22
{
    public class RucksackReorganisation
    {
        /// <summary>
        /// Returns the sum of the priority scores of duplicate items in each line.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public int SumDuplicateItemPriorities(string[] lines)
        {
            var priorities = GetPriorities();

            int total = 0;

            foreach (string line in lines)
            {
                var compartments = GetSubString(line);

                foreach(char c in compartments.First())
                {
                    if (compartments.Last().Contains(c))
                    {
                        total += priorities[c];
                        break;
                    }
                }
            }

            return total;
        }

        /// <summary>
        /// Returns the sum of the priority scores of duplicate items in each line.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public int SumDuplicateItemPrioritiesMultipleLines(string[] lines, int numberOfLines)
        {
            var priorities = GetPriorities();

            int total = 0;
            int start = 0;
            int end = start + numberOfLines;

            for (int i = start; i < end; i+=numberOfLines)
            {
                string a = lines[i];
                string b = lines[i + 1];
                string c = lines[i + 2];

                foreach(char ch in a)
                {
                    if (b.Contains(ch) && c.Contains(ch))
                    {
                        total += priorities[ch];
                        break;
                    }
                }

                start = end;
                end = start + numberOfLines;

                if (start >= lines.Length)
                {
                    break;
                }
            }

            return total;
        }

        /// <summary>
        /// Returns a dictionary of alphabetical characters and priority values.
        /// </summary>
        /// Lowercase item types a through z have priorities 1 through 26.
        /// Uppercase item types A through Z have priorities 27 through 52.
        /// <returns></returns>
        public Dictionary<char, int> GetPriorities()
        {
            var dict = new Dictionary<char, int>();

            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int i = 1;

            foreach (char c in chars)
            {
                dict.Add(c, i++);
            }

            return dict;
        }

        /// <summary>
        /// Splits the given string in two, returning an enumerable of the two substrings
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public IEnumerable<string> GetSubString(string str)
        {
            int subStringLength = str.Length / 2;

            return Enumerable.Range(0, str.Length / subStringLength)
                        .Select(i => str.Substring(i * subStringLength, subStringLength));
        }
    }
}
