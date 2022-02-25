using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    // https://leetcode.com/problems/minimum-size-subarray-sum/
    internal class MininumSizeSum
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int start = 0, end = 0;
            int minLen = int.MaxValue;

            long res = 0;
            while (end < nums.Length)
            {
                res += nums[end++];

                while (res > target && start < end)
                {
                    minLen = minLen > end - start ? end - start : minLen;
                    res -= nums[start++];
                }
            }

            return minLen == int.MaxValue ? 0 : minLen;
        }
    }
}
