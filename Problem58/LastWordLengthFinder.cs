using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem58
{
    public class LastWordLengthFinder
    {
        public int LengthOfLastWord(string s)
        {
            string[] words = s.Trim().Split(' ');
            return words[words.Length - 1].Length;
        }
    }
}
