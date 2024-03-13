using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Possible_Words_From_A_Phone_Number
{
	public class Solution
	{
		public List<string> FindPossibleWords(string s)
		{
			List<string> res = [];
			string[] buttons = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
			int index = 0;
			Queue<string> queue = [];
			queue.Enqueue(string.Empty);
			while (queue.Count > 0)
			{
				string buttonCharacters = buttons[s[index] - '0'];
				for (int qSize = queue.Count; qSize > 0; --qSize)
				{
					string curString = queue.Dequeue();
					foreach (char character in buttonCharacters)
					{
						string newString = curString + character;
						if (newString.Length == s.Length)
						{
							res.Add(newString);
						}
						else
						{
							queue.Enqueue(newString);
						}
					}
				}
				++index;
			}
			return res;
		}
	}
}
