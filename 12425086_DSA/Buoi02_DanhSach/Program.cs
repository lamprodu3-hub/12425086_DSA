using System;

namespace Buoi02_DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" BUỔI 2 - DANH SÁCH: ");
                Console.WriteLine(" Bài tập áp dụng chương 4:");
                Console.WriteLine(" 1. Mảng một chiều");
                Console.WriteLine(" 2. Quản lý nhân viên");
                Console.WriteLine(" 3. Ma trận vuông");
                Console.WriteLine(" 4. Danh sách liên kết đơn cơ bản");
                Console.WriteLine(" 5. Danh sách liên kết đơn nâng cao");
                Console.WriteLine("Bài tập tự thực hành:");
                // Phần 2 cuối sách Bài th 1 đến th6 có giải sẵn ở sgk 
                Console.WriteLine(" 7. Quản lý nhiệt độ");
                Console.WriteLine(" 8. Thống kê từ");
                Console.WriteLine(" 9. Xử lý số nguyên");
                Console.WriteLine("10. Ma trận xoắn ốc");
                Console.WriteLine("11. Ma trận đặc biệt");
                Console.WriteLine("12. Minesweeper");
                Console.WriteLine("13. Đảo ngược danh sách liên kết");
                Console.WriteLine("14. Gộp hai danh sách đã sắp xếp");
                Console.WriteLine("15. Phát hiện chu trình");
                Console.WriteLine("16. Lịch sử duyệt web");
                Console.WriteLine("17. Playlist nhạc");
                Console.WriteLine("18. Hệ thống đặt hàng");
                Console.WriteLine(" 0. Thoát");
                Console.Write("Chọn: ");
                string chon = Console.ReadLine();
                if (chon == "0") break;

                Console.Clear();
                switch (chon)
                {
                    case "1": Bai1.Chay(); break;
                    case "2": Bai2.Chay(); break;
                    case "3": Bai3.Chay(); break;
                    case "4": Bai4.Chay(); break;
                    case "5": Bai5.Chay(); break;
                    case "7": TH07.Chay(); break;
                    case "8": TH08.Chay(); break;
                    case "9": TH09.Chay(); break;
                    case "10": TH10.Chay(); break;
                    case "11": TH11.Chay(); break;
                    case "12": TH12.Chay(); break;
                    case "13": TH13.Chay(); break;
                    case "14": TH14.Chay(); break;
                    case "15": TH15.Chay(); break;
                    case "16": TH16.Chay(); break;
                    case "17": TH17.Chay(); break;
                    case "18": TH18.Chay(); break;
                    default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
                }
                Console.WriteLine("\n Nhấn phím Enter để quay lại menu...");
                Console.ReadKey();
            }
        }
    }
}