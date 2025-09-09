using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1207_leetcode
{
    internal class Program
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int x in arr)
            {
                if (!result.ContainsKey(x))
                    result.Add(x, 1);
                else result[x]++;
            }
            HashSet<int> set = new HashSet<int>();
            foreach (var x in result)
                if (!set.Add(x.Value))
                    return false;
            return true;

        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 1, 3 };
            var rs = UniqueOccurrences(arr);
            Console.WriteLine(rs);
        }
    }
}
