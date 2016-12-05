using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        /// <summary>
        /// 值交换
        /// </summary>
        /// <param name="a">参数</param>
        /// <param name="b">参数</param>
        private static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        /// 分开数组
        /// </summary>
        /// <param name="arr">待排序的数组</param>
        /// <param name="low">数组的起始索引</param>
        /// <param name="high">数组的最后的索引</param>
        /// <returns></returns>
        private static int Partition(ref int[] arr, int low, int high)
        {
            int i = low;
            int j = high;
            int temp = arr[i];
            while (i < j)
            {
                while (i < j && arr[j] >= temp)
                {
                    j--;
                }
                swap(ref arr[i], ref arr[j]);
                //arr[i] = arr[j];
                while (i < j && arr[i] <= temp)
                {
                    i++;
                }
                //arr[j] = arr[i];
                swap(ref arr[i], ref arr[j]);

            }
            //arr[i] = temp;
            Print(arr, 10);
            return i;
        }
        /// <summary>
        /// 快速排序法
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void QuickSortFun(ref int[] arr, int low, int high)
        {
            if (low < high)
            {
                int index = Partition(ref arr, low, high);
                QuickSortFun(ref arr, low, index - 1);
                QuickSortFun(ref arr, index + 1, high);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 5, 7, 2, 4, 9, 6, 10, 8 };
            Console.WriteLine("----------原始数组----------");
            Print(arr, 10);
            QuickSortFun(ref arr, 0, 9);
            Console.WriteLine("----------排序后数组----------");
            Print(arr, 10);
            Console.ReadLine();

        }

        static void Print(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
