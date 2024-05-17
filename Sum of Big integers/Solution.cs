namespace Sum_of_Big_integers_
{
	public class Solution
    {
        private string AddNum(List<char> l1, List<char> l2)
        {
			int remainder = 0;
			int n = l1.Count;
			int m = l2.Count;
			int i = n - 1;
			int j = m - 1;
			while (i >= 0 || j >= 0)
			{

				int a = i >= 0 ? l1[i] - '0' : 0;
				int b = j >= 0 ? l2[j] - '0' : 0;
				int sum = a + b + remainder;
				int val = sum % 10;
				remainder = sum / 10;
				
				l1[i] = (char)(val + '0');
				--i;
				--j;
			}
			if (remainder > 0)
			{
				l1.Insert(0, (char)(remainder + '0'));
			}
			return string.Join("", l1);
		}

        public string FindSum(string num1, string num2)
        {
			var num1L = num1.ToCharArray().ToList();
			var num2L = num2.ToCharArray().ToList();
			if (num1L.Count > num2L.Count)
			{
				return AddNum(num1L, num2L);
			}
			return AddNum(num2L, num1L);
		}
    }
}