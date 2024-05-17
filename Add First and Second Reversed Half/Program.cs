using Add_First_and_Second_Reversed_Half;

Node head = new(1, new(2, new(3, new(4, new(5, new(5, new(6)))))));
Solution solution = new();
Node ans1 = solution.AddFirstAndReversedSecondHalf(head);
while (ans1 != null)
{
    Console.Write(ans1._data + " ");
    ans1 = ans1._next;
}
Console.WriteLine();