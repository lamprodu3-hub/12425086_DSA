using System;

namespace Buoi02_DanhSach
{
    static class TH18
    {
        class Node
        {
            public int Ma;
            public string KhachHang;
            public int TrangThai;
            public Node Prev;
            public Node Next;
        }

        static string[] TenTT = { "Chờ xử lý", "Đang giao", "Hoàn thành" };
        static Node head, tail;
        static int maTiepTheo;

        static void Them(string khachHang)
        {
            Node moi = new Node();
            moi.Ma = maTiepTheo++;
            moi.KhachHang = khachHang;
            moi.TrangThai = 0;
            if (head == null) head = moi;
            else
            {
                tail.Next = moi;
                moi.Prev = tail;
            }
            tail = moi;
            Console.WriteLine("Đã tạo đơn hàng mã " + moi.Ma);
        }

        static Node Tim(int ma)
        {
            for (Node p = head; p != null; p = p.Next)
                if (p.Ma == ma) return p;
            return null;
        }

        static bool ChuyenTiep(Node p)
        {
            if (p.TrangThai >= 2) return false;
            p.TrangThai++;
            return true;
        }

        static bool QuayLai(Node p)
        {
            if (p.TrangThai <= 0) return false;
            p.TrangThai--;
            return true;
        }

        static void InDong(Node p)
        {
            Console.WriteLine("{0,-6}{1,-20}{2}", p.Ma, p.KhachHang, TenTT[p.TrangThai]);
        }

        static void XemXuoi()
        {
            if (head == null)
            {
                Console.WriteLine("(Chưa có đơn hàng)");
                return;
            }
            Console.WriteLine("{0,-6}{1,-20}{2}", "Mã", "Khách hàng", "Trạng thái");
            for (Node p = head; p != null; p = p.Next) InDong(p);
        }

        static void XemNguoc()
        {
            if (tail == null)
            {
                Console.WriteLine("(Chưa có đơn hàng)");
                return;
            }
            Console.WriteLine("{0,-6}{1,-20}{2}", "Mã", "Khách hàng", "Trạng thái");
            for (Node p = tail; p != null; p = p.Prev) InDong(p);
        }

        static void ChuyenTrangThai(bool tien)
        {
            Console.Write("Nhập mã đơn hàng: ");
            Node p = Tim(int.Parse(Console.ReadLine()));
            if (p == null)
            {
                Console.WriteLine("Không tìm thấy đơn hàng!");
                return;
            }
            bool ok = tien ? ChuyenTiep(p) : QuayLai(p);
            if (ok) Console.WriteLine("Trạng thái mới: " + TenTT[p.TrangThai]);
            else Console.WriteLine("Không thể chuyển, đơn đang ở: " + TenTT[p.TrangThai]);
        }

        public static void Chay()
        {
            head = tail = null;
            maTiepTheo = 1;
            while (true)
            {
                Console.WriteLine("\n--- QUẢN LÝ ĐƠN HÀNG ---");
                Console.WriteLine("1. Thêm đơn hàng (Chờ xử lý)");
                Console.WriteLine("2. Chuyển sang trạng thái tiếp theo");
                Console.WriteLine("3. Quay lại trạng thái trước");
                Console.WriteLine("4. Xem danh sách (cũ đến mới)");
                Console.WriteLine("5. Xem danh sách (mới đến cũ)");
                Console.WriteLine("0. Quay lại menu chính");
                Console.Write("Chọn: ");
                string chon = Console.ReadLine();
                if (chon == "0") return;
                switch (chon)
                {
                    case "1":
                        Console.Write("Tên khách hàng: ");
                        Them(Console.ReadLine());
                        break;
                    case "2": ChuyenTrangThai(true); break;
                    case "3": ChuyenTrangThai(false); break;
                    case "4": XemXuoi(); break;
                    case "5": XemNguoc(); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
            }
        }
    }
}