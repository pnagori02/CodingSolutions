using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aacbca";
            string str2 = "xxzyzx"; //xxz
            int length = str2.Length;
            // str1 = "aab", str2 = "xxy"
            //ArrayList pos = new ArrayList();
            //for(int i=0; i <= str.Length -(str2.Length); i++)
            //{
            //    if(IsAnagram(str.Substring(i,length),str2))
            //    {
            //        pos.Add(i);
            //    }
            //}

            Console.WriteLine("Sum = " +IsIsomorphic(str,str2));
            Console.ReadLine();
        }

        public static bool IsIsomorphic(string str1, string str2)
        {
            Dictionary<char, char> kvp = new Dictionary<char, char>();
            if(str1.Length != str2.Length)
            {
                return false;
            }

            for(int i=0; i< str1.Length; i++)
            {
                if (!kvp.ContainsKey(str1[i]))
                {
                    kvp.Add(str1[i], str2[i]);
                }
                if (kvp.Keys.Count() > 0 && kvp.ContainsKey(str1[i]) && kvp[str1[i]] == str2[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

            public static bool IsAnagram(string str1, string str2)
        {
            // Length of two strings are not equal 
            if (str1.Length != str2.Length)
                return false;

            Hashtable strhash = new Hashtable();
            for (int i = 0; i < str1.Length; i++)
            {
                if (strhash.Contains(str1[i]))
                {
                    strhash[str1[i]] = (int)strhash[str1[i]] + 1;
                }
                strhash.Add(str1[i], 1);
            }

            // Decremet the value count when key is encountered
            for (int i = 0; i < str2.Length; i++)
            {
                if (strhash.ContainsKey(str2[i]) && (int)strhash[str2[i]] > 0)
                {
                    strhash[str2[i]] = (int)strhash[str2[i]] - 1;
                }
                else
                    return false;
            }

            return true;
        }
    }
}
