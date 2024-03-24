using Program_to_check_the_validity_of_a_Password;

int tests = int.Parse(Console.ReadLine().Trim());
Solution solution = new();
List<string> ans = [];
for (int t = 0; t < tests; t++)
{
	string str = Console.ReadLine().Trim();
	ans.Add(solution.IsValid(str) ? "Valid" : "Not Valid");
}
Console.WriteLine(string.Join("\n", ans));