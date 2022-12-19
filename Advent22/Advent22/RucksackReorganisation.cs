
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

            foreach (string line in lines)
            {

            }

            return 0;
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
    }
}
