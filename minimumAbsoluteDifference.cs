using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void minimumAbsoluteDifference(string[] args)
        {
            int[] numList = new int[] { 1, -53, -92, -2, -54 };
            

            Console.WriteLine("minDiff = " + minimumAbsoluteDifference(numList));
            Console.ReadLine();
        }

        public static int minimumAbsoluteDifference(int[] arr)
        {
            Array.Sort(arr);
            int minDiff = 0;
            if (arr.Length == 1)
            {
                minDiff = arr[0];
            }
            else
            {
                minDiff = Math.Abs(arr[1] - arr[0]);
            }
            for (int i = 1; i < arr.Length -1; i++)
            {
                int diff = Math.Abs(arr[i + 1] - arr[i]);
                if (diff < minDiff)
                {
                        minDiff = diff;
                }

            }

            return minDiff;
        }

        public static int sum(string str)
        {
            Dictionary<string, int> numberStr = new Dictionary<string, int>() { { "one", 1 }, { "two", 2 }, { "three", 3 }, { "four", 4 },
             { "five", 5 }, { "six", 6 }, { "seven", 7 }, { "eigth", 8 },{ "nine", 9 }};
            int sum = 0;

           foreach (KeyValuePair<string, int> kvp in numberStr)
            {
                for(int i=0; i < str.Length - kvp.Key.Length;)
                {
                    string strtemp = str.Substring(i, kvp.Key.Length);
                    if (strtemp == kvp.Key) {
                        if (i - 5 > 0) {
                            string operation = str.Substring(i - 5, 5);
                            if (operation == "minus")
                            {
                                sum -= kvp.Value;
                            }
                            else
                            {
                                sum += kvp.Value;
                            }
                        }
                        i += kvp.Key.Length;
                    }
                    else
                    {
                        i++;
                    }

                }
                //count = str.Split(kvp.Key).Length - 1;
                //if(count > 0)
                //{
                //    sum += count * kvp.Value;
                //}
            }

            return sum;
        }
    }
}
