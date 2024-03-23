namespace Strange_Numbers
{
	public class Solution1
	{
		private bool IsValid(int n)
		{
			int reverse = 0;
			int num = n;
			while (num != 0)
			{
				int digit = num % 10;
				if (digit == 6)
				{
					digit = 9;
				}
				else if (digit == 9)
				{
					digit = 6;
				}
				reverse = reverse * 10 + digit;
				num /= 10;
			}
			return reverse != n;
		}

		public int StrangeNumbers(int n)
		{
			int count = 0;
			int[] arr = [0, 1, 6, 8, 9];
			Queue<int> queue = [];
			queue.Enqueue(0);
			while (queue.Count > 0)
			{
				int curNumber =  queue.Dequeue();
				foreach (int num in arr)
				{
					int newNumber = curNumber * 10 + num;
					if (newNumber >= 1 && newNumber <= n)
					{
						if (IsValid(newNumber))
						{
							++count;
						}
						queue.Enqueue(newNumber);
					}
				}
			}
			return count;
			return count;
		}
	}
}
