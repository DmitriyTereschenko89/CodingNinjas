using GCD_Sum;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	ans.Add(solution.GCDSum(n));
}
Console.WriteLine(string.Join(", ", ans));