using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace RekursiveSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            ArraySort.BubbleSortRecursive(a, a.Length);
            ArraySort.Show(a);

            int[] b = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            ArraySort.SelectionSortRecursive(b, 0);
            ArraySort.Show(b);

            int[] c1 = new int[] { 9, 8, 4, 6, 5, 4, 3, 2, 1 };
            ArraySort.InsertionSortRecursiveByLength(c1, c1.Length);
            ArraySort.Show(c1);

            int[] c2 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            ArraySort.InsertionSortRecursiveByIndex(c2, 0);
            ArraySort.Show(c2);

            int[] d1 = new int[] { 9, 8, 7, 7, 5, 4, 3, 5, 1 };
            ArraySort.Mergesort(d1, 0, d1.Length - 1);
            ArraySort.Show(d1);

            int[] d2 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            ArraySort.MergeSort(d2, 0, d2.Length - 1);
            ArraySort.Show(d2);

            int[] e = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            ArraySort.QuickSort(e, 0, e.Length - 1);
            ArraySort.Show(e);

            int[] f = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            ArraySort.BinarySearch(f);
            ArraySort.Show(f);
        }
    }
}
