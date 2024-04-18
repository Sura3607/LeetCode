using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LengthOfLastWord
    {
        public int LengthofLastWord(string s)
        {       
            int cout = 0;
            for (int i = s.Length -1; i >= 0; i--)
            {
                if (s[i] == ' ' && cout == 0) continue;
                if (s[i] == ' ') return cout;
                cout++;
            }
            return s.Length;
        }
    }
}
