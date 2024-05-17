namespace Boundary_Traversal_of_Binary_Tree
{
    internal class Solution
    {
        private void DFS(BinaryTreeNode node, HashSet<int> arr)
        {
            if (node is null)
            {
                return;
            }

            TraversalLeftBoundary(node._left, arr);
            TraversalLeafNodes(node, arr);
            TraversalRightBoundary(node._right, arr);
        }
        
        private void TraversalLeftBoundary(BinaryTreeNode node, HashSet<int> arr)
        {
            if (node is null || (node._left is null && node._right is null))
            {
                return;
            }

            arr.Add(node._val);
            if (node._left != null)
            {
                TraversalLeftBoundary(node._left, arr);
            }
            else
            {
                TraversalLeftBoundary(node._right, arr);
            }
        }

        private void TraversalRightBoundary(BinaryTreeNode node, HashSet<int> arr)
        {
            if (node is null || (node._left is null && node._right is null))
            {
                return;
            }

            if (node._right != null)
            {
                TraversalRightBoundary(node._right, arr);
            }
            else
            {
                TraversalRightBoundary(node._left, arr);
            }
            arr.Add(node._val);
        }

        private void TraversalLeafNodes(BinaryTreeNode node, HashSet<int> arr)
        {
            if (node is null)
            {
                return;
            }

            TraversalLeafNodes(node._left, arr);
            if (node._left is null && node._right is null)
            {
                arr.Add(node._val);
            }
            TraversalLeafNodes(node._right, arr);
        }

        public List<int> TraverseBoundary(BinaryTreeNode root)
        {
            HashSet<int> arr = [];
            arr.Add(root._val);
            DFS(root, arr);
            return [.. arr];
        }
    }
}
