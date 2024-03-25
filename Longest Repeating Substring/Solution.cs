namespace Longest_Repeating_Substring
{
	public class Solution
	{
		public int LongestRepeatingSubstring(string str, int k)
		{
			int[] freq = new int[26];
			int maxCount = 0;
			int start = 0;
			int end = 0;
			for (;end < str.Length; end++) 
			{
				++freq[str[end] - 'A'];
				maxCount = Math.Max(maxCount, freq[str[end] - 'A']);
				if (end - start + 1 - maxCount > k)
				{
					--freq[str[start] - 'A'];
					++start;
				}
			}
			return end - start;
		}
	}
}
