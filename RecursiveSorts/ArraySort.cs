using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekursiveSorts
{
    public static class ArraySort
    {
        public static void Show(int[] array)
        {
            foreach (var el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\n");
        }


        // 1.BubbleSort

        public static void BubbleSortRecursive(int[] array, int n)
        {
            if (n == 0)
            {
                return;
            }
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
            BubbleSortRecursive(array, n - 1);
        }


        // 2.SelectionSort //

        public static void SelectionSortRecursive(int[] array, int n)
        {
            if (n >= array.Length - 1)
            {
                return;
            }

            int minIndex = n;
            for (int i = n + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            int temp = array[n];
            array[n] = array[minIndex];
            array[minIndex] = temp;

            SelectionSortRecursive(array, n + 1);
        }

        // 3.InsertionSort//

        public static void InsertionSortRecursiveByIndex(int[] a, int i)
        {
            if (i == a.Length)
            {
                return;
            }
            while (i > 0 && a[i] < a[i - 1])
            {
                int temp = a[i];
                a[i] = a[i - 1];
                a[i - 1] = temp;
                i--;
            }

            InsertionSortRecursiveByIndex(a, i + 1);
        }

        public static void InsertionSortRecursiveByLength(int[] array, int n)
        {
            if (n <= 1)
            {
                return;
            }

            InsertionSortRecursiveByLength(array, n - 1);

            int last = array[n - 1];
            int j = n - 2;

            while (j >= 0 && array[j] > last)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = last;
        }


        // 4.MergeSort // 

        public static void Mergesort(int[] array, int beg, int end)  // imy
        {
            if (beg == end)
                return;

            int mid = (beg + end) / 2;
            Mergesort(array, beg, mid);
            Mergesort(array, mid + 1, end);

            int i = beg;
            int j = mid + 1;
            int l = end - beg + 1;
            int[] temp = new int[l];
            for (int k = 0; k < l; k++)
            {
                if (j > end || (i <= mid && array[i] < array[j]))
                {
                    temp[k] = array[i];
                    i++;
                }
                else
                {
                    temp[k] = array[j];
                    j++;
                }
            }
            int h;
            for (h = 0, i = beg; h < l; h++, i++)
            {
                array[i] = temp[h];
            }
        }


        public static void MergeSort(int[] a, int first, int last)
        {
            if (first >= last)
            {
                return;
            }
            int mid = (first + last) / 2;
            MergeSort(a, first, mid);
            MergeSort(a, mid + 1, last);
            Merge(a, first, mid, last);
        }

        public static void Merge(int[] a, int first, int mid, int last)
        {
            int first1 = first;
            int last1 = mid;
            int first2 = mid + 1;
            int last2 = last;
            int[] temp = new int[a.Length];
            int i = first1;
            for (; first1 <= last1 && first2 <= last2; i++)
            {
                if (a[first1] < a[first2])
                {
                    temp[i] = a[first1];
                    first1++;
                }
                else
                {
                    temp[i] = a[first2];
                    first2++;
                }
            }
            for (; first1 <= last1; i++)
            {
                temp[i] = a[first1];
                first1++;
            }
            for (; first2 <= last2; i++)
            {
                temp[i] = a[first2];
                first2++;
            }
            for (int k = first; k <= last; k++)
            {
                a[k] = temp[k];
            }
        }


        // 5.QuickSort

        public static void QuickSort(int[] a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int index = Part(a, start, end);
            QuickSort(a, 0, index - 1);
            QuickSort(a, index + 1, end);
        }

        private static int Part(int[] a, int start, int end)
        {
            int p = a[end]; //  element
            int index = start; // kisman index
            for (int i = start; i < end; i++)
            {
                if (a[i] < p)
                {
                    int t = a[i];
                    a[i] = a[index];
                    a[index] = t;
                    index++;
                }
            }
            int temp = a[index];
            a[index] = a[end];
            a[end] = temp;
            return index;
        }

        // BinarySearch // 

        public static void BinarySearch(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int begin = 0;
                int end = i - 1;
                int mid = end / 2;
                while (end >= begin)
                {
                    if (a[i] == a[mid])
                    {
                        break;
                    }
                    if (a[i] > a[mid])
                    {
                        begin = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                    mid = begin + (end - begin) / 2;
                } // while-ov gtav texy vory mid-n e, vorum piti texadrenq a[i]-n, mi mi hat araj tanq texadrenq 
                int temp = a[i];
                for (int k = i; k > mid; k--)
                {
                    a[k] = a[k - 1];
                }
                a[mid] = temp;
            }
        }

    }
}
