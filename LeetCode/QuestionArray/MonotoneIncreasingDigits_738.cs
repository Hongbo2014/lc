using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    internal class MonotoneIncreasingDigits_738
    {
        public MonotoneIncreasingDigits_738()
        {
            Console.WriteLine(MonotoneIncreasingDigit(10));
            Console.WriteLine(MonotoneIncreasingDigit(332));
            Console.WriteLine(MonotoneIncreasingDigit(1234));
            Console.WriteLine(MonotoneIncreasingDigit(1324));
            Console.WriteLine(MonotoneIncreasingDigit(8));
            Console.WriteLine(MonotoneIncreasingDigit(214748364));
        }

        public int MonotoneIncreasingDigit(int n)
        {
            if (n < 0) return -1;
            if (n < 9) return n;

            var val = n.ToString().ToArray();

            int start = val.Length;
            for (int i = val.Length - 1; i >= 1; i--)
            {
                if (val[i] < val[i - 1])
                {
                    val[i - 1]--;
                    start = i;
                }
            }

            if (start == val.Length) return n;

            for (int i = start; i < val.Length; i++)
            {
                val[i] = '9';
            }

            return int.Parse(new string(val));
        }
    }
}
