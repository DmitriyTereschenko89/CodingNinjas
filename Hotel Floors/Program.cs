using Hotel_Floors;

int tests = int.Parse(Console.ReadLine());
List<int> answers = [];
Solution solution = new();
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	string[] queries = Console.ReadLine().Trim().Split(' ');
	answers.Add(solution.HotelBookings(queries));
}
Console.WriteLine(string.Join(", ", answers));