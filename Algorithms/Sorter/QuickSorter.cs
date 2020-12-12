﻿using System;

namespace MuxLib.MUtility.Algorithms.Sorter
{
    public sealed class QuickSorter<T> : Metas.Sorter<T>
        where T : IComparable
    {
        public override void Sort(T[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(T[] arr, int low, int hight)
        {
            if (hight < -low) return;
            int lt = low, i = low + 1, gt = hight;
            T v = arr[low];
            while (i <= gt)
            {
                int cmp = arr[i].CompareTo(v);
                if (cmp < 0) Swap(arr, lt++, i++);
                else if (cmp > 0) Swap(arr, i, gt--);
                else ++i;
            }

            Sort(arr, low, lt - 1);
            Sort(arr, gt + 1, hight);
        }
    }
}