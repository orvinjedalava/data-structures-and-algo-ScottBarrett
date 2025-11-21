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

        public static LinkedList RemoveDuplicates(LinkedList list)
        {
            if (list.Head == null)
                return list;
            HashSet<int> seen = new HashSet<int>();
            Node? current = list.Head;
            Node? previous = null;
            while (current != null)
            {
                if (seen.Contains(current.Value))
                {
                    previous!.Next = current.Next;
                    list.Length--;
                }
                else
                {
                    seen.Add(current.Value);
                    previous = current;
                }
                current = current.Next;
            }
            list.Tail = previous!;
            return list;
        }

        public static decimal BinaryToDecimal(LinkedList list)
        {
            if (list.Head == null)
                return 0;
            decimal result = 0;
            Node? current = list.Head;
            while (current != null)
            {
                result = result * 2 + current.Value;
                current = current.Next;
            }
            return result;
        }

        public static LinkedList PartitionList(LinkedList list, int x)
        {
            if (list.Head == null)
                return list;

            LinkedList beforeList = new LinkedList();
            LinkedList afterList = new LinkedList();

            Node? current = list.Head;
            while (current != null)
            {
                if (current.Value < x)
                {
                    beforeList.Push(current.Value);
                }
                else
                {
                    afterList.Push(current.Value);
                }
                current = current.Next;
            }

            if (beforeList.Head == null)
                return afterList;

            beforeList.Tail!.Next = afterList.Head;
            beforeList.Length += afterList.Length;
            beforeList.Tail = afterList.Tail ?? beforeList.Tail;

            return beforeList;
        }

        public static LinkedList ReverseBetween(LinkedList list, int m, int n)
        {
            if (list.Head == null || m >= n)
                return list;

            Node? dummy = new Node(0);
            dummy.Next = list.Head;
            Node? pre = dummy;

            for (int i = 1; i < m; i++)
            {
                pre = pre!.Next;
            }

            Node? current = pre!.Next;
            for (int i = 0; i < n - m; i++)
            {
                Node? temp = current!.Next;
                current.Next = temp!.Next;
                temp.Next = pre.Next;
                pre.Next = temp;
            }

            list.Head = dummy.Next;
            return list;
        }

    }
}
