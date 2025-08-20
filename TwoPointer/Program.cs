using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_
{
    internal class Program
    {
        public static int MaxArea(int[] height)
        {
            int left = 0,right = height.Length - 1,maxArea = 0;
            while (left < right)
            {
                int area = (right - left) * Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, area);
                if (height[left] < height[right])
                    left++;
                else
                    right--;

            }
            return maxArea;
        }
        static void Main(string[] args)
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(MaxArea(height));
        }
    }
}
