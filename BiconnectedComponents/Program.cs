using Biconnected_Components;

int[][] edges = new int[][]
{
	new int[] { 4, 4 },
	new int[] { 1, 3 },
	new int[] { 1, 2 },
	new int[] { 2, 3 },
	new int[] { 3, 4 }
};
int[][] edges1 = new int[][]
{
	new int[] { 1, 2 },
	new int[] { 1, 3 },
	new int[] { 1, 4 },
	new int[] { 1, 5 },
	new int[] { 2, 6 },
	new int[] { 2, 7 },
	new int[] { 4, 5 },
	new int[] { 7, 6 }
};
Solution solution = new();
Console.WriteLine(solution.BiconnectedComponents(4, 5, edges));
Console.WriteLine(solution.BiconnectedComponents(4, 5, edges1));