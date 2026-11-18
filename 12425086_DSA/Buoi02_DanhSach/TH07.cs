using System;
using System.Globalization;

namespace Buoi02_DanhSach
{
    static class TH07
    {
        static double DocSo()
        {
            string s = Console.ReadLine().Replace(',', '.');
            return double.Parse(s, CultureInfo.InvariantCulture);
        }

        public static void Chay()
        {
            Console.Write("Nhập số ngày n: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("n phải lớn hơn 0!");
                return;
            }

            double[] t = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhiệt độ ngày {0}: ", i + 1);
                t[i] = DocSo();
            }

            int iMax = 0, iMin = 0;
            double tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (t[i] > t[iMax]) iMax = i;
                if (t[i] < t[iMin]) iMin = i;
                tong += t[i];
            }

            Console.WriteLine("\nNgày cao nhất: ngày {0} ({1}°C)", iMax + 1, t[iMax]);
            Console.WriteLine("Ngày thấp nhất: ngày {0} ({1}°C)", iMin + 1, t[iMin]);
            Console.WriteLine("Nhiệt độ trung bình: {0:F2}°C", tong / n);
        }
    }
}