using Non_overlapping_Intervals;

Solution solution = new();
List<int> ans = [];
int tests = int.Parse(Console.ReadLine());
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	int[][] intervals = new int[n][];
	for (int i = 0; i < n; ++i)
	{
		string[] works = Console.ReadLine().Trim().Split(' ');
		int start = int.Parse(works[0]);
		int end = int.Parse(works[1]);
		intervals[i] = [start, end];
	}
	ans.Add(solution.MinimumReschedules(n, intervals));
}
Console.WriteLine(string.Join("\n", ans));