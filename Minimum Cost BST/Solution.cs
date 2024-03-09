using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Cost_BST
{
	public class Solution
	{
		public int MinCostBST(int[] arr, int[] freq)
		{
			int n = arr.Length;
			int[] pre = new int[n];
			pre[0] = freq[0];
			for (int i = 1; i < n; ++i)
			{
				pre[i] = freq[i] + pre[i - 1];
			}
			int[,] dp = new int[n, n];
			for (int j = 0; j < n; ++j)
			{
				for (int i = 0; i < n - j; ++i)
				{
					int k = i + j;
					if (j == 0)
					{
						dp[i, i] = freq[i];
					}
					else if (j == 1)
					{
						int f1 = 2 * freq[i] + freq[i];
						int f2 = freq[i] + 2 * freq[k];
						dp[i, k] = Math.Min(f1, f2);
					}
					else
					{
						int rem = pre[k] - (i != 0 ? pre[i - 1] : 0);
						int min = int.MaxValue;
						for (int l = i; l < k + 1; ++l)
						{
							int left = l != i ? dp[i, l - 1] : 0;
							int right = l != k ? dp[l + 1, k] : 0;
							min = Math.Min(min, rem + left + right);
						}
						dp[i, k] = min;
					}
				}
			}
			return dp[0, n - 1];
		}
	}
}
