# Possible Words From A Phone Number

## Problem statement
After years of research, Ninja is finally able to invent the time machine, and now he is back to the good old days when T9 keypads were being used in mobile phones.
Being a curious person, Ninja wants to find out all possible strings that can be formed by pressing the keys of the phone.
Formally, you are given a string S, that consists of digits from 2-9 (both inclusive), your task is to find out all the possible strings that can be formed from the input string by mapping the digits to the letters as in a T9 keypad. Then, print the strings in a lexicographically sorted order.

## For Example:
If S = “34”, then all the possible letters that can be formed from string S are {“dg”, “dh”, “di”, “eg”, “eh”, “ei”, “fg”, “fh”, “fi”}.
Detailed explanation ( Input/output format, Notes, Images )
## Constraints:
1 <= T <= 10
1 <= |S| <= 7
where |S| denotes the length of the string S.

Time limit: 1 sec.
## Sample Input 1:
1
5

## Sample Output 1:
j k l
Explanation for sample 1:
For the first test case, the words that can be formed from the string S are {“j”, “k”, “l”}.

## Sample Input 2:
2
37
79
Sample Output 2:
dp dq dr ds ep eq er es fp fq fr fs
pw px py pz qw qx qy qz rw rx ry rz sw sx sy sz
Explanation for sample 2:
For the first test case, the words that can be formed from the string S are  {“dp”, “dq”, “dr”, “ds”, “ep”, “eq”, “er”, “es”, “fp”, “fq”, “fr”, “fs”}.

For the second test case, the words that can be formed from the string S is are {“pw”, “px”, “py”, “pz”, “qw”, “qx”, “qy”, “qz”, “rw”, “rx”, “ry”, “rz”, “sw”, “sx”, “sy”, “sz”}.