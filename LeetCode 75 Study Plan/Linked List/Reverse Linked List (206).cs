public class Solution
{
    public ListNode? ReverseList(ListNode? head)
    {
        if (head is null)
        {
            return null;
        }
        
        var stack = new Stack<ListNode>();

        while (head is not null)
        {
            stack.Push(head);
            head = head.next;
        }

        var reversedListHead = stack.Pop();
        var currentNode = reversedListHead;
        
        while (stack.Count > 0)
        {
            var nextNode = stack.Pop();
            currentNode.next = nextNode;
            currentNode = nextNode;
            currentNode.next = null;
        }

        return reversedListHead;
    }
}