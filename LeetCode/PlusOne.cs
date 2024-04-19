using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PlusOne
    {
        public int[] Plusone(int[] digits)
        {
            for (int i = digits.Length -1; i >= 0; i--)
            {
                if (digits[i] + 1 != 10)
                {
                    digits[i] = digits[i] +1;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }            
            int[] newdigits = new int[digits.Length + 1];
            newdigits[0] = 1;               
            return newdigits;                     
        }
    }
}
