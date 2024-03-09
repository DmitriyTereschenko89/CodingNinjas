namespace Biconnected_Components
{
	public class Solution
	{
		private class Graph
		{
			private readonly int n;
			private int count;
			private int time;
			private readonly List<int>[] adj;

			private void DFS(int[] discoveryTime, int[] low, int[] parent, Stack<(int, int)> st, int u)
			{
				discoveryTime[u] = low[u] = ++time;
				int children = 0;
				foreach (int v in adj[u])
				{
					if (discoveryTime[v] == -1)
					{
						++children;
						parent[v] = u;
						st.Push((u, v));
						DFS(discoveryTime, low, parent, st, v);
						low[u] = Math.Min(low[u], low[v]);
						if ((discoveryTime[u] == 1 && children > 1) || (discoveryTime[u] > 1 && low[v] >= discoveryTime[u]))
						{
							while (st.Peek().Item1 != u && st.Peek().Item2 != v)
							{
								st.Pop();
							}
							st.Pop();
							++count;
						}
					}
					else if (u != parent[u])
					{
						low[u] = Math.Min(low[u], discoveryTime[v]);
						st.Push((u, v));
					}
				}
			}

			public Graph(int n)
			{
				this.n = n;
				adj = new List<int>[n];
				for (int i = 0; i < n; ++i)
				{
					adj[i] = new List<int>();
				}
			}

			public void Add(int u, int v)
			{
				adj[u].Add(v);
				adj[v].Add(u);
			}

			public int BiconnectedComponents()
			{
				count = 0;
				time = 0;
				int[] ds = new int[n];
				int[] low = new int[n];
				int[] parent = new int[n];
				Stack<(int, int)> st = new();
				Array.Fill(ds, -1);
				Array.Fill(low, -1);
				Array.Fill(parent, -1);
				for (int v = 0; v < n; ++v)
				{
					if (ds[v] == -1)
					{
						DFS(ds, low, parent, st, v);
						if (st.Count > 0)
						{
							++count;
							st.Clear();
						}
					}
				}
				return count;
			}
		}

		public int BiconnectedComponents(int n, int m, int[][] edges)
		{
			Graph graph = new(n);
			for (int i = 0; i < m; ++i)
			{
				int u = edges[i][0] - 1;
				int v = edges[i][1] - 1;
				graph.Add(u, v);
			}
			return graph.BiconnectedComponents();
		}
	}
}
