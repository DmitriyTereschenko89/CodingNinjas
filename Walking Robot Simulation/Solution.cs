namespace Walking_Robot_Simulation
{
	public class Solution
	{
		public int RobotSim(List<int> commands, int[][] obstacles)
		{
			HashSet<(int, int)> setObstacles = [];
			for (int r = 0; r < obstacles.Length; ++r)
			{
				setObstacles.Add((obstacles[r][0], obstacles[r][1]));
			}
			int[] distance = [0, 1, 0, -1, 0];
			int ans = 0;
			int d = 0;
			int x = 0;
			int y = 0;
			foreach (int c in commands)
			{
				if (c == -2)
				{
					d = (d + 3) % 4;
				}
				else if (c == -1)
				{
					d = (d + 1) % 4;
				}
				else
				{
					for (int i = 0; i < c; ++i)
					{
						int nx = x + distance[d];
						int ny = y + distance[d + 1];
						if (setObstacles.Contains((nx, ny)))
						{
							break;
						}
						x = nx;
						y = ny;
						ans = Math.Max(ans, x * x + y * y);
					}
				}
			}
			return ans;
		}
	}
}
