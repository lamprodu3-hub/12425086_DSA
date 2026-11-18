using System;

namespace Buoi02_DanhSach
{
    static class TH10
    {
        public static void Chay()
        {
            Console.Write("Nhập số dòng m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột n: ");
            int n = int.Parse(Console.ReadLine());
            if (m <= 0 || n <= 0)
            {
                Console.WriteLine("m và n phải lớn hơn 0!");
                return;
            }

            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("\nMa trận:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) Console.Write("{0,5}", a[i, j]);
                Console.WriteLine();
            }

            int top = 0, bottom = m - 1, left = 0, right = n - 1;
            Console.Write("\nThứ tự xoắn ốc: ");
            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right; j++) Console.Write(a[top, j] + " ");
                top++;
                for (int i = top; i <= bottom; i++) Console.Write(a[i, right] + " ");
                right--;
                if (top <= bottom)
                {
                    for (int j = right; j >= left; j--) Console.Write(a[bottom, j] + " ");
                    bottom--;
                }
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--) Console.Write(a[i, left] + " ");
                    left++;
                }
            }
            Console.WriteLine();
        }
    }
}