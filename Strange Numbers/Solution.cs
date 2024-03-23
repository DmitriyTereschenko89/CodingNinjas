namespace Strange_Numbers
{
	public class Solution
	{
		private bool IsValid(int num)
		{
			int reverseNum = 0;
			int val = num;
			while (val != 0) 
			{
				int digit = val % 10;
				if (digit == 6)
				{
					digit = 9;
				}
				else if (digit == 9)
				{
					digit = 6;
				}
				reverseNum = reverseNum * 10 + digit;
				val /= 10;
			}
			return reverseNum != num;
		}

		private int DFS(int[] arr, int n, int currNumber)
		{
			int answer = 0;
			if (IsValid(currNumber))
			{
				answer += 1;
			}
			foreach (int num in arr)
			{
				int newNumber = currNumber * 10 + num;
				if (newNumber >= 1 && newNumber <= n)
				{
					answer += DFS(arr, n, newNumber);
				}
			}
			return answer;
		}

		public int StrangeNumbers(int n)
		{
			int[] validIntegers = [0, 1, 6, 8, 9];
			return DFS(validIntegers, n, 0);
		}
	}
}
