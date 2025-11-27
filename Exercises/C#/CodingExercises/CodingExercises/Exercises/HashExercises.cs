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

        public static char? FirstNonRepeatingCharacter(string str)
        {
            var charCount = new Dictionary<char, int>();

            foreach (var ch in str)
            {
                if (charCount.ContainsKey(ch))
                {
                    charCount[ch]++;
                }
                else
                {
                    charCount[ch] = 1;
                }
            }

            foreach (var ch in str)
            {
                if (charCount[ch] == 1)
                {
                    return ch;
                }
            }

            return null;
        }

        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            var anagramMap = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var charArray = str.ToCharArray();
                Array.Sort(charArray);
                var key = new string(charArray);

                if (!anagramMap.ContainsKey(key))
                {
                    anagramMap[key] = new List<string>();
                }
                anagramMap[key].Add(str);
            }

            return anagramMap.Values.ToList();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numIndices.ContainsKey(complement))
                {
                    return new[] { numIndices[complement], i };
                }
                numIndices[nums[i]] = i;
            }

            return []; // No solution found
        }

        public static List<List<int>> SubsetSum(int[] nums, int target)
        {
            var result = new List<List<int>>();
            Array.Sort(nums);
            FindSubsets(nums, target, 0, new List<int>(), result);
            return result;
        }
        private static void FindSubsets(int[] nums, int target, int start, List<int> current, List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                if (i > start && nums[i] == nums[i - 1]) continue; // Skip duplicates

                if (nums[i] > target) break; // No need to continue if the number is greater than the target

                current.Add(nums[i]);
                FindSubsets(nums, target - nums[i], i + 1, current, result);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}