using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercises.Models
{
    public class Node(int value)
    {
        public int Value { get; set; } = value;
        public Node? Next { get; set; } = null;
    }
}
