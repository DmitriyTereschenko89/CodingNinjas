using Minimum_Time_in_Wormhole_Network;

string[] coordinates = Console.ReadLine().Trim().Split(' ');
int sx = int.Parse(coordinates[0]);
int sy = int.Parse(coordinates[1]);
int dx = int.Parse(coordinates[2]);
int dy = int.Parse(coordinates[3]);
int n = int.Parse(Console.ReadLine());
Wormhole[] wormholes = new Wormhole[n];
Solution solution = new();
for (int i = 0; i < n; ++i)
{
	string[] wormholedatas = Console.ReadLine().Trim().Split(' ');
	int startX = int.Parse(wormholedatas[0]);
	int startY = int.Parse(wormholedatas[1]);
	int endX = int.Parse(wormholedatas[2]);
	int endY = int.Parse(wormholedatas[3]);
	int cost = int.Parse(wormholedatas[4]);
	wormholes[i] = new Wormhole(startX, startY, endX, endY, cost);
}
Console.WriteLine(solution.MinTimeInWormholeNetwork(n, sx, sy, dx, dy, wormholes));