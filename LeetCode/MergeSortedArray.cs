using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0)
            {
                for (int i = 0; i< n; i++)
                {
                    nums1[i] = nums2[i]; 
                }
                return;
            }
            int[] a = new int[m + n];
            if (m >0 && n > 0)
            {             
                int i = 0, j = 0, k = 0;
                while (i < m && j < n)
                {
                    if ((nums1[i] < nums2[j]))
                    {
                        a[k] = nums1[i];
                        i++;
                    }
                    else
                    {
                        a[k] = nums2[j];
                        j++;
                    }
                    k++;
                }
                while (i < m)
                {
                    a[k] = nums1[i];
                    i++;
                    k++;
                }
                while (j < n)
                {
                    a[k] = nums2[j];
                    j++;
                    k++;
                }
                for (int l = 0; l < m + n; l++)
                {
                    nums1[l] = a[l];
                }
            }

        }
    }
}
