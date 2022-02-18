using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueRelated
{
    //// https://leetcode.com/problems/sliding-window-maximum/
    internal class SlidingWindowMax_239
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || k <= 0 || k > nums.Length)
            {
                return new int[0];
            }

            int[] res = new int[nums.Length - k + 1];

            LinkedList<int> dqueue = new LinkedList<int>();
            int start = 0, end = 0;
            while (end < nums.Length)
            {
                while (dqueue.Count > 0 && dqueue.Last.Value < nums[end])
                {
                    dqueue.RemoveLast();
                }
                dqueue.AddLast(nums[end]);

                if (end - start + 1 == k)
                {
                    var val = dqueue.First.Value;
                    if (val == nums[start])
                    {
                        dqueue.RemoveFirst();
                    }

                    res[start++] = val;
                }
                end++;
            }

            return res;
        }
    }
}
