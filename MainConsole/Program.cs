using PalindromeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidParentheses;
using TwoSums2;
using Problem66;

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

            //int[] nums = { 2, 7, 11, 15 };
            //int target = 9;
            //TwoSumsCalculator t = new TwoSumsCalculator();
            //int[] result = t.TwoSums(nums, target);

            //Console.Write("[");
            //for(int i=0;i<result.Length;i++)
            //{
            //    Console.Write(i + ",");
            //}
            //Console.Write("]");

            //Console.ReadLine();

            //Problem58.LastWordLengthFinder obj = new Problem58.LastWordLengthFinder();
            //Console.WriteLine(obj.LengthOfLastWord("   fly me   to   the moon  "));
            //Console.ReadLine();

            //int[] arr = { 1, 3, 5, 6 };
			int[] arr = { 1, 9 };

			PlusOneSolution obj = new PlusOneSolution();
            int[] results = obj.PlusOne(arr);

            
			StringBuilder str = new StringBuilder();
			for (int i = 0; i < results.Length; i++)
			{
				str.Append(results[i]);
			}
			Console.WriteLine(str.ToString());
			Console.ReadLine();


            //Console.WriteLine(SearchInsert(arr, 7));

            //Console.WriteLine(SearchInsert2(arr, 7));


            Console.ReadLine();
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int retIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(Array.IndexOf(nums, target) > 0)
                {
                    retIndex = Array.IndexOf(nums, target);
                    break;
                }
                if (nums[i] == target)
                {
                    retIndex = i;
                    break;
                }
                else
                {
                    if (nums[i] > target)
                    {
                        retIndex = i;
                        break;
                    }
                    if((target > nums[i] && i == (nums.Length - 1)))
                    {
                        retIndex = (i + 1);
                        break;
                    }
                }
            }

            return retIndex;
        }

        public static int SearchInsert2(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int i = 0,
                j = nums.Length - 1;

            while (i <= j)
            {
                int m = j + (i - j) / 2;

                if (nums[m] == target)
                    return m;
                else if (nums[m] < target)
                    i = m + 1;
                else
                    j = m - 1;
            }

            return i;
        }
    }
}
