using System;
using System.Collections.Generic;

namespace Buoi02_DanhSach
{
    static class TH09
    {
        static bool NguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0) return false;
            return true;
        }

        static bool HoanHao(int x)
        {
            if (x < 2) return false;
            int tong = 1;
            for (int i = 2; i <= x / 2; i++)
                if (x % i == 0) tong += i;
            return tong == x;
        }

        static void In(string tieuDe, List<int> ds)
        {
            Console.Write(tieuDe + ": ");
            if (ds.Count == 0) Console.WriteLine("(không có)");
            else Console.WriteLine(string.Join(" ", ds));
        }

        public static void Chay()
        {
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            List<int> nguyenTo = new List<int>();
            List<int> chan = new List<int>();
            List<int> hoanHao = new List<int>();
            foreach (int x in a)
            {
                if (NguyenTo(x)) nguyenTo.Add(x);
                if (x % 2 == 0) chan.Add(x);
                if (HoanHao(x)) hoanHao.Add(x);
            }

            Console.WriteLine();
            In("Số nguyên tố", nguyenTo);
            In("Số chẵn", chan);
            In("Số hoàn hảo", hoanHao);
        }
    }
}