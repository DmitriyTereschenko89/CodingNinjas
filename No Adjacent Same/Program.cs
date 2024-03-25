using No_Adjacent_Same;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<bool> ans = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	ans.Add(solution.CheckBits(n));
}
Console.WriteLine(string.Join("\n", ans));