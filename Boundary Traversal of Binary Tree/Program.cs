using Boundary_Traversal_of_Binary_Tree;

BinaryTreeNode root1 = new(10, new(5, left:new(3), right: new(8, left: new(7))), right: new(20, left: new(18), right: new(25)));
BinaryTreeNode root2 = new(100, left: new(50, left: new(25, right: new(30, right: new(35))), right: new(75, left:new(70), right: new(80))), right: new(150, left: new(140), right: new(200)));
Solution solution = new();
Console.WriteLine(string.Join(", ", solution.TraverseBoundary(root1)));
Console.WriteLine(string.Join(", ", solution.TraverseBoundary(root2)));
