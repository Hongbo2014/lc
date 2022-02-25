using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    // https://leetcode.com/problems/remove-element/
    // 
    internal class RemoveElement_27
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0) return 0;

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index++] = nums[i];
                }
            }

            return index;
        }
    }
}
