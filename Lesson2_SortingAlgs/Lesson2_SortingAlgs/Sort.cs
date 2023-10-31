using System;

namespace Lesson2_SortingAlgs
{
    abstract class Sort
    {
        public int[] sort()
        {
            return sort(GetRandomArray());
        }

        public int[] GetRandomArray()
        {
            int[] array = new int[10000];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10000);
            }
            return array;
        }

        public abstract int[] sort(int[] array);
    }
}