using Print_Nodes_at_Distance_K_From_a_Given_Node;

BinaryTreeNode<int> node1 = new(1);
BinaryTreeNode<int> node2 = new(2);
BinaryTreeNode<int> node3 = new(3);
BinaryTreeNode<int> node4 = new(4);
BinaryTreeNode<int> node5 = new(5);
BinaryTreeNode<int> node6 = new(6);
node1.left = node2;
node1.right = node3;
node2.left = node4;
node2.right = node5;
node4.left = node6;
Solution solution = new();
solution.printNodesAtDistanceK(node1, node5, 3);