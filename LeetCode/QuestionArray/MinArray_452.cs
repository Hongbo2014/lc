using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    internal class MinArray_452
    {
        public MinArray_452()
        {
            int[][] arr = new int[][]
            {
                new int[] { -2147483646,-2147483645 },
                new int[] { 2147483646, 2147483647 }
            };

            FindMinArrayShots(arr);
        }

        public int FindMinArrayShots(int[][] points)
        {
            if (points == null || points.Length == 0) return 0;

            Array.Sort(points, (a, b) =>
            {
                if (a[0] == b[0]) return a[1].CompareTo(b[1]);
                return a[0].CompareTo(b[1]);
            });

            int start = points[0][0];
            int end = points[0][1];
            int count = 1;
            for (int i = 1; i < points.Length; i++)
            {
                var xs = points[i][0];
                var xe = points[i][1];
                if (xs > end)
                {
                    start = xs;
                    end = xe;
                    count++;
                } 
                else
                {
                    start = start > xs ? start : xs;
                    end = end < xe ? end : xe;
                }
            }

            return count;
        }
    }
}
