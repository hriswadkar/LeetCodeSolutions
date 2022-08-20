using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class ValidateParentheses
    {
        public bool IsValid(string s)
        {
            System.Collections.Stack stack = new System.Collections.Stack();

            foreach(char c in s)
            {
                if(c == '(')
                { 
                    stack.Push(c); 
                }
                else if(c == '[')
                {
                    stack.Push(c);
                }
                else if(c == '{')
                {
                    stack.Push(c);
                }

                if(stack.Count == 0)
                {
                    return false;
                }
                else if(c == ')')
                {
                    if(stack.Peek().ToString() == "(")
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(c == ']')
                {
                    if(stack.Peek().ToString() == "[")
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    if (stack.Peek().ToString() == "{")
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
