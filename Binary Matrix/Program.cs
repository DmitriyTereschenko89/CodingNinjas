using Binary_Matrix;
using System.Text;

Solution solution = new();
int tests = int.Parse(Console.ReadLine());
List<string> answers = [];
for (int t = 0; t < tests; t++)
{
	string[] datas = Console.ReadLine().Trim().Split(" ");
	int n = int.Parse(datas[0]);
	int m = int.Parse(datas[1]);
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
	int[][] res = solution.FindNearestZero(mat);
	StringBuilder stringBuilder = new();
	foreach (int[] row in res)
	{
		stringBuilder.AppendLine(string.Join(", ", row));
	}
	answers.Add(stringBuilder.ToString());
}
Console.WriteLine(string.Join("\n", answers));