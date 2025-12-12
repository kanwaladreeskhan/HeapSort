using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 4, 7, 1, 3, 6, 2 };
            MinHeapSort heap = new MinHeapSort();
            heap.Sort(arr);
            

        }
    }
}
