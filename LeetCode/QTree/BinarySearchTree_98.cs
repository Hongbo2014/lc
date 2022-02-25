using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QTree
{
    // https://leetcode.com/problems/validate-binary-search-tree/
    internal class BinarySearchTree_98
    {
        public bool IsBinarySearchTree(TreeNode root)
        {
            if (root == null) return true;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode pre = null;

            TreeNode node = root;
            while(node != null || stack.Count > 0)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    var cur = stack.Pop();
                    if (pre == null)
                    {
                        pre = cur;
                    }
                    else
                    {
                        if (cur.val <= pre.val) return false;
                        pre = cur;
                    }

                    node = cur.right;
                }
            }

            return true;
        }
    }
}
