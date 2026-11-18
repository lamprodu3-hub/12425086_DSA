using System;

namespace Buoi02_DanhSach
{
    static class TH15
    {
        class Node
        {
            public int Data;
            public Node Next;
        }

        static Node Nhap(out Node tail, out int n)
        {
            Console.Write("Nhập số phần tử n: ");
            n = int.Parse(Console.ReadLine());
            Node head = null;
            tail = null;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử {0}: ", i + 1);
                Node moi = new Node();
                moi.Data = int.Parse(Console.ReadLine());
                if (head == null) head = moi;
                else tail.Next = moi;
                tail = moi;
            }
            return head;
        }

        static bool CoChuTrinh(Node head)
        {
            Node rua = head, tho = head;
            while (tho != null && tho.Next != null)
            {
                rua = rua.Next;
                tho = tho.Next.Next;
                if (rua == tho) return true;
            }
            return false;
        }

        public static void Chay()
        {
            Node tail;
            int n;
            Node head = Nhap(out tail, out n);
            if (head == null)
            {
                Console.WriteLine("Danh sách rỗng, không có chu trình.");
                return;
            }

            Console.Write("Danh sách: ");
            for (Node p = head; p != null; p = p.Next) Console.Write(p.Data + " ");
            Console.WriteLine();

            Console.Write("Nối nút cuối về nút thứ k (1 đến {0}, nhập 0 nếu không tạo chu trình): ", n);
            int k = int.Parse(Console.ReadLine());
            if (k < 0 || k > n)
            {
                Console.WriteLine("Giá trị k không hợp lệ!");
                return;
            }
            if (k > 0)
            {
                Node p = head;
                for (int i = 1; i < k; i++) p = p.Next;
                tail.Next = p;
            }

            if (CoChuTrinh(head)) Console.WriteLine("\nDanh sách CÓ chu trình");
            else Console.WriteLine("\nDanh sách KHÔNG có chu trình");
        }
    }
}