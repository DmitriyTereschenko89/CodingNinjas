using Strange_Numbers;

int tests = int.Parse(Console.ReadLine());
List<int> ans = [];
Solution solution1 = new();
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	ans.Add(solution1.StrangeNumbers(n));
}
Console.WriteLine(string.Join("\n", ans));