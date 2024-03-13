using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Of_Array_Except_Self
{
	public class Solution
	{
		public int[] GetProductArrayExceptSelf(int[] arr)
		{
			int mod = 1000000007;
			int n = arr.Length;
			if (n == 0)
			{
				return [];
			}
			int[] outArr = new int[n];
			outArr[0] = 1;
			for (int i = 1; i < n; ++i)
			{
				outArr[i] = outArr[i - 1] * arr[i - 1] % mod;
			}
			int postFix = 1;
			for (int i = n - 1; i >= 0; --i)
			{
				outArr[i] = outArr[i] * postFix % mod;
				postFix *= arr[i];
			}
			return outArr;
		}
	}
}
