using System;

namespace Buoi02_DanhSach
{
    static class Bai5
    {
        class Node
        {
            public int Data;
            public Node Next;
        }

        static Node l = null;

        static void ThemCuoi(int x)
        {
            Node moi = new Node();
            moi.Data = x;
            if (l == null)
            {
                l = moi;
                return;
            }
            Node p = l;
            while (p.Next != null) p = p.Next;
            p.Next = moi;
        }

        static void Nhap()
        {
            l = null;
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử {0}: ", i + 1);
                ThemCuoi(int.Parse(Console.ReadLine()));
            }
        }

        static void Xuat()
        {
            for (Node p = l; p != null; p = p.Next) Console.Write(p.Data + " ");
            Console.WriteLine();
        }

        static int Max()
        {
            int max = int.MinValue;
            for (Node p = l; p != null; p = p.Next)
                if (p.Data > max) max = p.Data;
            return max;
        }

        static long Tong()
        {
            long s = 0;
            for (Node p = l; p != null; p = p.Next) s += p.Data;
            return s;
        }

        static bool KTNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
                if (x % i == 0) return false;
            return true;
        }

        static int DemNguyenTo()
        {
            int dem = 0;
            for (Node p = l; p != null; p = p.Next)
                if (KTNT(p.Data)) dem++;
            return dem;
        }

        static void DemDau(out int am, out int khong, out int duong)
        {
            am = 0; khong = 0; duong = 0;
            for (Node p = l; p != null; p = p.Next)
            {
                if (p.Data < 0) am++;
                else if (p.Data == 0) khong++;
                else duong++;
            }
        }

        static int DemX(int x)
        {
            int dem = 0;
            for (Node p = l; p != null; p = p.Next)
                if (p.Data == x) dem++;
            return dem;
        }

        static int DuongNhoNhat()
        {
            int min = int.MaxValue;
            for (Node p = l; p != null; p = p.Next)
                if (p.Data > 0 && p.Data < min) min = p.Data;
            return min;
        }

        public static void Chay()
        {
            Nhap();
            if (l == null)
            {
                Console.WriteLine("Danh sách rỗng!");
                return;
            }
            Console.Write("Danh sách: ");
            Xuat();

            Console.WriteLine("\na. Phần tử lớn nhất: " + Max());
            Console.WriteLine("b. Tổng các phần tử: " + Tong());
            Console.WriteLine("c. Số lượng số nguyên tố: " + DemNguyenTo());

            int am, khong, duong;
            DemDau(out am, out khong, out duong);
            Console.WriteLine("d. Số âm: {0}, số 0: {1}, số dương: {2}", am, khong, duong);

            Console.Write("e. Nhập x cần đếm: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Có {0} số bằng {1}", DemX(x), x);

            int min = DuongNhoNhat();
            if (min == int.MaxValue) Console.WriteLine("f. Không có phần tử dương");
            else Console.WriteLine("f. Phần tử dương nhỏ nhất: " + min);
        }
    }
}