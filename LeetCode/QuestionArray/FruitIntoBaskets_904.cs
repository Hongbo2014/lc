using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    internal class FruitIntoBaskets_904
    {
        public FruitIntoBaskets_904()
        {
            int[] arr = { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 };
            Console.WriteLine(TotalFruit(arr));
        }

        public int TotalFruit(int[] fruits)
        {
            if (fruits == null || fruits.Length == 0) return 0;

            int start = 0, end = 0;
            int max = 0;

            Dictionary<int, int> hash = new Dictionary<int, int>();
            int type = 0;
            while (end < fruits.Length)
            {
                if (!hash.ContainsKey(fruits[end]))
                {
                    hash.Add(fruits[end], 1);
                    type++;
                }
                else if (hash[fruits[end]] == 0)
                {
                    hash[fruits[end]]++;
                    type++;
                }
                else
                {
                    hash[fruits[end]]++;
                }

                while (type >= 3)
                {
                    hash[fruits[start]]--;
                    if (hash[fruits[start]] == 0)
                    {
                        type--;
                    }
                    start++;
                }

                max = max > end - start + 1 ? max : end - start + 1;
                end++;
            }

            return max;
        }
    }
}
