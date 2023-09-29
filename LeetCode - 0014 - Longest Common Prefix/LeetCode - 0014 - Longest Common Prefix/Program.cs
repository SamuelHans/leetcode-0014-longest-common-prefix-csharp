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
            //var strs = new string[3] { "dog", "racecar", "car" };

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

            Console.WriteLine("The longest common prefix is {0}", longestCommon);
        }
    }
}