namespace Minimum_Time_in_Wormhole_Network
{
	public class Wormhole
	{
		public readonly int startX;
		public readonly int startY;
		public readonly int endX;
		public readonly int endY;
		public readonly int cost;

		public Wormhole(int startX, int startY, int endX, int endY, int cost)
		{
			this.startX = startX;
			this.startY = startY;
			this.endX = endX;
			this.endY = endY;
			this.cost = cost;
		}
	}
}
