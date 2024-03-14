namespace GCD_Sum
{
	public class Solution
	{
		private int GCD(int a, int b)
		{
			while ((a % b) > 0)
			{
				int rem = a % b;
				a = b;
				b = rem;
			}
			return b;
		}

		public int GCDSum(int n)
		{
			int ans = 0;
			for (int a = 1; a <= n; ++a)
			{
				for (int b = a + 1; b <= n; ++b)
				{
					ans += GCD(a, b);
				}
			}
			return ans;
		}
	}
}
