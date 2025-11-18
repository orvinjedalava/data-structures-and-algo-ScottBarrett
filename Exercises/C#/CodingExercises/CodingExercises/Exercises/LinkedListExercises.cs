using CodingExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercises.Exercises
{
    public class LinkedListExercises
    {

        public static Node? FindMiddleNode(LinkedList list)
        {
            if (list.Head == null)
                return null;
            Node? slow = list.Head;
            Node? fast = list.Head;
            while (fast != null && fast.Next != null)
            {
                slow = slow?.Next;
                fast = fast.Next.Next;
            }
            return slow;
        }

        public static bool HasLoop(LinkedList list)
        {
            if (list.Head == null)
                return false;
            Node? slow = list.Head;
            Node? fast = list.Head;
            while (fast != null && fast.Next != null)
            {
                slow = slow?.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                    return true;
            }
            return false;
        }

        public static Node? KthNodeFromTheEnd(LinkedList list, int k)
        {
            if (list.Head == null || k <= 0)
                return null;
            Node? first = list.Head;
            Node? second = list.Head;
            for (int i = 0; i < k; i++)
            {
                if (first == null)
                    return null;
                first = first.Next;
            }
            while (first != null)
            {
                first = first.Next;
                second = second?.Next;
            }
            return second;
        }

    }
}
