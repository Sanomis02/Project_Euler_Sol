using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_2206
{
    internal class Solution19
    {
        int count;
        public int Count(ListNode head)
        {
            for(ListNode node = head; node != null; node = node.next)
            {
                count++;
            }

            return count;
        }

        public ListNode RemoveNthFromEnd(ref ListNode head, int n)
        {
            ListNode lo = head;
            ListNode hi = head.next;
            int count = Count(head);

            for(int i = 0; i < count-n-1; i++)
            {
                lo = lo.next;
                hi = hi.next;
            }

            if(count == 1)
            {
                return head = null;
            }
            if(n == count)
            {
                return head = hi;

            }
            if(hi.next != null)
            {
                lo.next = hi.next;
                hi.next = null;
                hi = null;
                return head;
            }
            else
            {
                lo.next = null;
                hi = null;
                return head;
            }

        }

    }
}
