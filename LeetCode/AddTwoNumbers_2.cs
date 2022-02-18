using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class AddTwoNumbers_2
    {
        /*
         * You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, 
         * and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
         * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        */

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            return AddTwoNode(l1, l2, 0);
        }

        private ListNode AddTwoNode(ListNode n1, ListNode n2, int val)
        {
            if (n1 == null && n2 == null)
            {
                return new ListNode(val);
            }

            int sum = (n1 == null ? 0 : n1.val) + (n2 == null ? 0 : n2.val) + val;
            ListNode res = new ListNode(sum % 10);
            if (n1.next != null || n2.next != null || sum / 10 != 0)
            {
                res.next = AddTwoNode(n1?.next, n2?.next, sum / 10);
            }

            return res;
        }

        //private ListNode AddNodeAndVal(ListNode node, int val)
        //{
        //    if (node == null)
        //    {
        //        return new ListNode(val);
        //    }

        //    int sum = node.value + val;
        //    ListNode res = new ListNode(sum % 10);
        //    if (sum / 10 > 0)
        //    {
        //        res.next = AddNodeAndVal(node.next, sum / 10);
        //    }

        //    return res;
        //}
    }
}
