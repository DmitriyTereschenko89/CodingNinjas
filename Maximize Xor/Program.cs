using Maximize_Xor;

Solution solution = new();
int tests = int.Parse(Console.ReadLine());
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	string[] range = Console.ReadLine().Trim().Split(' ');
	int L = int.Parse(range[0]);
	int R = int.Parse(range[1]);
	ans.Add(solution.MaxXor(L, R));
}
Console.WriteLine(string.Join(", ", ans));