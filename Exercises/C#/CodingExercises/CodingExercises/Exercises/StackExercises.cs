using CodingExercises.Models;

namespace CodingExercises.Exercises
{
    public class StackExercises
    {
        public static string ReverseString(string input)
        {
            var stack = new Stack<char>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            var reversed = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = stack.Pop();
            }

            return new string(reversed);
        }
    }
}