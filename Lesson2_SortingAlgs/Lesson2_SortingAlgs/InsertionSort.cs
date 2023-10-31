namespace Lesson2_SortingAlgs
{
    class InsertionSort : Sort
    {
        public override int[] sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j - 1] > array[j])
                {
                    int small = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = small;
                    j--;
                }
            }
            return array;
        }
    }
}