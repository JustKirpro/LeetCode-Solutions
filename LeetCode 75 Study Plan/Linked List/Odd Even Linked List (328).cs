public class Solution
{
    public ListNode? OddEvenList(ListNode? head)
    {
        if (head?.next is null)
        {
            return head;
        }
        
        var oddIndexNode = head;
        var evenIndexNode = head.next;
        var tail = evenIndexNode;

        while (evenIndexNode?.next is not null)
        {
            oddIndexNode.next = evenIndexNode.next;
            oddIndexNode = oddIndexNode.next;
            
            evenIndexNode.next = oddIndexNode.next;
            evenIndexNode = evenIndexNode.next;
        }

        oddIndexNode.next = tail;
        return head;
    }
}