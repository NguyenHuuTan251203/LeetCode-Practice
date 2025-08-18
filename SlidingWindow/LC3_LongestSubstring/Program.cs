
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_leetcode
{
    internal class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int left = 0, lengthOfLongestSubstring = 0;
            HashSet<char> set = new HashSet<char>();
            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
                lengthOfLongestSubstring = Math.Max(lengthOfLongestSubstring, right - left + 1);
            }
            return lengthOfLongestSubstring;
        }

        static void Main(string[] args)
        {
            string s = "pwwkew";
            int lengh_array_longest = LengthOfLongestSubstring(s);
            Console.WriteLine(lengh_array_longest);
        }
    }
}
