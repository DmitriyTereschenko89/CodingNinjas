namespace Find_Division_Upto_Given_Decimal_Places
{
	public class Solution
	{
		public string FindDivision(int x, int y, int n)
		{
			string num = (x / (decimal)y).ToString();
            int length = num.Length;
			int i = 0;
			while (i < length && num[i] != '.')
			{
				++i;
			}
			++i;
			if (length - i < n)
			{
				for (int j = 0; j < length - (n - i); ++j)
				{
					num += '0';
				}
				return num;
			}
			return num[..i] + num[i..(i + n)];
		}
	}
}
