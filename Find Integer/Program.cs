using Find_Integer;

int tests = int.Parse(Console.ReadLine());
List<int> ans = [];
Solution solution = new();
for (int t = 0; t < tests; t++)
{
	string[] datas = Console.ReadLine().Trim().Split(' ');
	ans.Add(solution.FindInteger(int.Parse(datas[0]), int.Parse(datas[1])));
}
Console.WriteLine(string.Join(", ", ans));