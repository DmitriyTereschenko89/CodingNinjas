namespace Isomorphic_Strings
{
	public class Solution
	{
		public bool AreIsomorphic(string str1, string str2)
		{
			if (str1.Length != str2.Length)
			{
				return false;
			}
			int[] m1 = new int[26];
			int[] m2 = new int[26];
			for (int i = 0; i < str1.Length; ++i)
			{
				if (m1[str1[i] - 'a'] != m2[str2[i] - 'a'])
				{
					return false;
				}
				m1[str1[i] - 'a'] = i + 1;
				m2[str2[i] - 'a'] = i + 1;
			}
			return true;
		}
	}
}
