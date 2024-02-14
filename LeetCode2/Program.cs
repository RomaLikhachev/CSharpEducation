using System.Numerics;

https: //leetcode.com/problems/add-two-numbers/

var result = new Solution().AddTwoNumbers(
    new ListNode(2, new ListNode(4, new ListNode(3))),
    new ListNode(5, new ListNode(6, new ListNode(4)))
);

var node = result;
while (node.next != null)
{
    Console.WriteLine(node.val);
    node = node.next;
}


/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
// Входные данные: l1 = [2,4,3], l2 = [5,6,4]
// Выходные данные: [7,0,8]
// Объяснение: 342 + 465 = 807.
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var oneNum = GetNumFromListNode(l1);
        var twoNum = GetNumFromListNode(l2);
        var sum = oneNum + twoNum;

        var reversedChars = sum.ToString().ToCharArray().Reverse().ToList();

        // 807
        // 708
        ListNode? latestNode = null;
        for (int index = reversedChars.Count - 1; index >= 0; index--)
        {
            var value = int.Parse(reversedChars[index].ToString());
            if (latestNode == null)
            {
                latestNode = new ListNode(value);
            }
            else
            {
                var tempNode = new ListNode(value, latestNode);
                latestNode = tempNode;
            }
        }

        return latestNode;
    }

    private BigInteger GetNumFromListNode(ListNode node)
    {
        var values = "";
        var nextNode = node;
        while (nextNode != null)
        {
            values += nextNode.val;
            nextNode = nextNode.next;
        }

        var charArray = values.ToCharArray();
        Array.Reverse(charArray);
        var reverseValues = new string(charArray);

        return BigInteger.Parse(reverseValues);
    }
}

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}