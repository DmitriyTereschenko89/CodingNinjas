using Find_Division_Upto_Given_Decimal_Places;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<string> ans = [];
for (int t = 0; t < tests; t++)
{
	string[] nums = Console.ReadLine().Trim().Split(' ');
	int x = int.Parse(nums[0]);
	int y = int.Parse(nums[1]);
	int n = int.Parse(nums[2]);
	ans.Add(solution.FindDivision(x, y, n));
}
Console.WriteLine(string.Join("\n", ans));