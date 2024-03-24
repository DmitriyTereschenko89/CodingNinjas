namespace Perfect_Team
{
	public class Solution
	{
		public int PerfectTeam(int[] ages, int[] skills, int n)
		{
			(int, int)[] child = new (int, int)[n];
			for (int i = 0; i < n; ++i)
			{
				child[i] = (ages[i], skills[i]);
			}
			Array.Sort(child, (a, b) => a.Item1 == b.Item1 ? a.Item2.CompareTo(b.Item2) : a.Item1.CompareTo(b.Item1));
			int[] dp = new int[n];
			for (int i = 0; i < n; ++i)
			{
				dp[i] = child[i].Item2;
				for (int j = 0; j < i; ++j)
				{
					if (child[i].Item2 >= child[j].Item2)
					{
						dp[i] = Math.Max(dp[i], dp[j] + child[i].Item2);
					}
				}
			}
			return dp.Max();
		}
	}
}
