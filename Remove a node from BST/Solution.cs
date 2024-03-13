namespace Remove_a_node_from_BST
{
	public class Solution
	{
		private int GetSmallest(TreeNode node)
		{
			TreeNode cur = node;
			while (cur.left != null)
			{
				cur = cur.left;
			}
			return cur.val;
		}

		private TreeNode RemoveNode(TreeNode node, TreeNode parentNode, int x)
		{
			TreeNode deletedNode = node;
			while (deletedNode != null)
			{
				if (deletedNode.val == x)
				{
					if (deletedNode.left != null && deletedNode.right != null)
					{
						deletedNode.val = GetSmallest(deletedNode.right);
						RemoveNode(deletedNode.right, deletedNode, deletedNode.val);
					}
					else if (parentNode == null)
					{
						if (deletedNode.left != null)
						{
							deletedNode.val = deletedNode.left.val;
							deletedNode.right = deletedNode.left.right;
							deletedNode.left = deletedNode.left.left;
						}
						else if (deletedNode.right != null)
						{
							deletedNode.val = deletedNode.right.val;
							deletedNode.left = deletedNode.right.left;
							deletedNode.right = deletedNode.right.right;
						}
					}
					else if (parentNode.left == deletedNode)
					{
						parentNode.left = deletedNode.left ?? deletedNode.right;
					}
					else if (parentNode.right == deletedNode)
					{
						parentNode.right = deletedNode.left ?? deletedNode.right;
					}
					break;
				}
				else if (deletedNode.val > x)
				{
					parentNode = deletedNode;
					deletedNode = deletedNode.left;
				}
				else
				{
					parentNode = deletedNode;
					deletedNode = deletedNode.right;

				}

			}
			return node;
		}

		public TreeNode RemoveNode(TreeNode root, int X)
		{
			return RemoveNode(root, null, X);
		}
	}
}
