namespace Lesson2_SortingAlgs
{
    class CombSort : Sort
    {
        public override int[] sort(int[] array)
        {
            int step = array.Length - 1;
            double k = 1.247;

            while (step > 1)
            {
                for (int i = 0; i + step < array.Length; i++)
                {
                    if (array[i] > array[i + step])
                    {
                        int small = array[i + step];
                        array[i + step] = array[i];
                        array[i] = small;
                    }
                }

                step = (int) (step / k);
            }
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