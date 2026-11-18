using System;

namespace Buoi02_DanhSach
{
    static class TH16
    {
        class Node
        {
            public string Url;
            public Node Prev;
            public Node Next;
        }

        static Node head, current;

        static void TruyCap(string url)
        {
            Node moi = new Node();
            moi.Url = url;
            if (current == null) head = moi;
            else
            {
                current.Next = moi;
                moi.Prev = current;
            }
            current = moi;
        }

        static void Back()
        {
            if (current == null || current.Prev == null) Console.WriteLine("Không thể quay lại!");
            else current = current.Prev;
        }

        static void Forward()
        {
            if (current == null || current.Next == null) Console.WriteLine("Không thể đi tiếp!");
            else current = current.Next;
        }

        static void XemLichSu()
        {
            if (head == null)
            {
                Console.WriteLine("(Lịch sử trống)");
                return;
            }
            for (Node p = head; p != null; p = p.Next)
            {
                Console.Write(p.Url);
                if (p == current) Console.Write("   <-- trang hiện tại");
                Console.WriteLine();
            }
        }

        public static void Chay()
        {
            head = null;
            current = null;
            while (true)
            {
                Console.WriteLine("\n--- TRÌNH DUYỆT ---");
                Console.WriteLine("Trang hiện tại: " + (current == null ? "(trống)" : current.Url));
                Console.WriteLine("1. Truy cập trang mới");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Xem lịch sử");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Chọn: ");
                string chon = Console.ReadLine();
                if (chon == "0") return;
                switch (chon)
                {
                    case "1":
                        Console.Write("Nhập địa chỉ trang: ");
                        TruyCap(Console.ReadLine());
                        break;
                    case "2": Back(); break;
                    case "3": Forward(); break;
                    case "4": XemLichSu(); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            }
        }
    }
}