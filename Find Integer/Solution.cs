namespace Find_Integer
{
	public class Solution
	{
		public int FindInteger(int n, int k)
		{
			int m = n % 2 == 0 ? n / 2 : n / 2 + 1;
			return m >= k ? 2 * k - 1 : 2 * (k - m);
		}
	}
}
