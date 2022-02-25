using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Common
{
    public class Utility
    {
        public static TreeNode CreateTree(int?[] arr)
        {
            if (arr == null || arr.Length == 0) return null;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            int count = 0;

            TreeNode node = new TreeNode((int)arr[count]);
            TreeNode root = node;
            queue.Enqueue(node);
            while(queue.Count > 0)
            {
                var cur = queue.Peek();
                queue.Dequeue();
                cur.left = (++count >= arr.Length || arr[count] == null) ? null : new TreeNode((int)arr[count]);
                if (cur.left != null) queue.Enqueue(cur.left);
                cur.right = (++count >= arr.Length || arr[count] == null) ? null : new TreeNode((int)arr[count]);
                if (cur.right != null) queue.Enqueue(cur.right);
            }

            return root;
        }

    }
}
