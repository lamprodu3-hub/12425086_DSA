using System;

namespace Buoi01_DeQuy
{
    class Bai3C1
    {
        public static void Chay()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine() ?? "";

            char[] arr = s.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine("Chuoi dao nguoc: " + new string(arr));
        }
    }
}