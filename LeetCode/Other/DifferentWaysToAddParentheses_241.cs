using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLC.Other
{
    class DifferentWaysToAddParentheses_241
    {
        // Add hash to improve performance.
        Dictionary<string, IList<int>> dict = new Dictionary<string, IList<int>>();

        public DifferentWaysToAddParentheses_241()
        {
            var res = this.DiffWaysToCompute("2 * 3 - 4 * 5");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public IList<int> DiffWaysToCompute(string expres)
        {
            if (dict.ContainsKey(expres)) return dict[expres];

            IList<int> res = new List<int>();

            for (int i = 0; i < expres.Length; i++)
            {
                var c = expres[i];
                if (c == '+' || c == '-' || c == '*')
                {
                    var part1 = DiffWaysToCompute(expres.Substring(0, i));
                    var part2 = DiffWaysToCompute(expres.Substring(i + 1));

                    foreach (var p1 in part1)
                    {
                        foreach (var p2 in part2)
                        {
                            switch (c)
                            {
                                case '+': res.Add(p1 + p2); break;
                                case '-': res.Add(p1 - p2); break;
                                case '*': res.Add(p1 * p2); break;
                            }
                        }
                    }
                }
            }

            if (res.Count == 0) res.Add(int.Parse(expres));
            dict.Add(expres, res);
            return res;
        }
    }
}
