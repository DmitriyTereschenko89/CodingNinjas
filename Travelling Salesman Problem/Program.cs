using Travelling_Salesman_Problem;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	int[][] distances = new int[n][];
	for (int i = 0; i < n; ++i)
	{
		distances[i] = new int[n];
		string[] nums = Console.ReadLine().Trim().Split(' ');
		for (int j = 0; j < n; ++j)
		{
			distances[i][j] = int.Parse(nums[j]);
		}
	}
	ans.Add(solution.ShortestRoute(distances));
}
Console.WriteLine(string.Join(", ", ans));