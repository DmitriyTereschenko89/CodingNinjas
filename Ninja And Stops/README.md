# Ninja And Stops
## Hard
### Problem statement
Ninja wants to travel from his house to a given destination, which is ‘X’ miles from his house. Along the way, he needs to fill gas in his vehicle. He knows there are ‘Y’ stations in his way. He also knows the distance between the station and his house, and how many liters of gas that particular station has.
Ninja starts his journey, with an infinite capacity of the tank filled with ‘Z’ liters of starting fuel. Suppose his vehicle uses 1 liter of gas for every mile, and ninja can stop at any gas station, transfer all the available gas at that station and then move ahead.
Now, you need to find out what is the minimum number of stops Ninja must make to reach his desired destination.

Note:
Note that if Ninja reaches a particular stop with no fuel, it can still fill his tank at that stop and continue his journey ahead. Similarly, if he reaches his destination with no fuel, it is still considered to have arrived.
For example :
Given X = 10, Y = 4, ARR[Y] = {[1, 6], [2, 3], [3, 3], [6, 4]} and Z = 1
So the path followed in this case would look like this:

Ninja starts with 1L of gas. 
Drives to the first gas station at position 1, using 1L of gas, then refueling with 6L of gas.
Then, drive to position 6, using 5L of gas, then refueling 4L in the current 1L of gas, making it a total of 5L of gas.
Finally, drive to the destination consuming 4L of gas.
So, Ninja made 2 refueling stops before reaching the destination. So, you need to print 2. 
Detailed explanation ( Input/output format, Notes, Images )
Constraints:
1 <= T <= 10
1 <= X, Z  <= 10^7
0 <= size of Y <= 10^5
1 <= Y1, Y2 <= 10^7

Time limit: 1 sec
Sample Input 1:
1
10 4 1
1 6
2 3
3 3
6 4
Sample Output 1:
2
Explanation of sample input 1:
In the first test case, 
The path followed, in this case, would look like:

Ninja starts with 1L of gas. 
Drives to the first gas station at position 1, using 1L of gas, then refuelling with 6L of gas.
Then, drive to position 6, using 5L of gas, then refuelling 4L in the current 1L of gas, making it a total of 5L of gas.
Finally, drive to the destination consuming 4L of gas. 
So, Ninja made 2 refuelling stops before reaching the destination. So, you need to print 2. 
Sample Input 2:
2
10 1 1
5 10
2 1 4
1 4
Sample Output 2:
-1
0
Explanation of sample input 2:
In the first test case, 
The path followed, in this case, would look like this:

Ninja starts with 1L of gas. 
Cannot drive to the first stop situated at position 5.
So, Ninja is not able to reach the destination. So, you need to print -1.

In the second test case, 
The path followed, in this case, would look like:

Ninja starts with 4L of gas. 
Reached the target at position 2 without refuelling the tank. So, you need to print 0.
