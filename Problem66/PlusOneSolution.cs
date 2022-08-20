using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem66
{
    public class PlusOneSolution
    {
		public int[] PlusOne(int[] digits)
		{
			for (int i = digits.Length - 1; i >= 0; i--)
			{
				if (digits[i] < 9)
				{
					digits[i]++;
					return digits;
				}

				digits[i] = 0;
			}

			var res = new int[digits.Length + 1];
			res[0] = 1;
			return res;
		}
	}
}
