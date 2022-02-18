using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QuestionArray
{
    internal class BackspaceStringCompare
    {
        public bool BackspaceCompare(string s, string t)
        {
            if (s == null && t == null) return true;
            if (s == null || t == null) return false;

            Stack<char> s1 = RenderArray(s);
            Stack<char> s2 = RenderArray(t);
            if (s1.Count != s2.Count) return false;

            while(s1.Count != 0)
            {
                if (s1.Pop() != s2.Pop()) return false; 
            }

            return true;
        }

        private Stack<char> RenderArray(string str)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '#')
                {
                    if (stack.Count > 0) stack.Pop();
                }
                else
                {
                    stack.Push(str[i]);
                }
            }

            return stack;
        }
    }
}
