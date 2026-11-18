using System;

namespace Buoi02_DanhSach
{
    static class Bai1
    {
        static int[] a;

        static void Nhap()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Xuat()
        {
            Console.WriteLine(string.Join(" ", a));
        }

        static void Chen(int x, int k)
        {
            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < k; i++) tmp[i] = a[i];
            tmp[k] = x;
            for (int i = k; i < a.Length; i++) tmp[i + 1] = a[i];
            a = tmp;
        }

        public static void Chay()
        {
            Nhap();
            Console.Write("Danh sách: ");
            Xuat();

            Console.Write("Nhập x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí k (0 đến {0}): ", a.Length);
            int k = int.Parse(Console.ReadLine());
            if (k < 0 || k > a.Length)
            {
                Console.WriteLine("Vị trí k không hợp lệ!");
                return;
            }
            Chen(x, k);
            Console.Write("Danh sách sau khi chèn: ");
            Xuat();
        }
    }
}