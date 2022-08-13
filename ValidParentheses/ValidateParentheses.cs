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
            int paraCtr1 = 0;
            int paraCtr2 = 0;
            int paraCtr3 = 0;
            foreach (char c in s)
            {
                if(c.Equals('('))
                {
                    paraCtr1++;
                }
                if (c.Equals('['))
                {
                    paraCtr2++;
                }
                if (c.Equals('{'))
                {
                    paraCtr3++;
                }
                if (c.Equals(')'))
                {
                    paraCtr1--;
                }
                if (c.Equals(']'))
                {
                    paraCtr2--;
                }
                if (c.Equals('}'))
                {
                    paraCtr3--;
                }
            }

            if(paraCtr1 == 0 && paraCtr2 == 0 && paraCtr3 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
