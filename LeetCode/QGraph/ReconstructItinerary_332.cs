using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QGraph
{
    internal class ReconstructItinerary_332
    {

        public ReconstructItinerary_332()
        {
            IList<IList<string>> list = new List<IList<string>>()
            {
                new List<string> {"JFK", "SFO" },
                new List<string> {"JFK", "ATL"},
                new List<string> {"SFO", "ATL"},
                new List<string> {"ATL", "JFK"},
                new List<string> {"ATL", "SFO"}
            };

            FindItinerary(list);
        }

        private IList<string> res = new List<string>();
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            if (tickets == null || tickets.Count < 2) return res;
            var arr = tickets.ToList();
            arr.Sort((f, s) =>
            {
                if (f[0] != s[0]) return string.Compare(f[0], s[0]);
                return f[1].CompareTo(s[1]);
            });
            FindItinerary(arr, new List<string>(), new List<string>());
            return res;
        }

        private void FindItinerary(List<IList<string>> arr, IList<string> list, IList<string> index)
        {
            if (res.Count == 1) return;
            if (arr.Count == 0)
            {
                list.Add(index[1]);
                res = new List<string>(list);
                return;
            }

            int count = arr.Count;
            var cur = new List<string>(list);

            for (int i = 0; i < count; i++)
            {
                if (index.Count > 0 && index[1] != arr[i][0]) continue;

                var temp = arr[i];
                cur.Add(temp[0]);
                arr.RemoveAt(i);
                FindItinerary(arr, cur, temp);
                cur.RemoveAt(cur.Count - 1);
                arr.Insert(i, temp);
            }
        }
    }
}
