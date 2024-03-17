namespace Find_All_Sub_Square_Of_Size_K
{
	public class Solution
	{
		public int[][] SumOfKxKMatrices(int[][] arr, int k)
		{
			int n = arr.Length;
			int[][] pref = new int[n + 1][];
			for (int i = 0; i <= n; ++i)
			{
				pref[i] = new int[n + 1];
			}
			for (int r = 0; r <= n; ++r)
			{
				for (int c = 0; c <= n; ++c)
				{
					if (r == 0 || c == 0)
					{
						continue;
					}
					pref[r][c] = arr[r - 1][c - 1] + pref[r - 1][c] + pref[r][c - 1] - pref[r - 1][c - 1];
				}
			}
			List<int> ans = [];
			for(int r = k; r <= n; ++r)
			{
				for (int c = k; c <= n; ++c)
				{
					ans.Add(pref[r][c] - pref[r][c - k] - pref[r - k][c] + pref[r - k][c - k]);
				}
			}
			int l = (int)Math.Sqrt(ans.Count);
			int[][] res = new int[l][];
			int index = 0;
			for (int r = 0; r < l; ++r)
			{
				res[r] = new int[l];
				for (int c = 0; c < l; ++c)
				{
					res[r][c] = ans[index++];
				}
			}

			return res;
		}
	}
}
