using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "heart";
            string s2 = "earth";
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both strings are not Anagrams");
            }
        }
    }
}
