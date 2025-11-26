using CodingExercises.Models;

namespace CodingExercises.Exercises
{
    public class HashExercises
    {
        public bool ItemInCommon(int[] array1, int[] array2)
        {
            var items = new HashSet<int>();
            foreach (var item in array1)
            {
                items.Add(item);
            }

            foreach (var item in array2)
            {
                if (items.Contains(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}