using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class Solution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode l1It = l1;
            ListNode l2It = l2;

            ListNode resHead = null;
            ListNode resTail = null;

            int carry = 0;

            while (l1It != null || l2It != null)
            {
                // add both nodes
                // only l2
                // only l1

                int a = (l1It != null) ? l1It.val : 0;
                int b = (l2It != null) ? l2It.val : 0;

                ListNode n = new ListNode((a + b + carry) % 10);
                // check for carry
                carry = (a + b + carry) / 10; 

                if (resHead == null)
                {
                    resHead = n;
                    resTail = n;
                }
                else
                {
                    resTail.next = n;
                    resTail = resTail.next;
                }

                if (l1It != null)
                    l1It = l1It.next;
                if (l2It != null)
                    l2It = l2It.next;
            }

            // check for carry
            if (carry > 0)
            {
                ListNode n = new ListNode(carry);
                resTail.next = n;
                resTail = resTail.next;
            }

            return resHead;
        }
    }
}
