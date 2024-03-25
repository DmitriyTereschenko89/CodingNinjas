namespace Chocolate_Bar
{
	public class Solution
	{
		private int DFS(int[][][] dp, int n, int m, int k)
		{
			if (k == 0 || k == n * m)
			{
				return 0;
			}
			if (k < 0 || k > n * m)
			{
				return int.MaxValue;
			}
			if (dp[n][m][k] != -1)
			{
				return dp[n][m][k];
			}
			int ans = int.MaxValue;
			for (int i = 1; i < n; ++i)
			{
				int area = i * m;
				int cost = m * m + Math.Min(DFS(dp, i, m, k), DFS(dp, n - i, m, k - area));
				ans = Math.Min(ans, cost);
			}
			for (int j = 1; j < m; ++j)
			{
				int area = j * n;
				int cost = n * n + Math.Min(DFS(dp, n, j, k), DFS(dp, n, m - j, k - area));
				ans = Math.Min(ans, cost);
			}
			dp[n][m][k] = ans;
			return ans;
		}
		public List<int> ChocolateBar(int q, List<int> n, List<int> m, List<int> k)
		{
			List<int> ans = [];
			int[][][] dp = new int[51][][];
			for (int i = 0; i <= 50; ++i)
			{
				dp[i] = new int[51][];
				for (int j = 0; j <= 50; ++j)
				{
					dp[i][j] = new int[51];
					for (int l = 0; l <= 50; ++l)
					{
						dp[i][j][l] = -1;
					}
				}
			}
			for (int i = 0; i < q; ++i)
			{
				ans.Add(DFS(dp, n[i], m[i], k[i]));
			}
			return ans;
		}
	}
}
