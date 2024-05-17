using Valid_Word_Abbreviations;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<bool> ans = [];
for (int t = 0; t < tests; t++)
{
	string[] parameters = Console.ReadLine().Trim().Split(' ');
	ans.Add(solution.ValidAbbreviation(parameters[0], parameters[1]));
}
Console.WriteLine(string.Join("\n", ans));