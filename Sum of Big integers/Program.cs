using Sum_of_Big_integers_;

int tests = int.Parse(Console.ReadLine().Trim());
Solution solution = new();
List<string> ans = [];
for (int t = 0; t < tests; t++)
{
	string[] nums = Console.ReadLine().Trim().Split(' ');
	ans.Add(solution.FindSum(nums[0], nums[1]));
}
Console.WriteLine(string.Join("\n", ans));