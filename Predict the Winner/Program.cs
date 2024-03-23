using Predict_the_Winner;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
List<int> ans = [];
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	int k = int.Parse(Console.ReadLine());
	ans.Add(solution.PredictTheWinner(n, k));
}
Console.WriteLine(string.Join("\n", ans));