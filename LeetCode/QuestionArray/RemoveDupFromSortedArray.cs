using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    internal class RemoveDupFromSortedArray
    {
        // https://leetcode.com/problems/remove-duplicates-from-sorted-array/submissions/
        public int RemoveDuplicates(int[] nums)
        {
            // null
            // 
            // 1
            // 1, 1
            // 1, 2, 2
            // 1, 1, 1, 2, 2, 3
            // 1, 1, 1... , 3, 4 , 5
            // 1, 2, 3, 4, 5

            if (nums == null || nums.Length == 0) return 0;

            int start = 0, end = 0;

            while (end < nums.Length)
            {
                if (nums[start] == nums[end])
                {
                    end++;
                }
                else
                {
                    nums[++start] = nums[end++];
                }
            }

            return start + 1;
        }
    }
}
