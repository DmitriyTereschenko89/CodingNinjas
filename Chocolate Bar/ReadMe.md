# Chocolate Bar

## Problem statement
You are given a chocolate bar in the form of a grid consisting of N x M pieces of chocolate. Your task is to take out exactly ‘K’ pieces of chocolate by cutting the chocolate bar either horizontally or vertically. This operation will cost you the square of break length.
## For example: If you have a chocolate bar of size 3x4, then you can cut horizontally and get two bars of the chocolate of size 1x4 and 2x4. The cost of this cut will be 4^2 = 16 or you can cut vertically and get two bars of the chocolate of size 3x1 and 3x3. The cost of this cut will be 3^2 = 9.
You are given ‘Q’ queries and for each query you need to find the minimum cost such that after all the cutting operations, exactly ‘K’ pieces are obtained from a chocolate of dimension N x M.

## Note:

1.You can discard the remaining N x M - K pieces.
2.You do not need to print anything. It has already been taken care of by our driver code. Just implement the given function and return the minimum cost of cutting the chocolate bar to get exactly ‘K’ pieces of chocolate for each query.

## Constraints:
1 <= Q <= 10^4
1 <= N,M <= 30    
1<= K <= min(NxM,50)

Time Limit: 1 sec
## Sample Input 1:
 2
 2 2 1
 2 2 4
## Sample Output 1:
 5
 0
## Explanation for sample input 1:

In the first query, we have a chocolate bar of size 2x2, and we want to take out exactly one chocolate piece. One of the possible ways of doing this is to cut horizontally, which will divide our bar into 2 bars of size 1x2 each. The side length is two due to which we have to add 4 ( 2^2 = 4) to our cost, then we discard one bar and further make a vertical cut on another bar. This time the side length we cut is 1, so our cost will become 5 ( 4 + 1 = 5). Finally, we have 2 bars of 1-1 pieces each; we keep one piece and discard the other.
In the second query, we have a chocolate bar of size 2x2, and we want to take out exactly four chocolate pieces. As this whole bar contains exactly four pieces of chocolate, hence we don’t have to make any cuts, and the cost will remain 0.
## Sample Input 2:
2
3 4 5
6 4 9
## Sample Output 2:
14
25