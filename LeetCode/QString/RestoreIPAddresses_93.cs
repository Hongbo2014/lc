using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QString
{
    /// <summary>
    /// https://leetcode.com/problems/restore-ip-addresses/
    /// </summary>
    internal class RestoreIPAddresses_93
    {
        private IList<string> res = new List<string>();
        public IList<string> RestoreIpAddresses(string s)
        {
            if (s == null || s.Length < 4) return res;

            BackTrack(s, 1, "");

            return res;
        }

        private void BackTrack(string s, int index, string cur)
        {
            if (index == 4)
            {
                if (ValidSection(s))
                {
                    res.Add(cur + "." + s);
                }
                return;
            }

            for (int i = 1; i <= 3 && i < s.Length; i++)
            {
                var subStr = s.Substring(0, i);
                if (!ValidSection(subStr)) continue;
                BackTrack(s.Substring(i), index + 1, subStr);
            }
        }

        private bool ValidSection(string s)
        {
            if (s == null || s.Length == 0) return false;

            int val = 0;

            int.TryParse(s, out val);
            return val >= 0 && val <= 255 && val.ToString() == s;
        }
    }
}
