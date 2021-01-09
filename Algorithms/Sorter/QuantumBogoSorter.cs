﻿using System;
namespace MuxLib.MUtility.Algorithms.Sorter
{
    public class QuantumBogoSorter<T> : Metas.Sorter<T>
        where T : IComparable
    {
        public override void Sort(T[] arr)
        {
            Random random = new Random();
            while (!IsSorted(arr))
            {
                Shuffle(arr, random);
            }
        }

        private void Shuffle(T[] arr, Random random)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // ensure the random value will not "out-of-range"
                int j = Math.Abs(random.Next() % arr.Length - 1);

                Swap(arr, i, j);
            }
        }
    }
}