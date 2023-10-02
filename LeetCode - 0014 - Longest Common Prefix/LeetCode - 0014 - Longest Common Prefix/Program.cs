using System.Text;

namespace LeetCode___0014___Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a function to find the longest common prefix string amongst an array of strings.
            If there is no common prefix, return an empty string "".

            Example 1:
            Input: strs = ["flower","flow","flight"]
            Output: "fl"

            Example 2:
            Input: strs = ["dog","racecar","car"]
            Output: ""
            Explanation: There is no common prefix among the input strings.

            Constraints:

            1 <= strs.length <= 200
            0 <= strs[i].length <= 200
            strs[i] consists of only lowercase English letters.
            */

            var strs = new string[3] { "flower", "flow", "flight" };
            ////var strs = new string[3] { "dog", "racecar", "car" };

            // Get longest common prefix
            Console.WriteLine("Longest common prefix is: {0}", LongestCommonPrefixMethod2(strs));
        }

        public string LongestCommonPrefixMethod1(string[] strs)
        {
            string longestCommon;

            Array.Sort(strs);

            longestCommon = strs[0];

            for (int i = 0; i < strs[0].Length; i++)
            {
                if (strs.Last().StartsWith(longestCommon))
                {
                    //longestCommon = strs.Last();
                    break;
                }
                else
                {
                    longestCommon = longestCommon.Remove(longestCommon.Length - 1);
                }
            }

            return longestCommon;
        }

        public static string LongestCommonPrefixMethod2(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            // Find shortest word length
            int strsLength = strs[0].Length;
            for (int i = 1; i < strs.Length; i++)
            {
                if (strsLength > strs[i].Length)
                {
                    strsLength = strs[i].Length;
                }
            }

            var currentLongestCommonPrefix = "";

            // Loop through first array element, of each letter, up to max word length

            // This loop focuses on array element 1
            // i is the letter position, used in array entry 1 and compared to other elements
            for (int i = 0; i < strsLength; i++)
            {
                // Jagged array [first element][max length]. Focuses on target letter of the array element 1
                char targetCharInFirstArrayEntry = strs[0][i];

                // Start at 2nd element, k=1
                for (int k = 1; k < strs.Length; k++)
                {
                    if (strs[k][i] != targetCharInFirstArrayEntry)
                    {
                        return currentLongestCommonPrefix;
                    }
                }
                currentLongestCommonPrefix = currentLongestCommonPrefix + targetCharInFirstArrayEntry;
            }

            return currentLongestCommonPrefix;
        }
    }
}