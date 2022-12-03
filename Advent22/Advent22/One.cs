using System.Linq;

namespace Advent22
{
    public class One
    {
        /// <summary>
        /// Returns the maximal sum of caloris in a single block.
        /// </summary>
        /// 
        /// <returns></returns>
        public int MaxCalories(string [] lines)
        {
            int [] sums = new int [lines.Length];
            int sum = 0;
            int j = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if(lines[i].Length == 0)
                {
                    sums[j++] = sum;
                    sum = 0;
                } else
                {
                    int value;

                    if (int.TryParse(lines[i], out value))
                    {
                        sum += value;
                    }
                }
            }

            return sums.Max();
        }
    }
}