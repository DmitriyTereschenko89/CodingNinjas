using Bounded_Blocking_Queue;

int tests = int.Parse(Console.ReadLine());
int q = int.Parse(Console.ReadLine());
for (int t = 0; t < tests; t++)
{
	int capacity = int.Parse(Console.ReadLine().Trim().Split(' ')[1]);
	BoundedBlockingQueue boundedBlockingQueue = new(capacity);
	for (int i = 0; i < q; ++i)
	{
		string[] cmd = Console.ReadLine().Trim().Split(' ');
		switch(cmd[0])
		{
			case "1":
				boundedBlockingQueue.Enqueue(int.Parse(cmd[1]));
				break;
			case "2":
				Console.Write($"{boundedBlockingQueue.Dequeue()} ");
				break;
			case "3":
				Console.Write($"{boundedBlockingQueue.Size()} ");
				break;
		}
	}
    Console.WriteLine("============");
}