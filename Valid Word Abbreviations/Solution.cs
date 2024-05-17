using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Word_Abbreviations
{
	public class Solution
	{
		public bool ValidAbbreviation(string str, string abbr)
		{
			int n = str.Length;
			int m = abbr.Length;
			int i = 0;
			int j = 0;
			for (; i < n && j < m;)
			{
				if (abbr[j] >= '1' && abbr[j] <= '9')
				{
					int num = 0;
					while (j < m && abbr[j] >= '0' && abbr[j] <= '9')
					{
						num = num * 10 + (abbr[j] - '0');
						j += 1;
					}
					i += num;
				}
				else
				{
					if (str[i] != abbr[j])
						return false;
					i += 1;
					j += 1;
				}
			}
			return i == n && j == m;
		}
	}
}
