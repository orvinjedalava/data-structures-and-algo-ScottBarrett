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

    }
}
