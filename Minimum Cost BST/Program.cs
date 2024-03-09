using Minimum_Cost_BST;
/*4
3
1 2 3
10 30 20
2
1 3
50 10
4
1 3 4 6
5 2 1 4
1
1
50
*/

/*
 * 4
9
1 2 4 5 9 11 12 13 17
70 42 60 22 5 37 45 63 24
7
1 3 7 8 9 10 13
40 27 32 29 58 0 11
8
0 1 4 6 9 10 13 14
1 32 13 32 72 33 28 10
6
0 1 4 9 10 11
58 39 40 40 45 23
*/
int[] arr1 = [1, 2, 3];
int[] freq1 = [10, 30, 20];
int[] arr2 = [1, 3];
int[] freq2 = [50, 10];
int[] arr3 = [1, 3, 4, 6];
int[] freq3 = [5, 2, 1, 4];
int[] arr4 = [1];
int[] freq4 = [50];

int[] arr5 = [1, 2, 4, 5, 9, 11, 12, 13, 17];
int[] freq5 = [70, 42, 60, 22, 5, 37, 45, 63, 24];
int[] arr6 = [1, 3, 7, 8, 9, 10, 13];
int[] freq6 = [40, 27, 32, 29, 58, 0, 11];
Solution solution = new();
Console.WriteLine(solution.MinCostBST(arr1, freq1));
Console.WriteLine(solution.MinCostBST(arr2, freq2));
Console.WriteLine(solution.MinCostBST(arr3, freq3));
Console.WriteLine(solution.MinCostBST(arr4, freq4));
Console.WriteLine(solution.MinCostBST(arr5, freq5));
Console.WriteLine(solution.MinCostBST(arr6, freq6));