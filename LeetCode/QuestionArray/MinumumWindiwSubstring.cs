using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    // https://leetcode.com/problems/minimum-window-substring/
    internal class MinumumWindiwSubstring
    {
        public MinumumWindiwSubstring()
        {
            Console.WriteLine(MinWindow("ADOBECODEBANC", "ABC"));
        }

        public string MinWindow(string s, string t)
        {
            string res = string.Empty;
            if (s == null || t == null) return res;

            int[] hash = new int[256];
            for (int i = 0; i < t.Length; i++)
            {
                hash[t[i]]++;
            }

            int start = 0, end = 0;
            int count = 0;
            while (end < s.Length)
            {
                if (hash[s[end]] > 0)
                {
                    count++;
                }
                hash[s[end]]--;

                while (count == t.Length)
                {
                    if (res == string.Empty)
                    {
                        res = s.Substring(start, end - start + 1);
                    }
                    else
                    {
                        res = res.Length > end - start + 1 ? s.Substring(start, end - start + 1) : res;
                    }

                    hash[s[start]]++;
                    if (hash[s[start]] > 0)
                    {
                        count--;
                    }
                    start++;
                }

                end++;
            }

            return res;
        }
    }
}
