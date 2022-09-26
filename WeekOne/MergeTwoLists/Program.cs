using System;
using static System.Console;
namespace MergeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Definition for singly-linked list.
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
        static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            while (list1.next != null)
            {
                
            }
            return list2;
        }
    }
}