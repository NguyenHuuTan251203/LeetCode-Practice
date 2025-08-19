using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _187_lettcode
{
    internal class Program
    {
        public static IList<string> FindRepeatedDnaSequences(string s)
        {
            int left = 1, length = s.Length;
            HashSet<string> set = new HashSet<string>() { s.Substring(0, 10) };
            HashSet<string> list = new HashSet<string>();

            if (length < 10) return null;
            for (int right = 10; right < length; right++)
            {
                string subString = s.Substring(left, 10);
                if (!set.Add(subString))
                    list.Add(subString);
                left++;
            }

            return list.ToList();
        }

        static void Main(string[] args)
        {
            string s = "CAAAAAAAAAC";
            IList<string> list = FindRepeatedDnaSequences(s);
            foreach (var sequence in list)
            {
                Console.WriteLine(sequence);
            }
        }
    }
}
