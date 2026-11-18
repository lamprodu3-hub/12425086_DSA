using System;

namespace Buoi02_DanhSach
{
    static class TH11
    {
        static bool DonVi(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == j && a[i, j] != 1) return false;
                    if (i != j && a[i, j] != 0) return false;
                }
            return true;
        }

        static bool DoiXung(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < i; j++)
                    if (a[i, j] != a[j, i]) return false;
            return true;
        }

        public static void Chay()
        {
            Console.Write("Nhập cấp n của ma trận vuông: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("n phải lớn hơn 0!");
                return;
            }

            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("\nMa trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write("{0,5}", a[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine(DonVi(a, n) ? "\nĐây là ma trận đơn vị" : "\nKhông phải ma trận đơn vị");
            Console.WriteLine(DoiXung(a, n) ? "Đây là ma trận đối xứng" : "Không phải ma trận đối xứng");
        }
    }
}