namespace Add_K_Nodes
{
    internal class Solution
    {
        public Node GetListAfterAddingNodes(Node head, int k)
        {
            int count = 1;
            int sumKNodes = 0;
            Node prev = null;
            Node node = head;
            while (node != null)
            {
                prev = node;
                sumKNodes += node._data;
                if (count % k == 0)
                {
                    Node newNode = new(sumKNodes);
                    Node next = node._next;
                    node._next = newNode;
                    newNode._next = next;
                    node = next;
                    sumKNodes = 0;
                }
                else
                {
                    node = node._next;
                }

                ++count;
            }

            if (sumKNodes > 0)
            {
                prev._next = new(sumKNodes);
            }

            return head;
        }
    }
}
