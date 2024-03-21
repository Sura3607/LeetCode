using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidParentheses
    {
        public bool Me_IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            Dictionary<char, char> Check = new Dictionary<char, char>();
            Check['('] = ')';
            Check['['] = ']';
            Check['{'] = '}';
            Stack<char> Stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    Stack.Push(c);
                }
                else
                {
                    if (Stack.Count == 0) return false;
                    char top = Stack.Pop();
                    if (Check[top] != c) return false;
                }
            }
            return Stack.Count() == 0;   //check xem đã lấy hết phần tử trong stack chưa. Hết thì true 
        }
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;
            var leftParens = new[] { '[', '{', '(' };
            var rightParens = new[] { ']', '}', ')' };
            var s2 = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (leftParens.Contains(s[i]))
                {
                    s2.Push(s[i]);

                    continue;
                }

                if (rightParens.Contains(s[i]))
                {
                    if (!s2.Any()) return false;

                    var x = s2.Peek() - s[i];

                    if (x < 0 && x >= -2)
                    {
                        s2.Pop();
                        continue;
                    }
                    return false;
                }
            }

            if (s2.Any()) return false;
            return true;
        }
    }
}
