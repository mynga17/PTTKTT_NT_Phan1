using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi2
{
    class Binary_Search
    {
        static void Main(string[] args)
        {
            int n = 8, key = 13, key2 = 6;
            int[] Array = { 1, 3, 5, 7, 9, 13, 24, 28 };
            int result = BinarySearch(Array, n, key);
            Console.WriteLine("Vi tri phan tu {0} trong mang la {1}", key, result);
            result = BinarySearch(Array, n, key2);
            Console.WriteLine("Vi tri phan tu {0} trong mang la {1}", key2, result);
            Console.ReadLine();
        }
        public static int BinarySearch(int[] A, int n, int key)
        {
            int left = 0; // vị trí phần tử đầu tiên trong mảng
            int right = n - 1; // vị trí phần tử cuối cùng trong mảng
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (A[mid] == key)
                {
                    return mid; //tìm thấy
                }
                else if (key < A[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1; // không tìm thấy key trong mảng nên trả về vị trí -1.
        }
    }
}