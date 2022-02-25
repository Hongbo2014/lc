using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QTree
{
    internal class ConvertBSTtoGreaterTree_538
    {
        public ConvertBSTtoGreaterTree_538()
        {
            int?[] arr = new int?[] {4, 1, 6, 0, 2, 5, 7, null, null, null, 3, null, null, null, 8 };
            var node = Utility.CreateTree(arr);
            this.ConvertBST(node);
        }
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null) return null;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode pre = null;
            TreeNode node = root;

            stack.Push(root);

            while (node != null || stack.Count > 0)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.right;
                }
                else
                {
                    node = stack.Pop();
                    if (pre == null)
                    {
                        pre = node;
                    }
                    else
                    {
                        node.val += pre.val;
                        pre = node;
                    }
                    node = node.left;
                }
            }

            return root;
        }
    }
}
