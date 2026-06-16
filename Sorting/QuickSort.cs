using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort : Sort
    {
        public QuickSort(Action<int[]> display) : base(display)
        {
        }

        public override async Task<int[]> sort(int[] arr, CancellationToken token)
        {
            await QuickSortHelper(arr, 0, arr.Length - 1, token);
            return arr;
        }

        private async Task QuickSortHelper(int[] arr, int low, int high, CancellationToken token)
        {
            if (low < high)
            {
                int pivot = await Partition(arr, low, high, token);
                await QuickSortHelper(arr, low, pivot - 1, token);
                await QuickSortHelper(arr, pivot + 1, high, token);
            }
        }

        private async Task<int> Partition(int[] arr, int low, int high, CancellationToken token)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    var t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;

                    await Task.Delay(500);
                    displayFunc(arr);
                    token.ThrowIfCancellationRequested();
                }
            }

            var temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;

            await Task.Delay(500);
            displayFunc(arr);
            token.ThrowIfCancellationRequested();

            return i + 1;
        }
    }
}
