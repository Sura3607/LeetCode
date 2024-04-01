using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindtheIndexoftheFirstOccurrenceinaString
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack == null ) return -1;
            else if (needle == null ) return 0;
            return haystack.IndexOf(needle);
        }
        public int leetcode_StrStr(string haystack, string needle)
        {
            if (haystack.Length == 0)
                return -1;

            if (needle.Length == 0)
                return 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (i + needle.Length > haystack.Length) break;

                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;

                    if (j == needle.Length - 1)
                        return i;
                }
            }

            return -1;
        }
    }
}
