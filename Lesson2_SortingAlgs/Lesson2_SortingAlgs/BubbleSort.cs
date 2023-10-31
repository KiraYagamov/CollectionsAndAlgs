namespace Lesson2_SortingAlgs
{
    class BubbleSort : Sort
    {
        public override int[] sort(int[] array)
        {
            bool sorting = true;

            while (sorting)
            {
                sorting = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int small = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = small;
                        sorting = true;
                    }
                }
            }
            return array;
        }
    }
}