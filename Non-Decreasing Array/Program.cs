using Non_Decreasing_Array;

int tests = int.Parse(Console.ReadLine());
List<bool> answers = [];
Solution solution = new();
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	string[] arr = Console.ReadLine().Trim().Split(' ');
	int[] nums = new int[n];
	for (int i = 0; i < n; ++i)
	{
		nums[i] = int.Parse(arr[i]);
	}
	answers.Add(solution.IsPossible(nums, n));
}
Console.WriteLine(string.Join(", ", answers));