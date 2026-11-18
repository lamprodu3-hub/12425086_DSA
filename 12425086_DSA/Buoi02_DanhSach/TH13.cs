using System;

namespace Buoi02_DanhSach
{
    static class TH13
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
                Console.Write("Phần tử {0}: ", i + 1);
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

        static Node DaoNguoc(Node head)
        {
            Node prev = null, current = head;
            while (current != null)
            {
                Node next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        public static void Chay()
        {
            Node head = Nhap();
            Console.Write("Danh sách ban đầu: ");
            Xuat(head);

            head = DaoNguoc(head);
            Console.Write("Danh sách sau khi đảo ngược: ");
            Xuat(head);
        }
    }
}