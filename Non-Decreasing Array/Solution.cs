namespace Non_Decreasing_Array
{
	public class Solution
	{
		public bool IsPossible(int[] arr, int n)
		{
			bool isChange = false;
			for (int i = 0; i < arr.Length - 1; ++i)
			{
				if (arr[i] <= arr[i + 1])
				{
					continue;
				}
				if (isChange)
				{
					return false;
				}
				if (i == 0 || arr[i - 1] <= arr[i + 1])
				{
					arr[i] = arr[i + 1];
				}
				else
				{
					arr[i + 1] = arr[i];
				}
				isChange = true;
			}
			return true;
		}
	}
}
