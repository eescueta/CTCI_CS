using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_CS
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!");
            //int[,] m = { { 0, 1 } };
            //Solution73 a = new Solution73(); ;
            //a.SetZeroes(m);

            ListNode a = new ListNode(1);
            ListNode b = new ListNode(4);
            ListNode c = new ListNode(3);
            ListNode d = new ListNode(2);
            ListNode e = new ListNode(5);
            ListNode f = new ListNode(2);

            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = f;

            Solution86 abc = new Solution86();
            abc.Partition(a, 3);

        }
    }
}
