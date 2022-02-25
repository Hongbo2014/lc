using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QList
{
    ///https://leetcode.com/problems/reverse-linked-list/
    
    internal class ListReverse
    {
        // 1, 2
        // null
        // 1
        // 1, 2, 3, 4

        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode node = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return node;
        }

        public ListNode ReverseList2(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode pre = null;
            ListNode cur = head;

            ListNode next = head.next;
            while(cur != null)
            {
                cur.next = pre;
                pre = cur;
                cur = next;
                next = cur.next;
            }

            return pre;
        }
    }
}
