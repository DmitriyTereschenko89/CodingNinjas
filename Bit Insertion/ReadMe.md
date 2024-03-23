# Bit Insertion

## Problem statement
You are given two 32 bit positive integers 'X' and 'Y', and two positions 'A' and 'B'. Your task is to insert 'Y' into 'X' starting from A’th position to B’th position both inclusive.
Inserting a number is resetting all the bits of 'X' from position 'A' to position 'B' and then writing 'Y' in 'X' starting from index 'A'.
Note : Bit positions are 0 indexed.


## For example :
X = 1536 and Y = 7, A = 1 and B = 5,
X is base 2 = 11000000000, Y in base 2 = 0111
First, we clear all the bits of X from index 1 to index 5 then wrote Y in X starting from A.
After inserting Y in X starting from position result will be 11000001110

## Constraints :
1 <= T <= 5000
1 <= X,Y <= 2^31
0 <= A <= B < 32 

‘X’, ‘Y’, ‘A’, ‘B’ are two given integers and starting bit positions and ending bit position to insert respectively.
It is guaranteed that the position from ‘A’ to  ‘B’ is enough to insert Y.
Time Limit : 1 sec
## Sample Input 1 :
2
1 8 5 15
7 21 11 30
## Sample Output 1 :
257
43015
Explanation of Sample Input 1 :
X and Y in base 2 are (00001), (01000), after clearing all the bits in X from 5’th to 15’th position and inserting Y we get (1000000001)
X and Y in base 2 are (111), (10101), after clearing all the bits in X from 11’th to 30’th position and inserting Y we get (0001010100000000111)
## Sample Input 2 :
2
12143435 564 1 10 
21321454 129 11 30
## Sample Output 2 :
12143721
265966