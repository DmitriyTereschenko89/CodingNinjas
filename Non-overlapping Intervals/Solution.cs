namespace Non_overlapping_Intervals
{
	public class Solution
	{
		public int MinimumReschedules(int n, int[][] intervals)
		{
			Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
			int endWork = intervals[0][1];
			int countWorkers = 0;
			for (int i = 1; i < n; ++i)
			{
				int startWork = intervals[i][0];
				int curEndWork = intervals[i][1];
				if (startWork < endWork)
				{
					++countWorkers;
					endWork = Math.Min(endWork, curEndWork);
				}
				else
				{
					endWork = curEndWork;
				}
			}
			return countWorkers;
		}
	}
}
