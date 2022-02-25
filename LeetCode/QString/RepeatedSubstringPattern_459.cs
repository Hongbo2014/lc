using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QString
{
    public class RepeatedSubstringPattern_459
    {
        public RepeatedSubstringPattern_459()
        {
            this.RepeatedSubstringPattern("babbabbabbabbab");
        }
        public bool RepeatedSubstringPattern(string s)
        {
            if (s == null || s.Length <= 1) return false;

            for (int i = s.Length / 2; i >= 1; i--)
            {
                if (s.Length % i != 0) continue;

                int len = s.Length / i;
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < len; j++)
                {
                    sb.Append(s.Substring(0, i));
                }

                if (sb.ToString() == s)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
