using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi02_DanhSach
{
    static class TH08
    {
        static string ChuanHoa(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s.ToLower())
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)) sb.Append(c);
            return sb.ToString();
        }

        public static void Chay()
        {
            Console.WriteLine("Nhập chuỗi văn bản:");
            string s = Console.ReadLine();
            string[] tu = ChuanHoa(s).Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dem = new Dictionary<string, int>();
            foreach (string w in tu)
            {
                if (dem.ContainsKey(w)) dem[w]++;
                else dem[w] = 1;
            }

            List<KeyValuePair<string, int>> ds = new List<KeyValuePair<string, int>>(dem);
            ds.Sort((x, y) =>
            {
                int c = y.Value.CompareTo(x.Value);
                if (c != 0) return c;
                return string.Compare(x.Key, y.Key);
            });

            Console.WriteLine("\n{0,-20}{1}", "Từ", "Số lần");
            foreach (KeyValuePair<string, int> kv in ds)
                Console.WriteLine("{0,-20}{1}", kv.Key, kv.Value);
        }
    }
}