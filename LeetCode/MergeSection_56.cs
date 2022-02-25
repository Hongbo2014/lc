using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSection_56
    {
        public void TryMerge()
        {
            int[][] array = new int[4][];
            array[1] = new int[2] { 1, 3 };
            array[0] = new int[2] { 2, 6 };
            array[2] = new int[2] { 8, 10 };
            array[3] = new int[2] { 15, 18 };

            MergeIntervals(array);

        }

        public List<Section> MergeSection(List<Section> list)
        {
            // [0,1], [1,3]
            if (list == null || list.Count == 1) return list;

            list.Sort((a, b) =>
            {
                return a.start - b.start;
            });

            var result = new List<Section>();
            var current = list[0];
            for (int i = 1; i < list.Count - 1; i++)
            {
                if (current.end < list[i].start)
                {
                    result.Add(current);
                    current = list[i];
                } 
                else
                {
                    current.end = list[i].end;
                }
            }

            result.Add(current);

            return result;
        }

        public int[][] MergeIntervals(int[][] intervals)
        {
            if (intervals == null || intervals.Length <= 1) return intervals;
            Array.Sort(intervals, (a, b) =>
            {
                if (a[0] != b[0])
                {
                    return a[0] - b[0];
                }
                else
                {
                    return a[1] - b[1];
                }
            });

            List<Tuple<int, int>> result = new List<Tuple<int, int>>();
            int start = intervals[0][0];
            int end = intervals[0][1];

            for(int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] > end)
                {
                    result.Add(Tuple.Create(start, end));
                    start = intervals[i][0];
                    end = intervals[i][1];
                }
                else
                {
                    end = intervals[i][1] > end ? intervals[i][1] : end;
                }
            }

            result.Add(Tuple.Create(start, end));

            int[][] array = new int[result.Count][];
            for(int i =0; i < result.Count; i++)
            {
                array[i] = new int[] { result[i].Item1, result[i].Item2 };
            }

            return array;
        }

    }

    public class Section
    {
        public int start;
        public int end;
    }
}
