using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://programmercarl.com/0028.%E5%AE%9E%E7%8E%B0strStr.html#%E5%85%B6%E4%BB%96%E8%AF%AD%E8%A8%80%E7%89%88%E6%9C%AC
    /// </summary>
    internal class KMPAlgorithm
    {
        public KMPAlgorithm()
        {
            Console.WriteLine(this.FindMatchPattern("abcdeabcdeabcdeabcdeabcde", "abcdeabcdeabcdeabcdeabcde"));
            //Console.WriteLine(this.FindMatchPattern("abacabac", "ca"));
            //Console.WriteLine(this.FindMatchPattern("aaaaa", "bba"));
        }
        public int FindMatchPattern(string target, string pattern)
        {
            if (target == null || pattern == null || pattern.Length > target.Length) return -1;

            var next = GetLPSArray(pattern);

            int len = 0;
            for(int i = 0; i < target.Length; i++)
            {
                while(len > 0 && pattern[len] != target[i])
                {
                    len = next[len - 1];
                }

                if (pattern[len] == target[i])
                {
                    len++;
                }

                if (len == pattern.Length)
                {
                    return i - len + 1;
                }
            }

            StringBuilder builder = new StringBuilder();

            return -1;
        }

        private int[] GetLPSArray(string pattern)
        {
            int[] res = new int[pattern.Length];

            int len = 0;
            for(int i = 1; i < pattern.Length; i++)
            {
                while(len > 0 && pattern[i] != pattern[len])
                {
                    len = res[len - 1];
                }

                if (pattern[i] == pattern[len])
                {
                    len++;
                }

                res[i] = len;
            }

            return res;
        }
    }
}
