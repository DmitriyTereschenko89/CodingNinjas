using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja_And_Stops
{
	public class Solution
	{
		public int MinRefuelStops(int target, int startFuel, int[][] stations)
		{
			if (target <= startFuel)
			{
				return 0;
			}
			Heap queue = new();
			int i = 0;
			int stops = 0;
			int n = stations.Length;
			while (startFuel < target)
			{
				while (i < n && stations[i][0] <= startFuel)
				{
					queue.Push(stations[i][1]);
					++i;
				}
				if (queue.IsEmpty())
				{
					return -1;
				}
				startFuel += queue.Pop();
				++stops;
			}
			return stops;
		}
	}
}
