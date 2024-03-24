using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Test_ValidParentheses();
            //Test_MergeSortedArray();
            Test_MergeTwoSortedLists();
            Console.ReadLine();
        }
        static void Test_ValidParentheses()
        {
            ValidParentheses validator = new ValidParentheses();

            string test1 = "()"; // true
            string test2 = "()[]{}"; // true
            string test3 = "(]"; // false
            string test4 = "([)]"; // false
            string test5 = "{[]}"; // true

            Console.WriteLine("Test 1: " + validator.Me_IsValid(test1));
            Console.WriteLine("Test 2: " + validator.Me_IsValid(test2));
            Console.WriteLine("Test 3: " + validator.Me_IsValid(test3));
            Console.WriteLine("Test 4: " + validator.Me_IsValid(test4));
            Console.WriteLine("Test 5: " + validator.Me_IsValid(test5));
        }
        static void Test_MergeSortedArray()
        {
            MergeSortedArray test1 = new MergeSortedArray();
            int[] nums1 = { 1, 1, 3, 4, 0, 0 ,0 ,0 ,0 ,0 };
            int m = 4;
            int[] nums2 = { 1, 4, 5, 8, 9, 12 };
            int n = 6;
            test1.Merge(nums1, m, nums2, n);
            for (int i = 0; i < nums1.Length; i++) 
            {
                Console.Write(nums1[i] + ", ");
            }
            Console.WriteLine();
        }
        static void Test_MergeTwoSortedLists()
        {
            MergeTwoSortedLists merger = new MergeTwoSortedLists();

            
            ListNode list1 = new ListNode();
            list1.Insert(1);
            list1.Insert(4);
            list1.Insert(5);
            list1.Insert(6);
            list1.Insert(8);


            ListNode list2 = new ListNode();
            list2.Insert(1);
            list2.Insert(3);
            list2.Insert(4);
            list2.Insert(6);
            list2.Insert(7);
            list2.Insert(12);
            list2.Insert(14);

            // Hợp nhất hai danh sách và in kết quả.
            ListNode mergedList = merger.MergeTwoLists(list1.next, list2.next);
            while (mergedList != null)
            {
                Console.Write(mergedList.val + " ");
                mergedList = mergedList.next;
            }
            Console.WriteLine();
        }
    }
}
