namespace Four_Divisors
{
	public class Solution
	{
		private DivisorInfo GetDivisorInfo(int num)
		{
			int i = 1;
			List<int> divisors = [];
			int sumDivisors = 0;
			while (i * i <= num)
			{
				if (num % i == 0)
				{
					divisors.Add(i);
					sumDivisors += i;
					if (i != num / i)
					{
						sumDivisors += num / i;
						divisors.Add(num / i);
					}
				}
				++i;
			}
			return new(divisors, sumDivisors);
		}

		public int SumFourDivisors(int[] arr, int n)
		{
			int ans = 0;
			for (int i = 0; i < n; ++i)
			{
				DivisorInfo divisorInfo = GetDivisorInfo(arr[i]);
				if (divisorInfo.divisors.Count == 4)
				{
					ans += divisorInfo.sumDivisors;
				}
			}
			return ans;
		}
	}
}
