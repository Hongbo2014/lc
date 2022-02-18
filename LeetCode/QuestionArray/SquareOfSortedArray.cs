using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    internal class SquareOfSortedArray
    {
        public SquareOfSortedArray()
        {
            int[] arr = {-4, -1, 0, 3, 10};
            SortedSquares(arr);
        }

        public int[] SortedSquares(int[] nums)
        {
            //if (nums == null || nums.Length == 0) return nums;

            //Array.Sort(nums, (a, b) =>
            //{
            //    return Math.Abs(a) - Math.Abs(b);
            //});

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = nums[i] * nums[i];
            //}

            //return nums;

            if (nums == null || nums.Length == 0) return nums;

            int minPos = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) < Math.Abs(nums[minPos]))
                {
                    minPos = i;
                }
            }

            int left = 1, right = 1;
            int[] res = new int[nums.Length];
            res[0] = nums[minPos] * nums[minPos];
            for (int i = 1; i < nums.Length; i++)
            {
                int l = minPos - left;
                int r = minPos + right;
                if (l >= 0 && r < nums.Length)
                {
                    if (Math.Abs(nums[l]) <= Math.Abs(nums[r]))
                    {
                        res[i] = nums[l] * nums[l];
                        left++;
                    }
                    else
                    {
                        res[i] = nums[r] * nums[r];
                        right++;
                    }
                }
                else if (l < 0)
                {
                    res[i] = nums[r] * nums[r];
                    right++;
                }
                else
                {
                    res[i] = nums[l] * nums[l];
                    left++;
                }
            }

            return res;
        }
    }
}
