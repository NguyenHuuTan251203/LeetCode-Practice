using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209_leetcode
{
    internal class Program
    {
        public static int MinSubArrayLen(int target, int[] nums)
        {
            int length = nums.Length, left = 0, sum = 0, minimalLength = int.MaxValue;

            for (int right = 0; right < length; right++)
            {
                sum += nums[right];
                while (sum >= target)
                {
                    minimalLength = Math.Min(minimalLength, right - left + 1);
                        sum -= nums[left];
                    left++;
                }
            }
            return minimalLength == int.MaxValue ? 0 : minimalLength;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int target = 11;
            Console.WriteLine(MinSubArrayLen(target, nums));
        }
    }
}
