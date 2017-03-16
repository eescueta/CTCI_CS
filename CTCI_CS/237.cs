using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class Solution237
    {
        public void DeleteNode(ListNode node)
        {
            if (node.next == null)
            {
                node = null;
            }
            else
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
    }

    class _237
    {
    }
}
