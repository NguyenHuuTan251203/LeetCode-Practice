using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004_leetcode
{
    internal class Program
    {
        public static int LongestOnes(int[] nums, int k)
        {
            int zero = 0, left = 0,maxCount = 0;
            for(int right = 0; right < nums.Length;right++)
            {
                if (nums[right] == 0)
                    zero++;
                while (zero > k )
                {
                    if (nums[left] == 0) zero--;
                    left++;
                }    
                maxCount = Math.Max(maxCount, right - left +1);
            }


            return maxCount;
        }

        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 }; int k = 3;
            int countMax = LongestOnes(nums, k);
            Console.WriteLine(countMax);
        }
    }
}

