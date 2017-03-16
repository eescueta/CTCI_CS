using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class Solution234
    {
        //ListNode left;
        public bool PalindromeHelper(ref ListNode left, ListNode right, ref bool isDone)
        {
            if (right.next == null)
            {
                if (left.val == right.val)
                {
                    left = left.next;
                    return true;
                }
                else
                {
                    isDone = true;
                    return false;
                }
            }

            bool b = PalindromeHelper(ref left, right.next, ref isDone);

            if (isDone)
            {
                return b;
            }
            else if (left == right || right.next == left)
            {
                isDone = true;
                return true;
            }
            else if (left.val == right.val)
            {
                left = left.next;
                return true;
            }
            else
            {
                isDone = true;
                return false;
            }
        }

        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            //this.left = head;
            ListNode left = head;
            bool isDone = false;
            return PalindromeHelper(ref left, head, ref isDone);
            //return false;
        }
    }

    class _234
    {
    }
}
