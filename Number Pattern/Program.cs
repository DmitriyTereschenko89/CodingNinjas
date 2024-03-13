using Number_Pattern;

Solution solution = new();
int n = int.Parse(Console.ReadLine());
var ans = solution.NumberPattern(n);
for (int r = 0; r < n; ++r)
{
	Console.WriteLine(string.Join(", ", ans[r]));
}