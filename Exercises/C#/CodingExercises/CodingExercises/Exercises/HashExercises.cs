using CodingExercises.Models;

namespace CodingExercises.Exercises
{
    public class HashExercises
    {
        public static bool ItemInCommon(int[] array1, int[] array2)
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

        public static int[] FindDuplicates(int[] array)
        {
            var seen = new HashSet<int>();
            var duplicates = new HashSet<int>();

            foreach (var item in array)
            {
                if (seen.Contains(item))
                {
                    duplicates.Add(item);
                }
                else
                {
                    seen.Add(item);
                }
            }

            return duplicates.ToArray();
        }
    }
}