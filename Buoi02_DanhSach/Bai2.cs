using System;

namespace Buoi02_DanhSach
{
    static class Bai2
    {
        struct NhanVien
        {
            public string MaNV;
            public string HoTen;
            public int NamSinh;
            public string PhongBan;
            public int LuongCB;
            public int Thuong;
            public int ThucLinh;
        }

        static NhanVien[] DS;

        static NhanVien Tao(string ma, string ten, int ns, string pb, int luong, int thuong)
        {
            NhanVien nv;
            nv.MaNV = ma;
            nv.HoTen = ten;
            nv.NamSinh = ns;
            nv.PhongBan = pb;
            nv.LuongCB = luong;
            nv.Thuong = thuong;
            nv.ThucLinh = luong + thuong;
            return nv;
        }

        static void KhoiTao()
        {
            DS = new NhanVien[]
            {
                Tao("NV01", "Nguyễn Văn An", 1995, "Kế toán", 8000000, 1500000),
                Tao("NV02", "Trần Thị Bình", 1998, "Nhân sự", 7000000, 1000000),
                Tao("NV03", "Lê Văn Cường", 1990, "Kế toán", 9000000, 1200000),
                Tao("NV04", "Phạm Thị Dung", 1996, "Kỹ thuật", 7000000, 2000000),
                Tao("NV05", "Hoàng Văn Em", 1992, "Nhân sự", 10000000, 800000)
            };
        }

        static void InDong(NhanVien nv)
        {
            Console.WriteLine("{0,-6}{1,-20}{2,-6}{3,-10}{4,12}{5,12}{6,12}",
                nv.MaNV, nv.HoTen, nv.NamSinh, nv.PhongBan, nv.LuongCB, nv.Thuong, nv.ThucLinh);
        }

        static void InDS(NhanVien[] ds)
        {
            Console.WriteLine("{0,-6}{1,-20}{2,-6}{3,-10}{4,12}{5,12}{6,12}",
                "Mã", "Họ tên", "NS", "Phòng", "Lương CB", "Thưởng", "Thực lĩnh");
            foreach (NhanVien nv in ds) InDong(nv);
        }

        static long TongThucLinh()
        {
            long tong = 0;
            foreach (NhanVien nv in DS) tong += nv.ThucLinh;
            return tong;
        }

        static void InLuongThapNhat()
        {
            int min = int.MaxValue;
            foreach (NhanVien nv in DS)
                if (nv.LuongCB < min) min = nv.LuongCB;
            foreach (NhanVien nv in DS)
                if (nv.LuongCB == min) InDong(nv);
        }

        static int DemThuong(int muc)
        {
            int dem = 0;
            foreach (NhanVien nv in DS)
                if (nv.Thuong >= muc) dem++;
            return dem;
        }

        static void InSapXep()
        {
            NhanVien[] ds = (NhanVien[])DS.Clone();
            Array.Sort(ds, (x, y) =>
            {
                int c = string.Compare(x.PhongBan, y.PhongBan);
                if (c != 0) return c;
                return string.Compare(y.MaNV, x.MaNV);
            });
            InDS(ds);
        }

        static void TangLuong()
        {
            for (int i = 0; i < DS.Length; i++)
            {
                DS[i].LuongCB = DS[i].LuongCB * 105 / 100;
                DS[i].ThucLinh = DS[i].LuongCB + DS[i].Thuong;
            }
        }

        public static void Chay()
        {
            KhoiTao();
            Console.WriteLine("Danh sách nhân viên:");
            InDS(DS);

            Console.WriteLine("\na. Tổng thực lĩnh: " + TongThucLinh());

            Console.WriteLine("\nb. Nhân viên có lương cơ bản thấp nhất:");
            InLuongThapNhat();

            Console.WriteLine("\nc. Số nhân viên có thưởng >= 1.200.000: " + DemThuong(1200000));

            Console.WriteLine("\nd. Sắp xếp phòng ban tăng dần, mã NV giảm dần:");
            InSapXep();

            TangLuong();
            Console.WriteLine("\ne. Sau khi tăng lương cơ bản 5%:");
            InDS(DS);
        }
    }
}