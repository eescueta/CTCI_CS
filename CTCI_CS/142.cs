using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class Solution142
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;

            ListNode slow = head.next;
            ListNode fast = head.next.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                    return null;

                slow = slow.next;
                fast = fast.next.next;
            }

            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
    }

    class _142
    {
    }
}
