using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_leetcode
{
    internal class Program
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            int length = nums.Length;
            if (length == 1) return false;
            HashSet<int> set = new HashSet<int>(length);
            for (int i = 0; i < length; i++)
                if (!set.Add(nums[i]))
                    return true;

            return false;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            bool rs = ContainsDuplicate(nums);
            Console.WriteLine(rs);
        }
    }
}
