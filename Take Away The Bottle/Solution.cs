namespace Take_Away_The_Bottle
{
	public class Solution
	{
		private int DFS(int[][] dp, int[] arr, int l, int r, int started)
		{
			if (l > r)
			{
				return started;
			}
			if (l == r)
			{
				return 1;
			}
			if (dp[l][r] != -1)
			{
				return dp[l][r];
			}
			int minSteps = 500;
			for (int k = l; k <= r; ++k)
			{
				if (arr[l] == arr[k])
				{
					int curSteps = DFS(dp, arr, l + 1, k - 1, 1) + DFS(dp, arr, k + 1, r, 0);
					minSteps = Math.Min(curSteps, minSteps);
				}
			}
			dp[l][r] = minSteps;
			return minSteps;
		}

		public int TakeAwayTheBottle(int[] arr, int n)
		{
			int[][] dp = new int[501][];
			for (int i =0; i <= 500; ++i)
			{
				dp[i] = new int[501];
				Array.Fill(dp[i], -1);
			}
			return DFS(dp, arr, 0, n - 1, 0);
		}
	}
}
