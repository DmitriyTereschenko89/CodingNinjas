using Recover_Tree_from_Pre_Order_traversal;

int tests = int.Parse(Console.ReadLine().Trim());
Solution solution = new();
for (int t = 0; t < tests; t++)
{
	string order = Console.ReadLine().Trim();
	TreeNode root = solution.RecoverFromPreorder(order);
}