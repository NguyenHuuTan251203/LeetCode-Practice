using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2215_leetcode
{
    internal class Program
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            
            HashSet<int> arr1 = new HashSet<int>(nums1);
            HashSet<int> arr2 = new HashSet<int>(nums2);

            var only1 = new HashSet<int>(arr1);
            var only2 = new HashSet<int>(arr2);

            only1.ExceptWith(only2);
            only2.ExceptWith(only1);    


            return new List<IList<int>> { only1.ToList() ,only2.ToList()};
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3,3 }, nums2 = { 1,1,2,2 };
            IList<IList<int>> rs = FindDifference(nums1, nums2);
            //foreach (var item in rs)
            //{

            //}
        }
    }
}
