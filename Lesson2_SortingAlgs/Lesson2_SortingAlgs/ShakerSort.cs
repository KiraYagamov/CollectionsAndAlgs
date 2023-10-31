namespace Lesson2_SortingAlgs
{
    class ShakerSort : Sort
    {
        public override int[] sort(int[] array)
        {
            bool sorting = true;
            int begin = -1;
            int end = array.Length - 1;

            while (sorting)
            {
                sorting = false;
                begin++;
                for (int i = begin; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int small = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = small;
                        sorting = true;
                    }
                }
                end--;
                for (int i = end; i > begin; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        int small = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = small;
                        sorting = true;
                    }
                }
            }
            return array;
        }
    }
}