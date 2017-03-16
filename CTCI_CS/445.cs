using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class Solution445
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> l1Stack = new Stack<int>();
            Stack<int> l2Stack = new Stack<int>();

            ListNode l1it = l1;
            ListNode l2it = l2;
            while (l1it != null)
            {
                l1Stack.Push(l1it.val);
                l1it = l1it.next;
            }
            while (l2it != null)
            {
                l2Stack.Push(l2it.val);
                l2it = l2it.next;
            }

            ListNode resHead = null;

            int carry = 0;
            while (l1Stack.Count() > 0 || l2Stack.Count() > 0)
            {
                int a = (l1Stack.Count() > 0) ? l1Stack.Pop() : 0;
                int b = (l2Stack.Count() > 0) ? l2Stack.Pop() : 0;

                ListNode n = new ListNode((a + b + carry) % 10);
                carry = (a + b + carry) / 10;

                n.next = resHead;
                resHead = n;
            }

            if (carry > 0)
            {
                ListNode n = new ListNode(carry);
                n.next = resHead;
                resHead = n;
            }

            return resHead;
        }
    }

    class _445
    {
    }
}
