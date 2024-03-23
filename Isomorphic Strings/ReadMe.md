# Isomorphic Strings

## Problem statement
You have been given two strings, `str1` and `str2`.
Your task is to return true if the given two strings are isomorphic to each other, else return false.

## Note :
Two strings are isomorphic if a one-to-one mapping is possible for every character of the first string ‘str1’ to every character of the second string ‘str2’ while preserving the order of the characters.
All occurrences of every character in the first string ‘str1’ should map to the same character in the second string, ‘str2’.

## For example :
If str1 = “aab” and str2 = “xxy” then the output will be 1. ‘a’ maps to ‘x’ and ‘b’ maps to ‘y’.
If str1 = “aab” and str2 = “xyz” then the output will be 0. There are two different characters in 'str1', while there are three different characters in 'str2'. So there won't be one to one mapping between 'str1' and 'str2'.

## Detailed explanation ( Input/output format, Notes, Images )
## Sample Input 1 :
aab 
xxy
## Sample Output 1 :
1
Explanation of sample input 1:
The character ‘a’ maps to ‘x’ and ‘b’ maps to ‘y’. Hence, the answer is 1 in this case.
## Sample Input 2 :
aab
xyz
## Sample Output 2 :
0
Constraints :
1 <= |str1|, |str2| <= 10^3

|str1| is the length of the string str1, and |str2| is the length of the string str2.
Follow Up:
Can you solve this in O(N) time?