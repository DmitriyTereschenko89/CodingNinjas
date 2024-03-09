using Minimum_HP;

int[][] board1 = new int[][]
{
	new int[] { 1, -3,  4 },
	new int[] { -6, -7, 2 },
	new int[] { 15, 20, -4 }
};
int[][] board2 = new int[][]
{
	new int[] { -1, -7, 3, -10 },
	new int[] { 10, -13, 3, -14 },
	new int[] { -13, 6, -6, 9 }
};
int[][] board3 = new int[][]
{
	new int[] { 3, -1, 2, 14, 19 },
	new int[] { -8, -5, 5, -15, -19 },
	new int[] { -9, -10, -5, -18, -8 },
	new int[] { 6, 20, 13, 1, -9 },
	new int[] { 0, 13, 5, 6, -1 }
};
int[][] board4 = new int[][]
{
	new int[] { - 4 }
};
int[][] board5 = new int[][]
{
	new int[] {-3, -19, 28, -22, -25, 1, 2, -28, -19, 4},
	new int[] {0, 28, 12, -1, 5, 24, -2, -11, 12, -7},
	new int[] {4, -26, 28, -11, -6, 3, 3, -17, 6, -22},
	new int[] {27, 20, -23, 11, -28, 20, 28, 14, -19, 28},
	new int[] {-22, 12, -27, 7, -25, 9, 10, -12, -19, 27},
	new int[] {-5, -5, -26, 21, 4, 0, -25, -13, -6, 6},
	new int[] {14, -19, 19, 27, -10, -24, 7, 13, 0, 9},
	new int[] {-10, 15, -22, 13, 29, -30, -14, 1, 4, 7},
	new int[] {-10, 5, -10, 11, -15, -6, 24, -4, -22, 1}
};
Console.WriteLine(Solution.MinimumHp(3, 3, board1));
Console.WriteLine(Solution.MinimumHp(3, 4, board2));
Console.WriteLine(Solution.MinimumHp(5, 5, board3));
Console.WriteLine(Solution.MinimumHp(1, 1, board4));
Console.WriteLine(Solution.MinimumHp(9, 10, board5));