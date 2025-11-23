using CodingExercises.Models;

namespace CodingExercises.Exercises
{
    public class DoublyLinkedListExercises
    {
        // Implement doubly linked list exercises here
        public static bool PalindromeChecker(DoublyLinkedList list)
        {
            if (list.Head == null)
                return true;

            var left = list.Head;
            var right = list.Tail;

            while (left != null && right != null && left != right && left.Prev != right)
            {
                if (left.Value != right.Value)
                    return false;

                left = left.Next;
                right = right.Prev;
            }

            return true;
        }

        public static DoublyLinkedList Reverse(DoublyLinkedList list)
        {
            if (list.Head == null)
                return list;

            var current = list.Head;
            DoublyNode? temp = null;

            while (current != null)
            {
                temp = current.Prev;
                current.Prev = current.Next;
                current.Next = temp;
                current = current.Prev;
            }

            if (temp != null)
            {
                list.Tail = list.Head;
                list.Head = temp.Prev;
            }

            return list;
        }

        public static DoublyLinkedList ReverseBetween(DoublyLinkedList list, int m, int n)
        {
            if (list.Head == null || m >= n)
                return list;

            var current = list.Head;
            DoublyNode? prevM = null;
            DoublyNode? nodeM = null;
            int position = 1;

            while (current != null && position < m)
            {
                prevM = current;
                current = current.Next;
                position++;
            }

            nodeM = current;
            DoublyNode? prev = null;

            while (current != null && position <= n)
            {
                var next = current.Next;
                current.Next = prev;
                current.Prev = next;
                prev = current;
                current = next;
                position++;
            }

            if (nodeM != null)
            {
                nodeM.Next = current;
                if (current != null)
                    current.Prev = nodeM;
            }

            if (prevM != null)
            {
                prevM.Next = prev;
                if (prev != null)
                    prev.Prev = prevM;
            }
            else
            {
                list.Head = prev;
            }

            return list;
        }
    }
}