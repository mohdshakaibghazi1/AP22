using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConAppQuickSort
{
    internal class Program
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);

            }
        }
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);

                }

            }
            Swap(array, i + 1, right);
            return i + 1;
        }
        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  "); // Changed WriteLine to Write to print on the same line.
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            Stopwatch sw = new Stopwatch();
            Print(array);
            sw.Start();
            QuickSort(array);
            sw.Stop();
            Print(array);
            Console.WriteLine($"ArraySize {array.Length} Time Taken {sw.Elapsed.TotalMilliseconds} millideconds");
            Console.ReadKey();
        }
    }
}