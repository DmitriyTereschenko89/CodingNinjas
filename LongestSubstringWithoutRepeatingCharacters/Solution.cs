namespace Longest_Substring_Without_Repeating_Characters
{
	public class Solution
	{
		public static int UniqueSubstrings(string input)
		{
			int leftLongestIdx = 0;
			int rightLongestIdx = 0;
			int leftIdx = 0;
			int[] map = new int[26];
			Array.Fill(map, -1);
			for (int i = 0; i < input.Length; ++i)
			{
				if (map[input[i] - 'a'] != -1)
				{
					leftIdx = Math.Max(leftIdx, map[input[i] - 'a'] + 1);
				}
				if (rightLongestIdx - leftLongestIdx < i - leftIdx + 1)
				{
					rightLongestIdx = i + 1;
					leftLongestIdx = leftIdx;
				}
				map[input[i] - 'a'] = i;
			}
			return rightLongestIdx - leftLongestIdx;
		}
	}
}
