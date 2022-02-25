using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    internal class StringCompression_443
    {
        public StringCompression_443()
        {
            char[] arr = "aabbbbbbbbbbbbbbbbbb".ToArray();
            this.Compress(arr);
        }

        public int Compress(char[] chars)
        {
            if (chars == null || chars.Length == 0) return 0;

            int count = 0;
            int right = 0;
            int left = 0;
            int len = 0;
            while (right < chars.Length)
            {
                // value equal.
                if (chars[right] == chars[left])
                {
                    count++;
                    right++;
                }

                if (right == chars.Length || chars[right] != chars[left])
                {
                    if (count == 1)
                    {
                        chars[len++] = chars[left]; // ?
                    }
                    else
                    {
                        int index = 0;
                        chars[len++] = chars[left];
                        string str = count.ToString();
                        while (index < str.Length)
                        {
                            chars[len++] = str[index++];
                        }
                    }
                    count = 0;
                    left = right;
                }
            }

            return len + count;
        }
    }
}
