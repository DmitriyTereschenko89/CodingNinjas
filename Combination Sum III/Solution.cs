namespace Combination_Sum_III
{
	public class Solution
	{
		private void DFS(int nextDigit, int k, int curSum, int target, List<int> curCombination, List<List<int>> result)
		{
			if (curCombination.Count > k || curSum > target)
			{
				return;
			}

			if (curCombination.Count == k && curSum == target)
			{
				result.Add(new List<int>(curCombination));
				return;
			}

			for (int num = nextDigit; num < 10; ++num)
			{
				curSum += num;
				curCombination.Add(num);
				DFS(num + 1, k, curSum, target, curCombination, result);
				curCombination.RemoveAt(curCombination.Count - 1);
				curSum -= num;
			}
		}
    
		public List<List<int>> CombinationSumIII(int k, int n)
		{
			List<List<int>> result = [];
			DFS(1, k, 0, n, [], result);
			return result;
		}
	
	}
}
