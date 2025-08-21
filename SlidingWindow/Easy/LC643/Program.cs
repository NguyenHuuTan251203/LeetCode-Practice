using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _643_
{
    internal class Program
    {

        //Given an integer array nums and an integer k, return the maximum average value of a subarray of length k.
        //Any subarray of length k is a contiguous subarray of length k that can be found in the array.
        //The average value of a subarray is the sum of the elements in the subarray divided by k.
        //Example 1:
        //Input: nums = [1,12,-5,-6,50,3], k = 4
        //Output: 12.75
        //Thanks you copilot for the help


        public static double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for(int i = 0; i < k;i++)
            {
                sum += nums[i];
            }
            int maxSum=sum;

            for(int i  = k;i < nums.Length;i++)
            {
                sum = sum - nums[i - k] + nums[i];
                maxSum = Math.Max(maxSum, sum);
            }
            return (double) maxSum/k;

        }
        static void Main(string[] args)
        {
            int[] nums = { 5};
            int k = 1;
            double maxava = FindMaxAverage(nums, k);
            Console.WriteLine(maxava);
        }
    }
}
