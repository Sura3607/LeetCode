﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
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
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if(list1 != null && list2 == null)
            {
                return list1;
            }
            if (list1 == null && list2 != null)
            {
                return list2;
            }

            ListNode merge = new ListNode();
            ListNode Check = merge;
            while (list1 != null && list2 != null) 
            {
                if (list1.val <= list2.val)
                {
                    Check.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    Check.next = list2;
                    list2 = list2.next;
                }
                Check = Check.next;
            }

            if (list1 != null)
            {
                Check.next = list1 ;
            }
            else
            {
                Check.next = list2 ;
            }
            return merge.next;      
        }
    }
}
