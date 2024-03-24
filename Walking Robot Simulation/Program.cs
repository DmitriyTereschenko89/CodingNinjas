using Walking_Robot_Simulation;

int tests = int.Parse(Console.ReadLine().Trim());
List<int> ans = [];
Solution solution = new();
for (int t = 0; t < tests; t++)
{
	string[] sizes = Console.ReadLine().Trim().Split(' ');
	int n = int.Parse(sizes[0]);
	int m = int.Parse(sizes[1]);
	string[] commands = Console.ReadLine().Trim().Split(' ');
	int[][] obstacles = new int[m][];
	for (int r = 0; r < m; ++r)
	{
		string[] arr = Console.ReadLine().Trim().Split(" ");
		int[] obstacle = [int.Parse(arr[0]), int.Parse(arr[1])];
		obstacles[r] = obstacle;
	}
	List<int> cmd = [];
	for (int i = 0; i < n; ++i)
	{
		cmd.Add(int.Parse(commands[i]));
	}
	ans.Add(solution.RobotSim(cmd, obstacles));
}
Console.WriteLine(string.Join("\n", ans));