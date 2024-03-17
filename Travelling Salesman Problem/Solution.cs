using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_Salesman_Problem
{
	public class Solution
	{
		private int TCP(int[][] dp, int[][] distances, int start, int mask)
		{
			int n = distances.Length;
			if (mask == (1 << n) - 1)
			{
				return distances[start][0];
			}
			if (dp[start][mask] != -1)
			{
				return dp[start][mask];
			}
			int ans = int.MaxValue;
			for (int nextCity = 0; nextCity < n; ++nextCity)
			{
				if ((mask & (1 << nextCity)) == 0)
				{
					int newMask = mask | (1 << nextCity);
					ans = Math.Min(ans, distances[start][nextCity] + TCP(dp, distances, nextCity, newMask));
				}
			}
			dp[start][mask] = ans;
			return ans;
		}

		public int ShortestRoute(int[][] distance)
		{
			int n = distance.Length;
			int[][] dp = new int[n][];
			for (int i = 0; i < n; ++i)
			{
				dp[i] = new int[1 << n];
				Array.Fill(dp[i], -1);
			}
			return TCP(dp, distance, 0, 1);
		}
	}
}
