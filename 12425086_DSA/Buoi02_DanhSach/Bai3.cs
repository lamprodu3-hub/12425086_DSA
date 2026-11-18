using System;

namespace Buoi02_DanhSach
{
    static class Bai3
    {
        static int[,] a;
        static int n;

        static void Nhap()
        {
            do
            {
                Console.Write("Nhập n (0 <= n < 100): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n >= 100);

            a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
        }

        static void Xuat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write("{0,5}", a[i, j]);
                Console.WriteLine();
            }
        }

        static long TongMaTran()
        {
            long s = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++) s += a[i, j];
            return s;
        }

        static int DuongNhoNhat()
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (a[i, j] > 0 && a[i, j] < min) min = a[i, j];
            return min;
        }

        static long TongCheoPhu()
        {
            long s = 0;
            for (int i = 0; i < n; i++) s += a[i, n - 1 - i];
            return s;
        }

        static bool CheoChinhTangDan()
        {
            for (int i = 1; i < n; i++)
                if (a[i, i] <= a[i - 1, i - 1]) return false;
            return true;
        }

        public static void Chay()
        {
            Nhap();
            Console.WriteLine("\nMa trận:");
            Xuat();

            Console.WriteLine("\na. Tổng các phần tử: " + TongMaTran());

            int min = DuongNhoNhat();
            if (min == int.MaxValue) Console.WriteLine("b. Ma trận không có số dương");
            else Console.WriteLine("b. Giá trị dương nhỏ nhất: " + min);

            Console.WriteLine("c. Tổng đường chéo phụ: " + TongCheoPhu());

            if (CheoChinhTangDan()) Console.WriteLine("d. Đường chéo chính tăng dần");
            else Console.WriteLine("d. Đường chéo chính không tăng dần");
        }
    }
}