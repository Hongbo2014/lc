using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QTree
{
    internal class N_ryLevelTraversal_429
    {
        internal class Node
        {
            public int val;
            public IList<Node> children;

            public Node(int _val)
            {
                this.val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                this.val = _val;
                this.children = _children;
            }
        }

        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            this.Traversal(root, res, 0);

            return res;
        }

        private void Traversal(Node node, IList<IList<int>> res, int level)
        {
            if (node == null) return;

            if (level >= res.Count)
            {
                res.Add(new List<int>());
            }

            res[level].Add(node.val);
            foreach (Node child in node.children)
            {
                this.Traversal(child, res, level + 1);
            }
        }
    }
}
