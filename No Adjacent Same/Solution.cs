namespace No_Adjacent_Same
{
	public class Solution
	{
		public bool CheckBits(int n)
		{
			int lastBit = -1;
			while (n != 0)
			{
				int bit = n & 1;
				if (lastBit != -1 && lastBit == bit)
				{
					return false;
				}
				lastBit = bit;
				n >>= 1;
			}
			return true;
		}
	}
}
