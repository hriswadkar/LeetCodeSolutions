using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem35
{
    public class InsertPositionFinder
    {
        public int SearchInsert(int[] nums, int target)
        {
            int retIndex = -1;
            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i] == target)
                {
                    retIndex = i;
                }
                else
                {
                    if(nums[i] > target || (target > nums[i] && i == (nums.Length-1)))
                    {
                        retIndex = (i+1);
                    }
                }
            }

            return retIndex;
        }
    }
}
