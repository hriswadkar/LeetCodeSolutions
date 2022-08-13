using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSums2
{
    public class TwoSumsCalculator
    {
        /// <summary>This method calculates and return indices of the two numbers such that they add up to target. This code is solution for leet code challenge 1 (Easy)</summary>
        /// <param name="nums">The nums.</param>
        /// <param name="target">The target.</param>
        /// <returns>It returns an array that contains the two adjacent indices that totals upto the target value</returns>
        public int[] TwoSums(int[] nums, int target)
        {
            System.Collections.Generic.List<int> res = new System.Collections.Generic.List<int>();

            for(int i=0;i<nums.Length;i++)
            {
                for(int j=i+1;j<nums.Length;j++)
                {
                    int temp = nums[i] + nums[j];
                    if(temp == target)
                    {
                        res.Add(i);
                        res.Add(j);
                    }
                }
            }

            return res.ToArray();
        }
    }
}
