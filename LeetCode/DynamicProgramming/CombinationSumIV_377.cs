using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DynamicProgramming
{
    internal class CombinationSumIV_377
    {
        // https://leetcode.com/problems/combination-sum-iv/

        public CombinationSumIV_377()
        {
            var arr = new int[] { 1, 2 };
            combinationSum4(arr, 3);
        }

        public int combinationSum4(int[] nums, int target)
        {
            int[] dp = new int[target + 1];
            dp[0] = 1;
            for (int i = 0; i <= target; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i >= nums[j])
                    {
                        dp[i] += dp[i - nums[j]];
                    }
                }
            }

            return dp[target];
        }
    }
}
