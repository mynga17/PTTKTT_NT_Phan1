using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi2
{
    class Merge_Sort
    {
        static void Main(string[] args)
        {
            int[] Array = { 5, 1, 8, 10, 4, 13 };
            int n = Array.Length;
            MergeSort(Array, 0, n - 1);
            Console.Write("Cac phan tu sau khi sap xep: ");
            // in mảng sau khi sắp xếp
            foreach (int item in Array)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        private static void Merge(int[] A, int left, int mid, int right)
        {
            int n1 = mid - left + 1; // độ dài nửa dãy đầu của A
            int n2 = right - mid; // độ dài nửa dãy sau của A

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i, j;
            // Chép nửa dãy đầu của A vào L
            for (i = 0; i < n1; i++)
                L[i] = A[left + i];

            // Chép nửa dãy sau của A vào R
            for (j = 0; j < n2; j++)
                R[j] = A[mid + 1 + j];

            i = 0; j = 0;
            int k = left;
            for (k = left; k <= right; k++) // L và R lại vào A sao cho A có thứ tự tăng dần.
            {
                if (i < n1 && (j >= n2 || L[i] <= R[j]))
                {
                    A[k] = L[i];
                    i = i + 1;
                }
                else
                {
                    A[k] = R[j];
                    j = j + 1;
                }
            }
        }
        private static void MergeSort(int[] A,int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2; //vị trí phần tử ở giữa dãy
                MergeSort(A, left, mid); // Gọi hàm Merge_Sort cho nửa dãy con đầu
                MergeSort(A, mid + 1, right); // Gọi hàm Merge_Sort cho nửa dãy con cuối
                Merge(A, left, mid, right); //Hàm trộn 2 dãy con có thứ tự thành dãy ban đầu có thứ tự
            }
        }
    }
}
