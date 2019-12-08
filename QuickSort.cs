using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class QuickSort2

    {
        public static void Main()
        {
            int[] arr = { 10, 80, 7, 25, 30, 40, 5, 70, 30 };
            int n = arr.Length;
            quickSort(arr, 0, n - 1);
            Console.WriteLine("sorted array ");
            printArray(arr, n);
            Console.ReadLine();
        }

        static void quickSort(int[] arr, int low, int high)
        {
           if(low < high)
            {
                int p = partition(arr, low, high);
                quickSort(arr, low, p - 1);
                quickSort(arr, p + 1, high);
            }
        }

        static int partition(int[] arr, int low, int high)
        {

            int i = low - 1;
            int pivot = arr[high];
            for (int j = low; j <= high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            return i;
        }

        // A utility function to print array of size n 
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
