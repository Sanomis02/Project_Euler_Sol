using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

       
    }

    internal class Solution876
    {
        int count;
        public int Count(ListNode head)
        {
            for (ListNode node = head; node != null; node = node.next)
            {
                count++;
            }

            return count;
        }

        public ListNode MiddleNode(ListNode head)
        {
            ListNode midNode = head;
            count = Count(head);

            for (int i = 1; i < (count / 2) + 1; i++)
            {
                midNode = midNode.next;
            }

            return midNode;
        }

    }
}
