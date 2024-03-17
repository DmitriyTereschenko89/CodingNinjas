namespace Maximize_Xor
{
	public class Solution
	{
		public int MaxXor(int L, int R)
		{
			int xor = L ^ R;
			int position = 0;
			while (xor != 0)
			{
				++position;
				xor >>= 1;
			}
			int number = 0;
			for (int p = 0; p < position; ++p)
			{
				number |= (1 << p);
			}
			return number;
		}
	}
}
