public class Solution
{
    public ListNode? DeleteMiddle(ListNode head)
    {
        if (head.next is null)
        {
            return null;
        }
        
        var slow = head;
        var fast = head.next;

        while (fast?.next?.next is not null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;
        return head;
    }
}