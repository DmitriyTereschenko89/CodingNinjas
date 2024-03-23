using Bit_Insertion;

int tests = int.Parse(Console.ReadLine());
List<int> ans = [];
Solution solution = new();
for (int t = 0; t < tests; t++)
{
	string[] nums = Console.ReadLine().Trim().Split(' ');
	int x = int.Parse(nums[0]);
	int y = int.Parse(nums[1]);
	int a = int.Parse(nums[2]);
	int b = int.Parse(nums[3]);
	ans.Add(solution.BitInsertion(x, y, a, b));
}
Console.WriteLine(string.Join(", ", ans));