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
    }
}