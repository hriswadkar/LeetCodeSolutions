using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
	public class Palindrome
	{
		public static void Main(string[] args)
		{
			Palindrome number = new Palindrome();
			bool result = number.IsPalindrome(101);
			Console.WriteLine(result);
		}

		public Palindrome()
		{

		}

		public bool IsPalindrome(int x)
		{
			char[] c = x.ToString().ToCharArray();
			Array.Reverse(c);
			string revNum = new string(c);
			if (revNum.Equals(x.ToString()))
			{
				return true;
			}
			return false;
		}
	}
}