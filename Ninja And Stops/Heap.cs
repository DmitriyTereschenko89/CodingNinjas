using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja_And_Stops
{
	public class Heap
	{
		private readonly List<int> heap;

		private void SiftDown(int cIdx, int eIdx)
		{
			int chOneIdx = cIdx * 2 + 1;
			while (chOneIdx <= eIdx)
			{
				int swapIdx = chOneIdx;
				int chTwoIdx = cIdx * 2 + 2;
				if (chTwoIdx <= eIdx && heap[chTwoIdx] > heap[chOneIdx])
				{
					swapIdx = chTwoIdx;
				}
				if (heap[swapIdx] > heap[cIdx])
				{
					(heap[cIdx], heap[swapIdx]) = (heap[swapIdx], heap[cIdx]);
					cIdx = swapIdx;
					chOneIdx = cIdx * 2 + 1;
				}
				else
				{
					return;
				}
			}
		}

		private void SiftUp(int cIdx)
		{
			int pIdx = (cIdx - 1) / 2;
			while (pIdx >= 0 && heap[pIdx] < heap[cIdx])
			{
				(heap[pIdx], heap[cIdx]) = (heap[cIdx], heap[pIdx]);
				cIdx = pIdx;
				pIdx = (cIdx - 1) / 2;
			}
		}

		public Heap()
		{
			heap = [];
		}

		public void Push(int data)
		{
			heap.Add(data);
			SiftUp(heap.Count - 1);
		}

		public int Pop()
		{
			(heap[0], heap[^1]) = (heap[^1], heap[0]);
			int removed = heap[^1];
			heap.RemoveAt(heap.Count - 1);
			SiftDown(0, heap.Count - 1);
			return removed;
		}

		public bool IsEmpty()
		{
			return heap.Count == 0;
		}
	}
}
