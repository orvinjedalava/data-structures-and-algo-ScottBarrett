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

        public static bool ParenthesisBalanced(string expression)
        {
            var stack = new Stack<char>();
            foreach (var ch in expression)
            {
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }

        public static Stack<int> SortStack(Stack<int> inputStack)
        {
            var tempStack = new Stack<int>();

            while (inputStack.Count > 0)
            {
                int current = inputStack.Pop();

                while (tempStack.Count > 0 && tempStack.Peek() > current)
                {
                    inputStack.Push(tempStack.Pop());
                }

                tempStack.Push(current);
            }

            var resultStack = new Stack<int>();
            while (tempStack.Count > 0)
            {
                resultStack.Push(tempStack.Pop());
            }

            return resultStack;
        }

        public static Stack<int> Enqueue(Stack<int> queueStack, int value)
        {
            Stack<int> tempStack = new();
            while (queueStack.TryPeek(out _))
            {
                tempStack.Push(queueStack.Pop());
            }
            queueStack.Push(value);
            while (tempStack.TryPeek(out _))
            {
                queueStack.Push(tempStack.Pop());
            }
            return queueStack;
        }
    }
}