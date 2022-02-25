using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QTree
{
    // https://leetcode.com/problems/maximum-binary-tree/
    internal class MaxBinaryTree_654
    {
        public MaxBinaryTree_654()
        {
            var arr = new int[] { 1, 3, 2, 8, 6, 5, 4 };
            Console.Write(this.ConstructMaxBinaryTree(arr).val);
        }

        public TreeNode ConstructMaxBinaryTree(int[] nums)
        {
            if (nums == null) return null;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            for (int i = 0; i < nums.Length; i++)
            {
                TreeNode node = new TreeNode(nums[i]);
                while(stack.Count > 0 && stack.Peek().val < node.val)
                {
                    node.left = stack.Pop();
                }

                if (stack.Count > 0)
                {
                    stack.Peek().right = node;
                }

                stack.Push(node);
            }

            return stack.Count == 0 ? null : stack.Last();
        }
    }
}
