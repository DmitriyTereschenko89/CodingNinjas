# Maximize xor

## Problem statement
You have an integer array ‘A’ of the form of [x, x+1, x+2, x+3, …….]. As the array is vast in size, you are given both endpoints of the array, i.e., If you are given two integers, ‘L’ and ‘R’, the array ‘A’ will be [L, L+1, L+2, ……., R-1, R]. Your task is to find the maximum possible value of ‘X’ such that the following two conditions hold.
`a ⊕ b = X`, where ⊕ denotes bitwise xor operation.
Both numbers ‘a’ and ‘b’ belong to the array ‘A’.
## Detailed explanation ( Input/output format, Notes, Images )
Constraints -
1 <= 'T' <= 10^3
1 <= 'L' <= 'R' <= 10^9

Time Limit: 1 sec
## Sample Input 1 :
2
8 20
1 3
## Sample Output 1 :
31
3
Explanation for Sample Input 1 :
For case 1:
The array looks like [8, 9, 10, ….., 18, 19, 20]. From all possible pairs (a, b), pair (15, 16) gives maximum value of xor, which is 15 ⊕ 16 = 31.

For Case 2:
Optimal pair is (2, 3), which gives 2 ⊕ 3 = 3.
## Sample Input 2 :
2
4 10
4 7
## Sample Output 2 :
15
3