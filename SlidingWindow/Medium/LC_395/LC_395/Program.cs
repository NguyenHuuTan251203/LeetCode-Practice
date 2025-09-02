using System;
using System.Collections.Generic;

namespace LC_395
{
    internal class Program
    {
        public static int LongestSubstring(string s, int k) // k =2
        {
            //ababbc
            HashSet<char> hashSet = new HashSet<char>();
            int length = s.Length, longest_substring = 0;
            foreach (char x in s)
            {
                hashSet.Add(x);
            }
            if (hashSet.Count == 1 && length >= k) return length;

            int target_unique = 1, max_unique = hashSet.Count; //3
            Dictionary<char, int> hashMap = new Dictionary<char, int>();
            hashSet.Clear();
            while (target_unique <= max_unique) // 0 < 3
            {
                int left = 0, unique_count = 0, count_at_least_k = 0;
                for (int right = 0; right < length; right++)
                {
                    if (!hashMap.ContainsKey(s[right]))
                    {
                        hashMap.Add(s[right], 1);  // a:1 b:1 
                        unique_count++;   // unquie = 2
                    }
                    else hashMap[s[right]]++; // a:2 b:3

                    if (hashMap[s[right]] == k) count_at_least_k++; // count_at_least = 2

                    while (unique_count > target_unique)
                    {

                        if (s[left] != hashMap[s[0]])
                        {
                            hashMap.Remove(s[0]);
                            //hashMap.Clear();    
                            break;
                        }
                        left++;
                    }



                    if (count_at_least_k == k)
                        longest_substring = Math.Max(longest_substring, right - left + 1);



                }
                target_unique++;
            }




            return longest_substring;
        }
        static void Main(string[] args)
        {
            string s = "ababbc";
            int k = 3;
            Console.WriteLine(LongestSubstring(s, k));
        }
    }
}
