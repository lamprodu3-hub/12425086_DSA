using System;

namespace Buoi02_DanhSach
{
    static class TH14
    {
        class Node
        {
            public int Data;
            public Node Next;
        }

        static Node Nhap()
        {
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            Node head = null, tail = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử {0} (nhập tăng dần): ", i + 1);
                Node moi = new Node();
                moi.Data = int.Parse(Console.ReadLine());
                if (head == null) head = moi;
                else tail.Next = moi;
                tail = moi;
            }
            return head;
        }

        static void Xuat(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("(Danh sách rỗng)");
                return;
            }
            for (Node p = head; p != null; p = p.Next) Console.Write(p.Data + " ");
            Console.WriteLine();
        }

        static bool TangDan(Node head)
        {
            for (Node p = head; p != null && p.Next != null; p = p.Next)
                if (p.Data > p.Next.Data) return false;
            return true;
        }

        static Node Gop(Node a, Node b)
        {
            Node dau = new Node();
            Node duoi = dau;
            while (a != null && b != null)
            {
                if (a.Data <= b.Data)
                {
                    duoi.Next = a;
                    a = a.Next;
                }
                else
                {
                    duoi.Next = b;
                    b = b.Next;
                }
                duoi = duoi.Next;
            }
            duoi.Next = (a != null) ? a : b;
            return dau.Next;
        }

        public static void Chay()
        {
            Console.WriteLine("--- Danh sách 1 ---");
            Node l1 = Nhap();
            Console.WriteLine("--- Danh sách 2 ---");
            Node l2 = Nhap();

            if (!TangDan(l1) || !TangDan(l2))
            {
                Console.WriteLine("Hai danh sách phải được sắp xếp tăng dần!");
                return;
            }

            Console.Write("\nDanh sách 1: ");
            Xuat(l1);
            Console.Write("Danh sách 2: ");
            Xuat(l2);

            Node kq = Gop(l1, l2);
            Console.Write("Danh sách sau khi gộp: ");
            Xuat(kq);
        }
    }
}