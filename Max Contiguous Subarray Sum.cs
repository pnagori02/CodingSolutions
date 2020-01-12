using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int[] temp = new int[6] { 1, 1, 1, 1, 1, 1};
            int j;
            int maxsofar = arr[0];
            int maxEnding = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxEnding = Math.Max(maxEnding + arr[i], arr[i]);
                maxsofar = Math.Max(maxsofar, maxEnding);
            }
            Console.WriteLine(maxsofar);
            Console.ReadLine();

        }
    }
}
