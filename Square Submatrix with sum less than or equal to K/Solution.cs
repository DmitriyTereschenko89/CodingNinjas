namespace Square_Submatrix_with_sum_less_than_or_equal_to_K
{
	public class Solution
	{
		public int LargestSquareSubmatrix(int[][] mat, int n, int m, int k)
		{
			int[,] pref = new int[n + 1, m + 1];
			for (int r = 0; r <= n; ++r)
			{
				for (int c = 0; c <= m; ++c)
				{
					if (r == 0 || c == 0)
					{
						continue;
					}
					pref[r, c] = mat[r - 1][c - 1] + pref[r - 1, c] + pref[r, c - 1] - pref[r - 1, c - 1];
				}
			}
			int ans = 0;
			for (int r = 1; r <= n; ++r)
			{
				for (int c = 1; c <= m; ++c)
				{
					if (r + ans - 1 > n || c + ans - 1 > m)
					{
						break;
					}
					int lo = ans;
					int hi = Math.Min(n - r + 1, m - c + 1);
					while (lo < hi)
					{
						int mid = (lo + hi + 1) / 2;
						int sum = pref[r + mid - 1, c + mid - 1] + pref[r - 1, c - 1] - pref[r + mid - 1, c - 1] - pref[r - 1, c + mid - 1];
						if (sum <= k)
						{
							lo = mid;
						}
						else
						{
							hi = mid - 1;
						}
					}
					ans = Math.Max(ans, lo);
				}
			}
			return ans * ans;
		}
	}
}
