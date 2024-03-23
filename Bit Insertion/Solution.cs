namespace Bit_Insertion
{
	public class Solution
	{
		public int BitInsertion(int x, int y, int a, int b)
		{
			int mask = (1 << (b - a + 1)) - 1;
			mask <<= a;
			x &= ~mask;
			return (x | (y << a));
		}
	}
}