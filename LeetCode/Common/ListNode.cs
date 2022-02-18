namespace LeetCode
{
    public class ListNode
    {
        public int val { get; set; }

        public ListNode next { get; set; } = null;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
