using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InsertPositionFinder
{
	public static void Main(string[] args)
	{
		int[] nums = { 1, 3, 5, 6 };
		int target = 5;
		InsertPositionFinder finder = new InsertPositionFinder();
		int index = finder.SearchInsert(nums, target);
		Console.WriteLine($"The index of the target {target} is: {index}");
	}

	public int SearchInsert(int[] nums, int target)
	{
		int retIndex = -1;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == target)
			{
				retIndex = i;
			}
			else
			{
				if (nums[i] > target || (target > nums[i] && i == (nums.Length - 1)))
				{
					retIndex = (i + 1);
				}
			}
		}

		return retIndex;
	}
}
