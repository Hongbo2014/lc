using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QTree
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
    /// </summary>
    internal class LevelOrderTraserval_II_107
    {
        IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null) return res;
            LevelTraserval(root, 0);

            return res;
        }

        private void LevelTraserval(TreeNode node, int deep)
        {
            if (node == null) return;

            if (res.Count <= deep)
            {
                IList<int> list = new List<int>();
                res.Insert(0, new List<int>());
            }

            if (node.left != null) LevelTraserval(node.left, deep + 1);
            if (node.right != null) LevelTraserval(node.right, deep + 1);

            res[res.Count - deep - 1].Add(node.val);
        }
    }
}
