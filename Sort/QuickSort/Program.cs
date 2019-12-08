using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quick_Sort
{
    class Program
    {
        public static int SwapCount;
        static void Main(string[] args)
        {

            int[] array = new int[] { 12, 33, 45, 11, 0, 117, -22, 103, 18, 3 };

            Console.WriteLine("-------------");
            Console.WriteLine("Inital array:");
            Console.WriteLine("-------------");
            foreach (var item in array)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(array, 0, array.Length - 1);

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Array after QuickSort:");
            Console.WriteLine("----------------------");

            foreach (var item in array)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
        private static void Quick_Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(array, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {

                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}