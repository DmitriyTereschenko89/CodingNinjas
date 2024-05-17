namespace Add_First_and_Second_Reversed_Half
{
    internal class Solution
    {
        private Node ReverseList(Node head)
        {
            Node prev = null;
            Node cur = head;
            while (cur != null)
            {
                Node next = cur._next;
                cur._next = prev;
                prev = cur;
                cur = next;
            }

            return prev;
        }

        public Node AddFirstAndReversedSecondHalf(Node head)
        {
            if (head is null)
            {
                return null;
            }

            Node slow = head;
            Node fast = head;
            while (fast._next != null && fast._next._next != null)
            {
                slow = slow._next;
                fast = fast._next._next;
            }

            Node secondPartHead = slow._next;
            slow._next = null;
            Node firstPartHead = ReverseList(head);
            int remainder = 0;
            Node ans = new();
            Node node = ans;
            while (firstPartHead != null || secondPartHead != null)
            {
                int data1 = firstPartHead?._data ?? 0;
                int data2 = secondPartHead?._data ?? 0;
                int sum = data1 + data2 + remainder;
                int insertedValue = sum % 10;
                remainder = sum / 10;
                node._next = new(insertedValue);
                node = node._next;
                firstPartHead = firstPartHead?._next ?? null;
                secondPartHead = secondPartHead?._next ?? null;
            }

            if (remainder > 0)
            {
                node._next = new(remainder);
            }

            Node sumNode = ReverseList(ans._next);
            while (sumNode != null && sumNode._next != null && sumNode._data == 0)
            {
                sumNode = sumNode._next;
            }

            return sumNode;
        }
    }
}
