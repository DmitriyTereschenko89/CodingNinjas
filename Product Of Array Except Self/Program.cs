using Product_Of_Array_Except_Self;

Solution solution = new();
int tests = int.Parse(Console.ReadLine());
List<string> answers = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine().Trim());
	int[] arr = new int[n];
	string[] nums = Console.ReadLine().Trim().Split(' ');
	for (int i = 0; i < n; ++i)
	{
		arr[i] = int.Parse(nums[i]);
	}
	answers.Add(string.Join(", ", solution.GetProductArrayExceptSelf(arr)));
}
Console.WriteLine(string.Join("\n", answers));