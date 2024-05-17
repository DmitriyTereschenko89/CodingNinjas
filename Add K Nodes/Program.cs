using Add_K_Nodes;

Solution solution = new();
Node head1 = new(1, new(2, new(3, new(4, new(5, new(6, new(7)))))));
Node head2 = new(0, new(6, new(1, new(5))));
Node newHead1 = solution.GetListAfterAddingNodes(head1, 3);
Node newHead2 = solution.GetListAfterAddingNodes(head2, 2);
while (newHead1 != null)
{
    Console.Write(newHead1._data + " ");
    newHead1 = newHead1._next;
}
Console.WriteLine();
while (newHead2 != null)
{
    Console.Write(newHead2._data + " ");
    newHead2 = newHead2._next;
}
Console.WriteLine();