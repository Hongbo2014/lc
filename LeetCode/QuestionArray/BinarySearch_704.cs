
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    internal class BinarySearch_704
    {
        // https://leetcode.com/problems/binary-search/
        // Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
        // Guidance: https://github.com/youngyangyang04/leetcode-master/blob/master/problems/0704.%E4%BA%8C%E5%88%86%E6%9F%A5%E6%89%BE.md
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;

            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int middle = start + (end - start) / 2;
                if (nums[middle] > target)
                {
                    end = middle - 1;
                }
                else if (nums[middle] < target)
                {
                    start = middle + 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }
    }
}
