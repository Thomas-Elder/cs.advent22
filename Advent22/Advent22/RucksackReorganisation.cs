
namespace Advent22
{
    public class RucksackReorganisation
    {

        public int SumDuplicateItemPriorities(string[] lines)
        {
            return 0;
        }

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
