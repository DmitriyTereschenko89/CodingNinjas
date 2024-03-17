# Minimum Time in Wormhole Network

## Problem statement
You will be given a starting point (sx, sy) and a destination point (dx, dy) in the two-dimensional coordinate system representing the universe.

Your spacecraft can move only in X(left or right) or Y(up or down) direction, and not in the diagonal direction. To go from one point (x1, y1) to another point (x2, y2), total time taken is |x2 - x1| + |y2 - y1| seconds.

Also, in this two-dimensional system, N wormholes are present. If you go through a wormhole, spacecraft will take some time to travel from the entry of the wormhole to its exit point. You have to find out the minimum time in which you can go from the source to the destination.

What is a Wormhole?

A wormhole is a sort of tunnel that joins distant points in space, or even two universes, via space-time curvature. Theoretically, such a tunnel could be traversed from one point in space to another without actually travelling the distance between them.
Note:
1. Endpoints of all the wormholes are pairwise distinct.
It means if a wormhole starts or ends at the coordinate (x, y) then no other wormhole will start or end from the same coordinate. This holds true for the source and the destination coordinates as well.

2. If your path intersects with the wormhole, your spacecraft won't get sucked into the wormhole.  As soon as you reach the entry/exit point of a wormhole you will come out from the exit/entry point( Wormholes are bi-directional).
Detailed explanation ( Input/output format, Notes, Images )
Constraints :
1 <= Coordinates <= 10^5
1 <= N <= 200
1 <= Wormhole Time <= 10^5

Time Limit: 1 sec
## Sample Input 1:
0 0 10 10
0
## Sample Output 1:
20
## Explanation for Sample Input 1:
As there are no wormhole you will need to go the destination directly so the time taken = |10 - 0| + |10 - 0| = 20.
## Sample Input 2:
0 0 20 20
2
2 2 10 10 5
8 8 16 16 5
## Sample Output 2:
26
## Explanation for Sample Input 2:
First, go from the source to the first wormhole, it will take |2 - 0| + |2 - 0| = 4 unit of time. Since you have reached a starting point of a wormhole your spacecraft will get sucked into it and you will reach (10,10) with the time consumption of 5. So total time till now is 5 + 4 = 9.
Now, from (10,10) go to the start point of second wormhole with the time = |8 - 10| + |8 - 10| = 4. Now using this wormhole you will reach (16,16) with the time  = 5. So total time till now is 9 + 4 + 5 = 18. From here go to the destination with the time = |20 - 16| + |20 - 16| = 8. 
So the total time consumed = 18+8 = 26. You can not reach the destination with the time less than this.