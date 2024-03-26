using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicatesfromSortedArray
    {
        public int Me_RemoveDuplicates(int[] nums)
        {            
            List<int> check = new List<int>();
            check.Add(nums[0]); 
            for (int i = 1; i < nums.Length; i++) 
            { 
                if (nums[i] != check[check.Count-1])
                {
                    check.Add(nums[i]);
                }
            }
            for (int i = 1;i < check.Count; i++)
            {
                nums[i] = check[i]; 
            }
            int k = check.Count;
            return k;
        }
        public int RemoveDuplicates(ref int[] nums)
        {
            int j = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;
        }
    }
}
