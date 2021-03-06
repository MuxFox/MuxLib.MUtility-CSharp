﻿using System;
using MuxLib.MUtility.Algorithms.Metas;

namespace MuxLib.MUtility.Algorithms.Sorter
{
    public sealed class QuickSorter<T> : Sorter<T>
        where T : IComparable
    {
        public override void Sort(T[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(T[] arr, int low, int high)
        {
            if (high <= low) return;
            int lt = low, i = low + 1, gt = high;
            var v = arr[low];
            while (i <= gt)
            {
                var cmp = arr[i].CompareTo(v);
                switch (cmp)
                {
                    case < 0:
                        Swap(arr, lt++, i++);
                        break;
                    case > 0:
                        Swap(arr, i, gt--);
                        break;
                    default:
                        ++i;
                        break;
                }
            }

            Sort(arr, low, lt - 1);
            Sort(arr, gt + 1, high);
        }
    }
}