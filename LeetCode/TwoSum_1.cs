using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSum_1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            if (nums.Length < 2)
            {
                return result;
            }

            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.ContainsKey(target - nums[i]))
                {
                    if (!set.ContainsKey(nums[i]))
                    {
                        set.Add(nums[i], i);
                    }                    
                } 
                else
                {
                    result[0] = set[target - nums[i]];
                    result[1] = i;
                    break;
                }
            }

            return result;
        }
    }
}
