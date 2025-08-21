using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_leetcode
{
    internal class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            int length = strs.Length;
            if (length == 0) return "";
            StringBuilder rs = new StringBuilder();
            strs = strs.OrderBy(x => x.Length).ToArray();
            for (int i = 0; i < strs[0].Length; i++)
            {
                for(int j = 1; j < length;j++)
                {
                    if (strs[0][i] != strs[j][i])
                    {
                        return rs.ToString();
                    }
                }
                rs.Append(strs[0][i]);
            }
            return rs.ToString();
        }
        static void Main(string[] args)
        {
            string[] strs = {"reflower", "flow", "flight" };
            string result = LongestCommonPrefix(strs);
            Console.WriteLine(result);
        }
    }
}
