using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Remove_Element
    {
        public int RemoveElement_test1(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;

            List<int> list = new List<int>();
            foreach (int i in nums)
            {
                if(i != val)
                    list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                nums[i] = list[i];
            }            
            return list.Count;
        }
        public int RemoveElement_test2(ref int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            int k = 0;
            int j = nums.Length - 1;
            for (int i = 0; i < nums.Length && i <= j; ) 
            {
                if (nums[i] != val)
                {
                    k++;
                    i++;
                }
                else
                {
                    if (nums[i] == nums[j])
                    {
                        j--;
                    }
                    else
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        j--;
                    }
                }
            }
            return k;
        }
    }
}
