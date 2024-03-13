using Equal_Candies;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<long> answers = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	string[] nums = Console.ReadLine().Trim().Split(" ");
	int[] candies = new int[n];
	for (int i = 0; i < n; ++i)
	{
		candies[i] = int.Parse(nums[i]);
	}
    answers.Add(solution.EqualCandies(candies, n));
}
Console.WriteLine(string.Join("\n", answers));