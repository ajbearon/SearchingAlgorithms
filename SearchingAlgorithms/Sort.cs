using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingSortingAlgorithms
{
    internal class Sort
    {
        public static void InsertionSort(
            int[] items)
        {
            if (items == null) { return; }

            for (int i = 1; i < items.Length; i++)
            {
                for (int j = i; j > 0 && items[j] < items[j-1]; j--)
                {
                    var temp = items[j-1];
                    items[j-1] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
}
