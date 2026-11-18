using System;

namespace Buoi02_DanhSach
{
    static class TH12
    {
        public static void Chay()
        {
            Console.Write("Nhập số dòng m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số mìn k: ");
            int k = int.Parse(Console.ReadLine());
            if (m <= 0 || n <= 0 || k < 0 || k > m * n)
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                return;
            }

            bool[,] min = new bool[m, n];
            Random rd = new Random();
            int dat = 0;
            while (dat < k)
            {
                int i = rd.Next(m), j = rd.Next(n);
                if (!min[i, j])
                {
                    min[i, j] = true;
                    dat++;
                }
            }

            int[,] so = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (min[i, j]) continue;
                    for (int di = -1; di <= 1; di++)
                        for (int dj = -1; dj <= 1; dj++)
                        {
                            int x = i + di, y = j + dj;
                            if (x >= 0 && x < m && y >= 0 && y < n && min[x, y]) so[i, j]++;
                        }
                }

            Console.WriteLine("\nBảng Minesweeper (* là mìn, . là ô không có mìn xung quanh):");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    char c;
                    if (min[i, j]) c = '*';
                    else if (so[i, j] == 0) c = '.';
                    else c = (char)('0' + so[i, j]);
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}