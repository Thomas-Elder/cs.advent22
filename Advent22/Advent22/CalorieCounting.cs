using System.Linq;

namespace Advent22
{
    public class CalorieCounting
    {
        public void Run()
        {
            string data = @"Data\\CalorieCountingData.txt";

            string[] lines = System.IO.File.ReadAllLines(data);

            var result = MaxCalories(lines, 1);

            Console.WriteLine("Day One - Counting Calories");
            Console.WriteLine("Part one result: {0}", result);
            Console.WriteLine();

            result = MaxCalories(lines, 3);
            Console.WriteLine("Part two result: {0}", result);
            Console.ReadLine();
        }

        /// <summary>
        /// Returns the sum of the largest n sums of consecutive integer values in lines.
        /// </summary>
        /// Takes an array of strings, expected to be parseable as integers. All consecutive 
        /// strings with values are considered grouped together. Each group is summed. The 
        /// n sums with the highest values are then summed and returned. 
        /// <returns></returns>
        public int MaxCalories(string [] lines, int n)
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

            Array.Sort(sums);
            sum = 0;

            for (int i = sums.Length - 1; i > sums.Length - n - 1; i--)
            {
                sum += sums[i];
            }

            return sum;
        }
    }
}