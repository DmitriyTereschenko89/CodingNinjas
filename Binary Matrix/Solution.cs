namespace Binary_Matrix
{
	public class Solution
	{
		public int[][] FindNearestZero(int[][] mat)
		{
			int n = mat.Length;
			int m = mat[0].Length;
			int[][] res = new int[n][];
			Queue<(int, int)> queue = new();
			for (int r = 0; r < n; ++r)
			{
				res[r] = new int[m];
			}
			for (int r = 0; r < n; ++r)
			{
				for (int c = 0; c < m; ++c)
				{
					if (mat[r][c] == 0)
					{
						queue.Enqueue((r, c));
					}
					else
					{
						res[r][c] = int.MaxValue;
					}
				}
			}
			int[] deltaX = [0, -1, 0, 1];
			int[] deltaY = [-1, 0, 1, 0];
			while (queue.Count > 0)
			{
				var (r, c) = queue.Dequeue();
				int time = res[r][c];
				for (int i = 0; i < 4; ++i)
				{
					int nR = r + deltaX[i];
					int nC = c + deltaY[i];
					if (nR >= 0 && nR < n && nC >= 0 && nC < m)
					{
						if (res[nR][nC] == int.MaxValue)
						{
							res[nR][nC] = time + 1;
							queue.Enqueue((nR, nC));
						}						
					}
				}
			}
			return res;
		}
	}
}
