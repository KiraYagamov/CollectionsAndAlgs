using System;

namespace Lesson2_SortingAlgs
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Sort sort = new CombSort();
            int[] array = sort.GetRandomArray();
            array = sort.sort(array);
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            BinarySearch binarySearch = new BinarySearch();
            Console.Write(binarySearch.search(array, 10));
        }
    }
}