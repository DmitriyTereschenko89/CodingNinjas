using Find_All_Sub_Square_Of_Size_K;


Solution solution = new();
int tests = int.Parse(Console.ReadLine());
for (int t = 0; t < tests; t++)
{
	string[] datas = Console.ReadLine().Trim().Split(" ");
	int n = int.Parse(datas[0]);
	int k = int.Parse(datas[1]);
	int[][] arr = new int[n][];
	for (int r = 0; r < n; ++r)
	{
		string[] nums = Console.ReadLine().Trim().Split(" ");
		arr[r] = new int[n];
		for (int c = 0; c < n; ++c)
		{
			arr[r][c] = int.Parse(nums[c]);
		}
	}
	var res = solution.SumOfKxKMatrices(arr, k);
	for (int r = 0; r < res.Length; ++r)
	{
		Console.WriteLine(string.Join(", ", res[r]));
	}
}