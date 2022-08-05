using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix_LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strs = new string[] { "flower", "flow", "flight" };
            var op = LongestCommonPrefix(strs);
            Console.WriteLine(op);
            Console.ReadLine();
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length <= 0 )
            {
                return string.Empty;
            }
            var prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }

            return prefix;
        }
    }
}
