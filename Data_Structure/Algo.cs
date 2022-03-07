using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure
{
    class QuickSortClass
    {
        public static void QuickSort(ref int[] array)
        {
            quickSort(ref array, 0, array.Length - 1);
        }
        private static void quickSort(ref int[] array, int left, int right)
        {
            //do nothing if the partition or array is sorted.
            if (left >= right)
            {
                return;
            }
            int p = partition(ref array, left, right);
            //do quick sort on left partition
            quickSort(ref array, left, p - 1);
            quickSort(ref array, p + 1, right);

        }
        private static int partition(ref int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            int temp;
            for (int j = left; j < right; j++)
            {
                //swap larger value to the left and smaller value to the right
                if (array[j] < pivot)
                {
                    i++;
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            //move pivot after smaller values and before larger values
            temp = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp;
            //return the index location of the pivot
            return i + 1;
        }

    }
}
