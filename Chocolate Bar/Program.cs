using Chocolate_Bar;

Solution solution = new();
int q = int.Parse(Console.ReadLine());
string[][] matrix = new string[q][];
for (int i = 0; i < q; ++i)
{
	matrix[i] = Console.ReadLine().Trim().Split(' ');
}
List<int> n = [];
List<int> m = [];
List<int> k = [];
for (int r = 0; r < q; ++r)
{
	n.Add(int.Parse(matrix[r][0]));
	m.Add(int.Parse(matrix[r][1]));
	k.Add(int.Parse(matrix[r][2]));
}
Console.WriteLine(string.Join("\n", solution.ChocolateBar(q, n, m, k)));