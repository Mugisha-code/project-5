using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace _01_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;
            int n = arr.Length;

            // Function call
            SimpleLinearSearch(arr, x);
            ImprovedLinearSearch(arr, x);
            ImprovedLinearSearchWithSentinel(arr, x);
            if (BinarySearch(arr, 0, arr.Length, searchedValue) != -1)
            {
                Console.WriteLine("Item found");
            }
            else
            {
                Console.WriteLine("Item not found");
            }

        }

        private static int ImprovedLinearSearchWithSentinel(int[] array, int searchedValue)
        {
            throw new NotImplementedException();
        }

        public static int SimpleLinearSearch(int[] array, int searchedValue)
        {
            var watch = Stopwatch.StartNew();
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == searchedValue)
                    Console.WriteLine("Element using Simple Linear Search is present at index "
                                  + i); 
            }
            return -1;
            watch.Stop();

            Console.WriteLine($"Execution time :{ watch.ElapsedMilliseconds}ms");


        }
        public static int ImprovedLinearSearch(int[] array, int searchedValue)
        {
            var watch = Stopwatch.StartNew();
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == searchedValue)
                    Console.WriteLine("Element using Improved Linear Search is present at index "
                                  + i);
                ;
            }
            return -1;
            watch.Stop();

            Console.WriteLine($"Execution time :{ watch.ElapsedMilliseconds}ms");
        }
        public static int ImprovedLinearSearchWithSentinel(int[] array, int searchedValue, int n)

        {
            var watch = Stopwatch.StartNew();
            //last element of the array


            int last = array[n - 1];

            //Element to be searched is
            //placed at the last index
            array[n - 1] = searchedValue;
            int i = 0;

            while (array[i] != searchedValue)
                i++;

            //put the last element back
            array[n - 1] = last;

            if ((i < n - 1) || (array[n - 1] == searchedValue))
            {
                Console.WriteLine("Element using Improved Linear Search With Sentinel is present at index "
                                  + i);
                ;
            }
            else
            {
                return 1;
            }
            watch.Stop();

            Console.WriteLine($"Execution time :{ watch.ElapsedMilliseconds}ms");




        }
        static int BinarySearch(int[] array, int left, int right, int searchedValue)
        {
            if (left <= right)
            {
                int middle = (left + right) / 2; //Picking the midpoint

                if (array[middle] == searchedValue)
                {
                    return searchedValue;
                }
                if (arr[middle] > item_to_find)
                {
                    return BinarySearch(array, left, middle - 1, searchedValue); //The program will go to search on the left side and middle will go -1
                    //and left will remain the same
                }
                else
                {
                    return BinarySearch(array, middle + 1, right, searchedValue); //The program will go to search on the right side and middle will go +1,
                    //and right will remain the same
                }

            }
            return -1;
        }
    }
}
