# Perfect Team

## Problem statement
You have been given ‘SKILL’ and ‘AGE’ of ‘N’ players. You want to choose the team with the highest total skill. The total skill is the sum of skills of all players in the team. However, in a team, no two players must exist such that the younger player has greater skill than the older player. In a team, two people of the same age can have different skill levels. Return the highest total skill of the team which is possible.

## Example:
Let’s say the age of players is [1,2,6,4] and the skill of players is [1,2,3,4]. We cannot take all players in the team as 3rd player is older than 4th player but 4th player has strictly greater skill than 3rd player. Therefore we can take anyone among them. Therefore the highest total skill of team which is possible is 7.

## Constraints:
1 <= T <= 10
1 <= N <= 100
1 <= ‘AGE[i]’ <= 10^3
1 <= ‘SKILL[i]’ <= 10^6

Time Limit: 1 sec
## Sample Input 1:
2
4
1 2 3 4
1 2 3 4  
5
1 2 3 4 5
1 1 2 1 2
## Sample Output 1:
10
6
Sample Output 1 Explanation:
Test case 1:

We can take all the players as the player with greater age has greater skill.

Therefore the answer is 10.

Test case 2:

We can either take 3rd or 4th player as both of them cannot be part of the same team as the 3rd player is younger and has a greater skill. We will prefer 3rd player as we need maximum total skill.

Therefore the answer is 6.
## Sample Input 2:
2
4
1 2 6 4
1 2 3 4
4
1 2 3 4
4 3 2 1
## Sample Output 2:
7
4