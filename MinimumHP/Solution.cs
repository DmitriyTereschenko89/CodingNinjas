namespace Minimum_HP
{
	public class Solution
	{
		public static int MinimumHp(int n, int m, int[][] board)
		{
			int[][] dp = new int[n][];
			for (int r = 0; r < n; ++r)
			{
				dp[r] = new int[m];
			}
			dp[n - 1][m - 1] = Math.Max(1, 1 - board[n - 1][m - 1]);
			for (int c = m - 2; c >= 0; --c)
			{
				dp[n - 1][c] = Math.Max(1, dp[n - 1][c + 1] - board[n - 1][c]);
			}
			for (int r = n - 2; r >= 0; --r)
			{
				dp[r][m - 1] = Math.Max(1, dp[r + 1][m - 1] - board[r][m - 1]);
			}
			for (int r = n - 2; r >= 0; --r)
			{
				for (int c = m - 2; c >= 0; --c)
				{
					int minOnExit = Math.Min(dp[r + 1][c], dp[r][c + 1]);
					dp[r][c] = Math.Max(1, minOnExit - board[r][c]);
				}
			}
			return dp[0][0];
		}
	}
}
