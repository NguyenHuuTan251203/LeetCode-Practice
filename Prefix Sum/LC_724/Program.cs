using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC_724
{
    internal class Program
    {
        public static int PivotIndex(int[] nums)
        {
            int length = nums.Length, left_sum = 0, right_sum = 0;
            right_sum =  nums.Sum();
            for (int i = 0; i < length; i++)
            {
                right_sum -= nums[i];
                if (left_sum == right_sum)
                    return i;
                left_sum += nums[i];
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int [] nums = { 1, 7, 3, 6, 5, 6 };
            int a = PivotIndex(nums);
            
        }
    }
}
