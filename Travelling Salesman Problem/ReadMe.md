# Travelling Salesman Problem

## Problem statement
Given a list of cities numbered from 0 to N-1 and a matrix 'DISTANCE' consisting of 'N' rows and 'N' columns denoting the distances between each pair of cities, what is the shortest possible route that visits each city exactly once and returns to the starting city?

Detailed explanation ( Input/output format, Notes, Images )
Constraints :
1 <= T <= 5
2 <= N <= 16
0 <= DISTANCE[i][j] <= 10^9

Time Limit: 1 sec
## Sample Input 1 :
2
4
0 20 42 25
20 0 30 34
42 30 0 10
25 34 10 0
3
0 3 2
3 0 1
2 1 0
## Sample Output 1 :
85
6
Explanation of Sample output 1:
For the first test case, 
The shortest possible route is 0 -> 1 -> 2 -> 3 -> 0 = 20 + 30 + 10 + 25 = 85. 

For the second test case,
The shortest possible route is 0 -> 1 -> 2 -> 0 = 3 + 1 + 2 = 6.
## Sample Input 2:
2
1
5
2
0 2
2 0
## Sample output 2:
5
4