using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QTree
{
    /// <summary>
    /// https://programmercarl.com/%E4%BA%8C%E5%8F%89%E6%A0%91%E7%9A%84%E8%BF%AD%E4%BB%A3%E9%81%8D%E5%8E%86.html#%E4%B8%AD%E5%BA%8F%E9%81%8D%E5%8E%86-%E8%BF%AD%E4%BB%A3%E6%B3%95
    /// </summary>
    internal class TraversalTree
    {
        public IList<int> PreOrderTraversal(TreeNode node)
        {
            IList<int> res = new List<int>();
            if (node == null) return res;

            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(node);
            while(stack.Count > 0)
            {
                var cur = stack.Pop();
                if (cur.right != null)
                {
                    stack.Push(cur.right);
                }

                if (cur.left != null)
                {
                    stack.Push(cur.left);
                }

                res.Add(cur.val);
            }

            return res;
        }

        public IList<int> InOrderTraserval(TreeNode root)
        {
            IList<int> res = new List<int>();
            if (root == null) return res;

            TreeNode node = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while(node != null || stack.Count > 0)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                } 
                else
                {
                    node = stack.Pop();
                    res.Add(node.val);
                    node = node.right;
                }
            }

            return res;
        }

        public IList<int> PostOrderTraserval(TreeNode root)
        {
            IList<int> res = new List<int>();
            if (root == null) return res;

            TreeNode node = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while(node != null || stack.Count > 0)
            {
                //while(node != null)
                //{
                //    stack.Push(node);
                //    if (node.left != null)
                //    {
                //        // keeps going left if left node not null, as left always visit first.
                //        node = node.left;
                //    }
                //    else
                //    {
                //        // go to right anyway if left is null regardless of null or having node, both case can be handle either treat as new tree or empty which will pop back to his root.
                //        node = node.right;
                //    }
                //}

                //TreeNode cur = stack.Pop();
                //res.Add(cur.val);

                //if (stack.Count > 0 && cur == stack.Peek().left)
                //{
                //    // using peek to find current node's right tree, so next iteration can handle right tree.
                //    node = stack.Peek().right;
                //}

                if (node != null)
                {
                    stack.Push(node);
                    if (node.left != null)
                    {
                        node = node.left;
                    }
                    else
                    {
                        // go to right side anyway if left is null regardless of null or having node, both case can be handle either treat as new tree or empty which will pop back to his root.
                        node = node.right;
                    }
                }
                else
                {
                    var cur = stack.Pop();
                    res.Add(cur.val);
                    if (stack.Count > 0 && cur == stack.Peek().left)
                    {
                        // Finish checking for current node. Using peek to find current node's right tree, so next iteration can handle right tree.
                        node = stack.Peek().right;
                    }
                    else
                    {
                        // Otherwise set it to null to visit root as both child finished.
                        node = null;
                    }
                }
            }

            return res;
        }
    }
}
