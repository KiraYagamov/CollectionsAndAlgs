namespace Lesson2_SortingAlgs
{
    class BinarySearch
    {
        public int search(int[] array, int find)
        {
            int start = 0;
            int end = array.Length - 1;

            while (start <= end)
            {
                int mid = (end + start) / 2;
                if (array[mid] == find)
                {
                    return mid;
                }
                if (array[mid] < find)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}