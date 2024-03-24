namespace Recover_Tree_from_Pre_Order_traversal
{
	public class Solution
	{
		public TreeNode RecoverFromPreorder(string s)
		{
			int n = s.Length;
			Stack<TreeNode> st = new();
			for (int i = 0; i < n;)
			{
				int level = 0;
				while (s[i] == '-')
				{
					++level;
					++i;
				}
				int start = i;
				while (i < n && char.IsDigit(s[i]))
				{
					++i;
				}
				int val = int.Parse(s[start..i]);
				TreeNode newNode = new(val);
				while (st.Count > level)
				{
					st.Pop();
				}
				if (st.Count == 0)
				{
					st.Push(newNode);
					continue;
				}
				else if (st.Peek().left == null)
				{
					st.Peek().left = newNode;
				}
				else
				{
					st.Peek().right = newNode;
				}
				st.Push(newNode);
			}
			while (st.Count > 1)
			{
				st.Pop();
			}
			return st.Pop();
		}
	}
}
