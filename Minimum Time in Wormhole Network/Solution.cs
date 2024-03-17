namespace Minimum_Time_in_Wormhole_Network
{
	public class Solution
	{
		public int GetMinVertex(int[] distance, bool[] visited, int v)
		{
			int minVertex = -1;
			for (int i = 0; i < v; ++i)
			{
				if (!visited[i] && (minVertex == -1 || distance[i] < distance[minVertex]))
				{
					minVertex = i;
				}
			}
			return minVertex;
		}

		public int MinTimeInWormholeNetwork(int n, int sx, int sy, int dx, int dy, Wormhole[] wormhole)
		{
			int v = 2 * n + 2;
			(int, int)[] vertices = new (int, int)[v];
			int[] wormholeCost = new int[v];
			int[][] adj = new int[v][];
			for (int r = 0; r < v; ++r)
			{
				adj[r] = new int[v];
			}
			int vertexNumber = 0;
			int wormholeNumber = 0;
			vertices[vertexNumber++] = (sx, sy);
			vertices[vertexNumber++] = (dx, dy);
			for (int idx = 0; idx < n; ++idx)
			{
				vertices[vertexNumber++] = (wormhole[idx].startX, wormhole[idx].startY);
				vertices[vertexNumber++] = (wormhole[idx].endX, wormhole[idx].endY);
				wormholeCost[wormholeNumber++] = wormhole[idx].cost;
			}
			for (int idx = 0; idx < vertexNumber; ++idx)
			{
				for (int jdx = idx + 1; jdx < vertexNumber; ++jdx)
				{
					adj[idx][jdx] = Math.Abs(vertices[idx].Item1 - vertices[jdx].Item1) + Math.Abs(vertices[idx].Item2 - vertices[jdx].Item2);
					adj[jdx][idx] = adj[idx][jdx];
				}
			}
			int i = 2;
			int j = 0;
			while (i < vertexNumber && j < wormholeNumber)
			{
				adj[i][i + 1] = wormholeCost[j];
				adj[i + 1][i] = wormholeCost[j];
				i += 2;
				j += 1;
			}
			int[] distance = new int[v];
			Array.Fill(distance, int.MaxValue);
			bool[] visited = new bool[v];
			distance[0] = 0;
			for (i = 0; i < vertexNumber - 1; ++i)
			{
				int minVertex = GetMinVertex(distance, visited, vertexNumber);
				visited[minVertex] = true;
				for (j =0; j < vertexNumber; ++j)
				{
					if (adj[minVertex][j] > 0 && !visited[j])
					{
						if (adj[minVertex][j] + distance[minVertex] < distance[j])
						{
							distance[j] = adj[minVertex][j] + distance[minVertex];
						}
					}
				}
			}
			return distance[1];
		}
	}
}
