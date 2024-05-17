namespace Bounded_Blocking_Queue
{
	public class BoundedBlockingQueue
	{
		private readonly Queue<int> _queue;
		private readonly Queue<int> _tempQueue;
		private readonly int _capacity;
		private int currSize;
		private int tempSize;

		public BoundedBlockingQueue(int capacity)
		{
			_capacity = capacity;
			currSize = 0;
			tempSize = 0;
			_queue = new Queue<int>();
			_tempQueue = new Queue<int>();
		}

		public void Enqueue(int val)
		{
			if (currSize < _capacity)
			{
				_queue.Enqueue(val);
				++currSize;
			}
			else
			{
				_tempQueue.Enqueue(val);
			}
			if (tempSize > 0)
			{
				int firstElem = _queue.Dequeue();
				--tempSize;
				--currSize;
				Console.Write($"{firstElem} ");
			}
		}

		public int Dequeue()
		{
			if (currSize == 0)
			{
				++tempSize;
				return -1;
			}
			int firstElem = _queue.Dequeue();
			--currSize;
			if (_tempQueue.Count > 0)
			{
				int blockElem = _tempQueue.Dequeue();
				Enqueue(blockElem);
			}
			return firstElem;
		}

		public int Size()
		{
			return currSize;
		}
	}
}
