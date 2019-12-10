using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class MergeSort

    {

        public static void Main()
        {
            int[] arr = { 10, 80, 7, 25, 30, 40, 5, 70, 30 }; ///7,10,5,15
            int n = arr.Length;

            StringBuilder test =  new StringBuilder("before passing");
            Console.WriteLine(test);
            TestI(test);
            Console.WriteLine(test);

            //mergeSort(arr, 0, n -1);
            //Console.WriteLine("sorted array ");
            //printArray(arr, n);
            Console.ReadLine();
        }

        public static void TestI(StringBuilder test)
        {
            test = test.Append("after passing") ;
        }

        /*  */
        static void merge(int[] arr, int left, int middle, int right)
        {
            int i, j;
            int k = left;
            int leftSize = middle - left +1;
            int rightSize = right - middle;
            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            for (i = 0; i < leftSize; i++)
            {
                leftArray[i] = arr[left + i];
            }

            for (j = 0; j < rightSize; j++)
            {
                rightArray[j] = arr[middle + 1 + j];
            }

            for (i = 0, j = 0; i < leftSize && j < rightSize;)
            {
                if (leftArray[i] < rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }


            while (i < leftSize)
            {
                arr[k++] = leftArray[i];
                i++;
            }



            while (j < rightSize)
            {
                arr[k++] = rightArray[j];
                j++;
            }



        }

        /* divide the array into 2 & recursively call merge */
        static void mergeSort(int[] arr, int low,
                                       int high)
        {
            int m;
           if(low < high)
            {
                // low 0, 3,7
                m = (low + high) / 2;
                mergeSort(arr, low, m);
                mergeSort(arr, m + 1, high);

                merge(arr, low, m, high);
            }
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
