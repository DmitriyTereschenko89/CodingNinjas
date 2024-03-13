namespace Number_Pattern
{
	public class Solution
	{
		public List<List<int>> NumberPattern(int n)
		{
			int a = 1;
			int b = n * n + 1;
			List<int> temp = [];
			List<List<int>> ans = [];
			for (int i = 1; i <= n; ++i)
			{
				temp.Clear();
				for (int j = 0; j < n - i + 1; ++j)
				{
					temp.Add(a);
					++a;
				}
				int c = b - 1;
				for (int j = 0; j < n - i + 1; ++j)
				{
					temp.Add(b);
					++b;
				}
				ans.Add(new List<int>(temp));
				b = c - (n - i - 1);
			}
			return ans;
		}
	}
}
