using Four_Divisors;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	string[] nums = Console.ReadLine().Trim().Split(' ');
	int[] arr = new int[n];
	for (int i = 0; i < n; ++i)
	{
		arr[i] = int.Parse(nums[i]);
	}
	ans.Add(solution.SumFourDivisors(arr, n));
}
Console.WriteLine(string.Join("\n", ans));