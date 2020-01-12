using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[7] { 6,2,4,3,7,4,5 };
            int[] temp = new int[7] { 1, 1, 1, 1, 1, 1, 1 };
            int j;
            Hashtable ht = new Hashtable();
            ht.Add(1900, 1);
            ht[1900] = (int)ht[1900] + 1;

            Dictionary<int, int> data = new Dictionary<int, int>();
            data.Add(1900, 1);
            data[1900] = data[1900] + 1;

            for (int i = 1; i < arr.Length; i++)
            {
                j = 0;
                while (j < i)
                {
                    if (arr[j] < arr[i])
                    {
                        temp[i] = Math.Max(temp[i], temp[j] +1);
                    }

                    j++;
                }
            }

            Console.WriteLine(temp[0] + "" + temp[1] + "" + temp[2] + "" + temp[3] + "" + temp[4] + "" + temp[5] + temp[6]);
            Console.ReadLine();

        }
    }
}
