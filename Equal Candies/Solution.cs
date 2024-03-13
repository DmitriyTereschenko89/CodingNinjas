namespace Equal_Candies
{
	public class Solution
	{
		public long EqualCandies(int[] candies, int n)
		{
			Array.Sort(candies);
			int ans = 0;
			int m = candies[n / 2];
			for (int i = 0; i < n; ++i)
			{
				ans += Math.Abs(candies[i] - m);
			}
			if (n % 2 == 0)
			{
				m = candies[n / 2 - 1];
				int res = 0;
				for (int i = 0; i < n; ++i)
				{
					res += Math.Abs(candies[i] - m);
				}
				ans = Math.Min(ans, res);
			}
			return ans;
		}
	}
}
