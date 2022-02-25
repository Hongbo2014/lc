using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RegularExpressionMatching_10
    {
        public bool IsMatch(string s, string p)
        {
            if (s == null || p == null) return false;

            bool[,] dp = new bool[s.Length + 1, p.Length + 1];

            dp[0, 0] = true;
            for (int i = 0; i < p.Length; i++)
            {
                // Either an empty pattern p="" or a pattern that can represent an empty string such as p="a*", p="z*" can set to true for first row.
                if (p[i] == '*' && dp[0, i - 1]) dp[0, i + 1] = true;
            }

            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }

                    if (p[j - 1] == '*')
                    {
                        if (s[i - 1] != p[j - 2] && p[j - 2] != '.')
                        {
                            // if char at i - 1 not match with the char before * at string p, then * is represent as 0, dp value will check the value with * and char before him.
                            dp[i, j] = dp[i, j - 2];
                        } 
                        else
                        {
                           //    dp[i][j] = dp[i - 1][j]    //in this case, a* counts as multiple a 
                           // or dp[i][j] = dp[i][j - 1]   // in this case, a* counts as single a
                           // or dp[i][j] = dp[i][j - 2]   // in this case, a* counts as empty
                            dp[i, j] = dp[i, j - 1] || dp[i, j - 2] || dp[i - 1, j];
                        }
                    }
                }
            }

            return dp[s.Length, p.Length];
        }
    }
}
