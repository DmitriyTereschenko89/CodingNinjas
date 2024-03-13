using Ninja_And_Stops;

Solution solution = new();
int tests = int.Parse(Console.ReadLine());
List<int> answers = [];
for (int t = 0; t < tests; t++)
{
	string[] datas = Console.ReadLine().Trim().Split(" ");
	int target = int.Parse(datas[0]);
	int length = int.Parse(datas[1]);
	int startFuel = int.Parse(datas[2]);
	int[][] stations = new int[length][];
	for (int i = 0; i < length; ++i)
	{
		string[] station = Console.ReadLine().Trim().Split(" ");
		int distance = int.Parse(station[0]);
		int availableFuel = int.Parse(station[1]);
		stations[i] = [distance, availableFuel];
	}
    answers.Add(solution.MinRefuelStops(target, startFuel, stations));
}
Console.WriteLine(string.Join("\n", answers));