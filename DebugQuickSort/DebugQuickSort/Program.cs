﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugQuickSort
{
    class Program
    {
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {9,6,5};

            Console.WriteLine("Sap xep nhanh (Quick Sort) trong C#: ");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nIn mang ban dau: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("\nIn mang da qua sap xep: ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
