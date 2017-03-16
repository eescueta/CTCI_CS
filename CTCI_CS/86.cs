using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class Solution86
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode smallHead = null;
            ListNode smallTail = null;
            ListNode bigHead = null;
            ListNode bigTail = null;

            ListNode curr = head;

            while (curr != null)
            {
                // node is smaller
                if (curr.val < x)
                {
                    // inialize smaller portion
                    if (smallHead == null)
                    {
                        smallHead = curr;
                        smallTail = curr;
                    }
                    // add to smaller portion
                    else
                    {
                        smallTail.next = curr;
                        smallTail = smallTail.next;
                    }
                }
                // node is bigger or equal
                else
                {
                    // inialize bigger portion
                    if (bigHead == null)
                    {
                        bigHead = curr;
                        bigTail = curr;
                    }
                    // add to bigger portion
                    else
                    {
                        bigTail.next = curr;
                        bigTail = bigTail.next;
                    }
                }

                curr = curr.next;
            }

            if (bigTail != null)
                bigTail.next = null;

            if (smallHead == null)
                return bigHead;

            smallTail.next = bigHead;
            return smallHead;
        }
    }

    class _86
    {
    }
}
