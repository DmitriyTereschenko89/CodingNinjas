/*1 2 3 4 5 -1
6 7 8 9 10 -1
-1
3 4 5 7 -1
5 4 3 7 9 -1
4 3 -1
Sample Output 1 :
1 7 3 9 5 
6 2 8 4 10
4 7 
3 5
5 3 3 9 
4 4 7*/
using Interweave_Nodes;

Node head1 = new(1, new(2, new(3, new(4, new(5)))));
Node head2 = new(6, new(7, new(8, new(9, new(10)))));

Solution solution = new();
List<Node> nodes = solution.InterweaveNodes(head1, head2);
