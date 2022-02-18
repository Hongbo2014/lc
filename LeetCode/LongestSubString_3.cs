using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // Given a string s, find the length of the longest substring without repeating characters.
    internal class LongestSubString_3
    {
        public int LengthOfLongestSubstring(string s)
        {
            // null
            // a
            // aa
            // abab
            // abc
            // abc...esdfjk

            if (s == null || s.Length == 0) return 0;
            int[] arr = new int[256];

            int begin = 0, end = 0;
            int max = 0;
            while (end < s.Length)
            {
                arr[s[end]]++;

                while(end < s.Length && arr[s[end]] > 1)
                {
                    arr[s[begin++]]--;
                }
                end++;

                max = max > end - begin ? max : end - begin;
            }

            return max;
        }
    }
}
