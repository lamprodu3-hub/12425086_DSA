using System;

namespace Buoi02_DanhSach
{
    static class TH17
    {
        class Node
        {
            public string Ten;
            public string CaSi;
            public Node Prev;
            public Node Next;
        }

        static Node head, tail, current;

        static void Them(string ten, string caSi)
        {
            Node moi = new Node();
            moi.Ten = ten;
            moi.CaSi = caSi;
            if (head == null)
            {
                head = tail = current = moi;
                return;
            }
            moi.Prev = tail;
            tail.Next = moi;
            tail = moi;
        }

        static Node Tim(string ten)
        {
            for (Node p = head; p != null; p = p.Next)
                if (string.Equals(p.Ten, ten, StringComparison.OrdinalIgnoreCase)) return p;
            return null;
        }

        static bool Xoa(string ten)
        {
            Node p = Tim(ten);
            if (p == null) return false;
            if (p.Prev != null) p.Prev.Next = p.Next;
            else head = p.Next;
            if (p.Next != null) p.Next.Prev = p.Prev;
            else tail = p.Prev;
            if (p == current) current = (p.Next != null) ? p.Next : p.Prev;
            return true;
        }

        static void Next()
        {
            if (current == null || current.Next == null) Console.WriteLine("Đang ở bài cuối playlist!");
            else current = current.Next;
        }

        static void Previous()
        {
            if (current == null || current.Prev == null) Console.WriteLine("Đang ở bài đầu playlist!");
            else current = current.Prev;
        }

        static void XemPlaylist()
        {
            if (head == null)
            {
                Console.WriteLine("(Playlist trống)");
                return;
            }
            for (Node p = head; p != null; p = p.Next)
                Console.WriteLine("{0} {1} - {2}", p == current ? ">" : " ", p.Ten, p.CaSi);
        }

        public static void Chay()
        {
            head = tail = current = null;
            while (true)
            {
                Console.WriteLine("\n--- PLAYLIST ---");
                if (current == null) Console.WriteLine("Đang phát: (chưa có bài hát)");
                else Console.WriteLine("Đang phát: {0} - {1}", current.Ten, current.CaSi);
                Console.WriteLine("1. Thêm bài hát");
                Console.WriteLine("2. Xóa bài hát");
                Console.WriteLine("3. Next");
                Console.WriteLine("4. Previous");
                Console.WriteLine("5. Xem playlist");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Chọn: ");
                string chon = Console.ReadLine();
                if (chon == "0") return;
                switch (chon)
                {
                    case "1":
                        Console.Write("Tên bài hát: ");
                        string ten = Console.ReadLine();
                        Console.Write("Ca sĩ: ");
                        Them(ten, Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Nhập tên bài cần xóa: ");
                        if (Xoa(Console.ReadLine())) Console.WriteLine("Đã xóa!");
                        else Console.WriteLine("Không tìm thấy bài hát!");
                        break;
                    case "3": Next(); break;
                    case "4": Previous(); break;
                    case "5": XemPlaylist(); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            }
        }
    }
}