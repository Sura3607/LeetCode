using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length-1;
            int mid = 0;
            while (l < r)
            {
                mid = (l+r)/2;               
                if (nums[mid] < target)
                    r = mid - 1;
                else if (nums[mid] > target)
                    l = mid + 1;
                else
                    return mid;
            }
            return r + 1;
        }

    }
}
