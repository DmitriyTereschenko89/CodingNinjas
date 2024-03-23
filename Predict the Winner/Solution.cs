namespace Predict_the_Winner
{
	public class Solution
	{
		private int DFS(int n, int k)
		{
			if (n == 1)
			{
				return 0;
			}
			return (DFS(n - 1, k) + k) % n;
		}
		public int PredictTheWinner(int n, int k)
		{
			return DFS(n, k) + 1;
		}
	}
}
