using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QTree
{
    internal class LowestCommonAncestor_236
    {
        public LowestCommonAncestor_236()
        {
            int?[] arr = new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 };
            var root = Utility.CreateTree(arr);
            TreeNode p = new TreeNode(5);
            TreeNode q = new TreeNode(4);
            this.LowestCommonAncestor(root, q, p);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null) return null;

            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();

            GetNodeStack(root, p, s1);
            GetNodeStack(root, q, s2);

            if (s1.Count < s2.Count)
            {
                var temp = s1;
                s1 = s2;
                s2 = temp;
            }

            while (s1.Count > s2.Count)
            {
                s1.Pop();
            }

            while (s1.Count > 0)
            {
                var n1 = s1.Pop();
                var n2 = s2.Pop();
                if (n1.val == n2.val)
                {
                    return n1;
                }
            }

            return null;
        }

        private bool GetNodeStack(TreeNode root, TreeNode node, Stack<TreeNode> stack)
        {
            stack.Push(root);
            if (root.val == node.val)
            {
                return true;
            }

            bool left = false, right = false;
            if (root.left != null) left = GetNodeStack(root.left, node, stack);
            if (root.right != null) right = GetNodeStack(root.right, node, stack);
            if (left || right) return true;

            stack.Pop();
            return false;
        }
    }
}
