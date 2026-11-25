using System;

namespace Buoi02_DanhSach
{
    static class Bai4
    {
        class Node
        {
            public int Data;
            public Node Next;
        }

        static Node pHead = null;

        static void ThemCuoi(int x)
        {
            Node moi = new Node();
            moi.Data = x;
            if (pHead == null)
            {
                pHead = moi;
                return;
            }
            Node p = pHead;
            while (p.Next != null) p = p.Next;
            p.Next = moi;
        }

        static void Nhap()
        {
            pHead = null;
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử {0} (số nguyên dương): ", i + 1);
                ThemCuoi(int.Parse(Console.ReadLine()));
            }
        }

        static void Xuat()
        {
            if (pHead == null)
            {
                Console.WriteLine("(Danh sách rỗng)");
                return;
            }
            for (Node p = pHead; p != null; p = p.Next) Console.Write(p.Data + " ");
            Console.WriteLine();
        }

        static int DemX(int x)
        {
            int dem = 0;
            for (Node p = pHead; p != null; p = p.Next)
                if (p.Data == x) dem++;
            return dem;
        }

        static int DuongNhoNhat()
        {
            int min = int.MaxValue;
            for (Node p = pHead; p != null; p = p.Next)
                if (p.Data > 0 && p.Data < min) min = p.Data;
            return min;
        }

        static bool XoaX(int x)
        {
            Node p = pHead, t = null;
            while (p != null && p.Data != x)
            {
                t = p;
                p = p.Next;
            }
            if (p == null) return false;
            if (t == null) pHead = p.Next;
            else t.Next = p.Next;
            return true;
        }

        public static void Chay()
        {
            Nhap();
            Console.Write("Danh sách: ");
            Xuat();

            Console.Write("\na. Nhập x cần đếm: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Có {0} số bằng {1}", DemX(x), x);

            int min = DuongNhoNhat();
            if (min == int.MaxValue) Console.WriteLine("b. Không có phần tử dương");
            else Console.WriteLine("b. Phần tử dương nhỏ nhất: " + min);

            Console.Write("c. Nhập x cần xóa: ");
            int y = int.Parse(Console.ReadLine());
            if (XoaX(y)) Console.WriteLine("Đã xóa {0}", y);
            else Console.WriteLine("Không tìm thấy {0}", y);
            Console.Write("Danh sách sau khi xóa: ");
            Xuat();
        }
    }
}