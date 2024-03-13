using Remove_a_node_from_BST;

//TreeNode root = new(10, new(5, new(2), new(6)), new(15));
TreeNode root = new(5);
Solution solution = new();
List<int> nodes = [];
TreeNode newRoot = solution.RemoveNode(root, 2);
TraverseTree(newRoot, nodes);
Console.WriteLine(string.Join(", ", nodes));

static void TraverseTree(TreeNode root, List<int> arr)
{
	if (root is null)
	{
		return;
	}
	TraverseTree(root.left, arr);
	arr.Add(root.val);
	TraverseTree(root.right, arr);
}