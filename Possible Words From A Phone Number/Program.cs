using Possible_Words_From_A_Phone_Number;

int tests = int.Parse(Console.ReadLine().Trim());
Solution solution = new();
List<string> result = [];
for (int t = 0; t < tests; ++t)
{
	string s = Console.ReadLine();
	result.Add(string.Join(", ", solution.FindPossibleWords(s)));
}
Console.WriteLine(string.Join("\n", result));