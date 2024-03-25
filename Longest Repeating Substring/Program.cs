using Longest_Repeating_Substring;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	string str = Console.ReadLine();
	int k = int.Parse(Console.ReadLine());
	ans.Add(solution.LongestRepeatingSubstring(str, k));
}
Console.WriteLine(string.Join("\n", ans));