# Walking Robot Simulation

## Problem statement
A robot on an infinite XY-plane starts at point (0, 0) and faces north. The robot can receive one of three possible types of commands (given in the COMMANDS array/list):
1) -2: turn left 90 degrees,
2) -1: turn right 90 degrees, or
3) 1 <= ‘K’ <= 9: move forward K units.
Some of the grid squares are obstacles. The ‘ith’ obstacle is at grid point OBSTACLES[i] = (Xi, Yi).
If the robot would try to move onto them, the robot stays on the previous grid square instead (but still continues following the rest of the route.)
Return the maximum Euclidean distance that the robot will be from the origin squared (i.e. if the distance is 5, return 25).
## Note :
North means +Y direction.
East means +X direction.
South means -Y direction.
West means -X direction.
## For example:

N = 1, M = 0 
COMMANDS = [3], OBSTACLES = []
The final answer would be 9 since it moves 3 steps north.

## Sample Input 1 :
2
1 0
3
2 1
1 4
0 1
## Sample Output 1 :
9
0
Explanation of the Sample Input 1:
For the first test case:

The final answer would be 9 since it moves 3 steps north.

For the second test case:

Since there is an Obstacle at (0,1) therefore the robot does not move and stays at the same position.
## Sample Input 2 :
2
2 1
1 4
1 0
3 1
4 -1 3
1 1
## Sample Output 2 :
25
25