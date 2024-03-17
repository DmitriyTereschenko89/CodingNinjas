using Take_Away_The_Bottle;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	string[] nums = Console.ReadLine().Trim().Split(" ");
	int[] arr = new int[n];
	for (int i = 0; i < n; ++i)
	{
		arr[i] = int.Parse(nums[i]);
	}
	ans.Add(solution.TakeAwayTheBottle(arr, n));
}
Console.WriteLine(string.Join(", ", ans));