using Square_Submatrix_with_sum_less_than_or_equal_to_K;

Solution solution = new();
int tests = int.Parse(Console.ReadLine());
List<int> answers = [];
for (int t = 0; t < tests; t++)
{
	string[] datas = Console.ReadLine().Trim().Split(" ");
	int n = int.Parse(datas[0]);
	int m = int.Parse(datas[1]);
	int k = int.Parse(datas[2]);
	int[][] mat = new int[n][];
	for (int r = 0; r < n; ++r)
	{
		mat[r] = new int[m];
		string[] columns = Console.ReadLine().Trim().Split(" ");
		for (int c = 0; c < m; ++c)
		{
			mat[r][c] = int.Parse(columns[c]);
		}
	}
	answers.Add(solution.LargestSquareSubmatrix(mat, n, m, k));
}
Console.WriteLine(string.Join("\n", answers));