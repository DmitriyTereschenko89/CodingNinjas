using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Floors
{
	public class Solution
	{
		public int HotelBookings(string[] queries)
		{
			bool[,] booking = new bool[10, 26];
			int coins = 0;
			foreach (string query in queries)
			{
				if (query.Length < 3)
				{
					continue;
				}
				bool isBooking = query[0] == '+';
				int floor = query[1] - '0';
				int room = query[2] - 'A';
				if (isBooking && !booking[floor, room])
				{
					booking[floor, room] = true;
					coins++;
				}
				else
				{
					booking[floor, room] = false;
				}
			}
			return coins;
		}
	}
}
