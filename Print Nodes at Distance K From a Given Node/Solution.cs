namespace Print_Nodes_at_Distance_K_From_a_Given_Node
{
    public class Solution
	{
		private void CreateGraph(BinaryTreeNode<int> node, BinaryTreeNode<int> parent, Dictionary<BinaryTreeNode<int>, List<BinaryTreeNode<int>>> adj)
		{
			if (node == null)
			{
				return;
			}
			if (!adj.ContainsKey(node))
			{
				adj.Add(node, []);
			}
			if (parent != null)
			{
				adj[node].Add(parent);
			}
			if (node.left != null)
			{
				adj[node].Add(node.left);
			}
			if (node.right != null)
			{
				adj[node].Add(node.right);
			}
			CreateGraph(node.left, node, adj);
			CreateGraph(node.right, node, adj);
		}

		public List<BinaryTreeNode<int>> printNodesAtDistanceK(BinaryTreeNode<int> root, BinaryTreeNode<int> target, int K)
		{
			List<BinaryTreeNode<int>> ans = [];
			Dictionary<BinaryTreeNode<int>, List<BinaryTreeNode<int>>> adj = [];
			HashSet<BinaryTreeNode<int>> visited = [];
			CreateGraph(root, null, adj);
			Queue<BinaryTreeNode<int>> q = [];
			q.Enqueue(target);
			visited.Add(target);
			while (q.Count > 0)
			{
				for (int i = q.Count; i > 0; i--)
				{
					BinaryTreeNode<int> node = q.Dequeue();
					if (K == 0)
					{
						ans.Add(node);
						continue;
					}
					foreach (BinaryTreeNode<int> next in adj[node])
					{
						if (!visited.Contains(next))
						{
							visited.Add(next);
							q.Enqueue(next);
						}
					}
				}
				--K;
			}
			foreach(BinaryTreeNode<int> node in ans)
			{
                Console.WriteLine(node.data);
            }
			return ans;
		}
	}
}
