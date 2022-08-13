using PalindromeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidParentheses;
using TwoSums2;

namespace MainConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Palindrome p = new Palindrome();
            //Console.WriteLine("Enter any number");
            //int num = int.Parse(Console.ReadLine());
            //bool result = p.IsPalindrome(num);
            //Console.WriteLine("Number {0} is palindrome: {1}", num, result);
            //Console.ReadLine();

            //ValidateParentheses v = new ValidateParentheses();
            //Console.WriteLine("Enter any string");
            //string str = Console.ReadLine();
            //bool result = v.IsValid(str);
            //Console.WriteLine("String has valid parentheses = {0}", result);

            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            TwoSumsCalculator t = new TwoSumsCalculator();
            int[] result = t.TwoSums(nums, target);

            Console.Write("[");
            for(int i=0;i<result.Length;i++)
            {
                Console.Write(i + ",");
            }
            Console.Write("]");

            Console.ReadLine();
        }
    }
}
