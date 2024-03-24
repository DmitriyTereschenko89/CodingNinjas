using Perfect_Team;

int tests = int.Parse(Console.ReadLine().Trim());
Solution solution = new();
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine().Trim());
	string[] ages = Console.ReadLine().Trim().Split(' ');
	string[] skills = Console.ReadLine().Trim().Split(' ');
	int[] age = new int[n];
	int[] skill = new int[n];
	for (int i = 0; i < n; ++i)
	{
		age[i] = int.Parse(ages[i]);
		skill[i] = int.Parse(skills[i]);
	}
	ans.Add(solution.PerfectTeam(age, skill, n));
}
Console.WriteLine(string.Join("\n", ans));