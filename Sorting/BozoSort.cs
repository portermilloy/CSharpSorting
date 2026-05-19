using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BozoSort : Sort
    {
        public BozoSort(Action<int[]> display) : base(display)
        {
        }

        public override async Task<int[]> sort(int[] arr, CancellationToken token)
        {
            int[] sortedArray = new int[arr.Length];
            
            Random rnd = new Random();
            bool sorted = false;
            while (!sorted)
            {
                var a = rnd.Next(arr.Length);
                var b = rnd.Next(arr.Length);

                var t = arr[a];
                arr[a] = arr[b];
                arr[b] = t;
                await Task.Delay(500);
                displayFunc(arr);
                token.ThrowIfCancellationRequested();

                if (isSorted(arr))
                {
                    sorted = true;
                }
            }

            return arr;

        }
        public bool isSorted(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i+1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
