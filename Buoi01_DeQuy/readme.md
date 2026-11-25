# Buổi 01 – Đệ quy (Recursion)


## Bài đã làm
Gồm 3 phần (C1, C2, C3) với tổng cộng 18 bài tập về giải thuật đệ quy trong C#:
- **Phần C1 (Cơ bản):** Bài 1 đến Bài 5 (`Bai1C1.cs` – `Bai5C1.cs`)
- **Phần C2 (Nâng cao / Ứng dụng):** Bài 1 đến Bài 5 (`Bai1C2.cs` – `Bai5C2.cs`)
- **Phần C3 (Luyện tập tổng hợp):** Bài 1 đến Bài 8 (`Bai1C3.cs` – `Bai8C3.cs`)

---

## Chi tiết từng bài tập (Code, Đặc điểm hàm & Kết quả chạy)

---

### PHẦN C1 – ĐỆ QUY CƠ BẢN

#### Bài 1 (`Bai1C1.cs`) – Tính giai thừa $n!$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Hàm đệ quy tuyến tính: `static long GiaiThua(int n)`
  * **Đầu vào (Input):** Số nguyên `int n` ($n \ge 0$).
  * **Đầu ra (Output):** Kiểu `long` (tránh tràn số khi $n$ lớn, tối đa $20!$).
  * **Điểm dừng (Base case):** `if (n == 0 || n == 1) return 1;`
  * **Bước đệ quy:** `return n * GiaiThua(n - 1);`
* **Code minh họa:**
```csharp
static long GiaiThua(int n)
{
    if (n <= 1) return 1;
    return n * GiaiThua(n - 1);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập số nguyên dương n: 5
Kết quả 5! = 120
```

#### Bài 2 (`Bai2C1.cs`) – Tính tổng cấp số cộng $S(n) = 1 + 2 + \dots + n$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Hàm đệ quy tuyến tính: `static int Tong(int n)`
  * **Đầu vào:** `int n` ($n \ge 1$).
  * **Đầu ra:** `int` (tổng các số từ $1$ đến $n$).
  * **Điểm dừng:** `if (n == 1) return 1;`
* **Code minh họa:**
```csharp
static int Tong(int n)
{
    if (n <= 1) return n;
    return n + Tong(n - 1);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập n: 10
Tổng S(10) = 55
```

#### Bài 3 (`Bai3C1.cs`) – Tính lũy thừa $x^n$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Hàm đệ quy: `static double LuyThua(double x, int n)`
  * **Đầu vào:** Cơ số thực `double x`, số mũ nguyên `int n`.
  * **Đầu ra:** `double` (hỗ trợ cả số mũ âm nếu mở rộng điều kiện $n < 0$).
  * **Điểm dừng:** `if (n == 0) return 1;`
* **Code minh họa:**
```csharp
static double LuyThua(double x, int n)
{
    if (n == 0) return 1;
    if (n < 0) return 1.0 / LuyThua(x, -n);
    return x * LuyThua(x, n - 1);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập cơ số x: 2
Nhập số mũ n: 5
Kết quả 2^5 = 32
```

#### Bài 4 (`Bai4C1.cs`) – Tìm số Fibonacci thứ $n$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Hàm đệ quy nhị phân: `static long Fibonacci(int n)`
  * **Đầu vào:** Vị trí `int n` ($n \ge 0$).
  * **Đầu ra:** `long`.
  * **Đặc điểm:** Mỗi lần gọi hàm phân nhánh thành 2 lời gọi đệ quy con `Fibonacci(n - 1) + Fibonacci(n - 2)`, độ phức tạp thời gian $O(2^n)$.
* **Code minh họa:**
```csharp
static long Fibonacci(int n)
{
    if (n <= 1) return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập n: 7
Số Fibonacci thứ 7 là: 13
```

#### Bài 5 (`Bai5C1.cs`) – Tìm ước chung lớn nhất (UCLN) bằng thuật toán Euclid
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Hàm đệ quy đuôi (Tail Recursion): `static int UCLN(int a, int b)`
  * **Đầu vào:** Hai số nguyên `int a, int b`.
  * **Đầu ra:** `int` (UCLN của $a$ và $b$).
  * **Điểm dừng:** `if (b == 0) return Math.Abs(a);`
* **Code minh họa:**
```csharp
static int UCLN(int a, int b)
{
    if (b == 0) return Math.Abs(a);
    return UCLN(b, a % b);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập a: 48
Nhập b: 18
Ước chung lớn nhất: 6
```

---

### PHẦN C2 – 

#### Bài 1 (`Bai1C2.cs`) – Bài toán Tháp Hà Nội (Tower of Hanoi)
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Thủ tục đệ quy (không trả về giá trị): `static void ThapHaNoi(int n, char cotNguon, char cotTrungGian, char cotDich)`
  * **Đầu vào:** Số đĩa `int n`, tên 3 cột kiểu `char`.
  * **Đầu ra:** `void` (in trực tiếp các bước chuyển đĩa ra màn hình Console).
  * **Đặc điểm:** Đệ quy phi tuyến, tổng số bước di chuyển luôn là $2^n - 1$.
* **Code minh họa:**
```csharp
static void ThapHaNoi(int n, char a, char b, char c)
{
    if (n == 1)
    {
        Console.WriteLine($"Chuyển đĩa 1 từ {a} sang {c}");
        return;
    }
    ThapHaNoi(n - 1, a, c, b);
    Console.WriteLine($"Chuyển đĩa {n} từ {a} sang {c}");
    ThapHaNoi(n - 1, b, a, c);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập số đĩa n: 3
Chuyển đĩa 1 từ A sang C
Chuyển đĩa 2 từ A sang B
Chuyển đĩa 1 từ C sang B
Chuyển đĩa 3 từ A sang C
Chuyển đĩa 1 từ B sang A
Chuyển đĩa 2 từ B sang C
Chuyển đĩa 1 từ A sang C
```

#### Bài 2 (`Bai2C2.cs`) – Tìm kiếm nhị phân đệ quy (Binary Search)
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Hàm đệ quy chia để trị: `static int BinarySearch(int[] arr, int left, int right, int x)`
  * **Đầu vào:** Mảng đã sắp xếp `int[] arr`, chỉ số biên `int left`, `int right`, giá trị cần tìm `int x`.
  * **Đầu ra:** `int` (chỉ số của `x` trong mảng, hoặc `-1` nếu không tìm thấy).
  * **Đặc điểm:** Mỗi bước giảm không gian tìm kiếm đi một nửa, độ phức tạp $O(\log n)$.
* **Code minh họa:**
```csharp
static int BinarySearch(int[] arr, int left, int right, int x)
{
    if (left > right) return -1;
    int mid = left + (right - left) / 2;
    if (arr[mid] == x) return mid;
    if (arr[mid] > x) return BinarySearch(arr, left, mid - 1, x);
    return BinarySearch(arr, mid + 1, right, x);
}
```
* **Kết quả chạy mẫu:**
```text
Mảng đã sắp xếp: 2 5 8 12 16 23 38 56
Nhập giá trị x cần tìm: 23
Tìm thấy 23 tại vị trí chỉ số: 5
```

#### Bài 3 (`Bai3C2.cs`) – Chuyển đổi hệ cơ số (Thập phân sang Nhị phân)
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Hàm đệ quy: `static void DecToBin(int n)`
  * **Đầu vào:** Số nguyên không âm `int n`.
  * **Đầu ra:** `void` (tận dụng ngăn xếp lời gọi hàm - Call Stack để in số dư từ dưới lên).
* **Code minh họa:**
```csharp
static void DecToBin(int n)
{
    if (n > 1) DecToBin(n / 2);
    Console.Write(n % 2);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập số thập phân: 13
Dạng nhị phân: 1101
```

#### Bài 4 (`Bai4C2.cs`) – Các thao tác đệ quy trên mảng một chiều
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Tập hợp các hàm xử lý mảng `int[] a` với kích thước `int n`:
    * `static int TongMang(int[] a, int n)` $\rightarrow$ Trả về `int`.
    * `static int TimMax(int[] a, int n)` $\rightarrow$ Trả về `int`.
    * `static bool KiemTraDoiXung(int[] a, int left, int right)` $\rightarrow$ Trả về `bool`.
* **Code minh họa:**
```csharp
static int TongMang(int[] a, int n)
{
    if (n <= 0) return 0;
    return a[n - 1] + TongMang(a, n - 1);
}

static int TimMax(int[] a, int n)
{
    if (n == 1) return a[0];
    int maxRest = TimMax(a, n - 1);
    return a[n - 1] > maxRest ? a[n - 1] : maxRest;
}
```
* **Kết quả chạy mẫu:**
```text
Nhập số phần tử n: 5
a[0] = 4
a[1] = 9
a[2] = 2
a[3] = 9
a[4] = 4
Tổng các phần tử: 28
Phần tử lớn nhất: 9
Mảng đối xứng: True
```

#### Bài 5 (`Bai5C2.cs`) – Sinh hoán vị / Quay lui cơ bản (Backtracking)
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * Hàm đệ quy quay lui: `static void SinhHoanVi(int k, int n, int[] x, bool[] used)`
  * **Đầu vào:** Bước hiện tại `int k`, giới hạn `int n`, mảng lưu cấu hình `int[] x`, mảng đánh dấu `bool[] used`.
  * **Đầu ra:** `void` (liệt kê toàn bộ $n!$ hoán vị).
* **Code minh họa:**
```csharp
static void SinhHoanVi(int k, int n, int[] x, bool[] used)
{
    for (int i = 1; i <= n; i++)
    {
        if (!used[i])
        {
            x[k] = i;
            used[i] = true;
            if (k == n) Console.WriteLine(string.Join(" ", x, 1, n));
            else SinhHoanVi(k + 1, n, x, used);
            used[i] = false; // Quay lui
        }
    }
}
```
* **Kết quả chạy mẫu:**
```text
Nhập n: 3
1 2 3
1 3 2
2 1 3
2 3 1
3 1 2
3 2 1
```

---

### PHẦN C3 – 

#### Bài 1 (`Bai1C3.cs`) – Đếm số chữ số của số nguyên dương $n$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * `static int DemChuSo(int n)` | Input: `int n` | Output: `int`
  * Điểm dừng: `if (n < 10) return 1;`
* **Code minh họa:**
```csharp
static int DemChuSo(int n)
{
    if (n < 10) return 1;
    return 1 + DemChuSo(n / 10);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập số nguyên dương n: 2026
Số chữ số là: 4
```

#### Bài 2 (`Bai2C3.cs`) – Tính tổng các chữ số của $n$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * `static int TongChuSo(int n)` | Input: `int n` | Output: `int`
  * Công thức đệ quy: `(n % 10) + TongChuSo(n / 10)`
* **Code minh họa:**
```csharp
static int TongChuSo(int n)
{
    if (n == 0) return 0;
    return (n % 10) + TongChuSo(n / 10);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập n: 12345
Tổng các chữ số: 15
```

#### Bài 3 (`Bai3C3.cs`) – Tìm chữ số lớn nhất của số nguyên dương $n$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * `static int ChuSoMax(int n)` | Input: `int n` | Output: `int`
  * Đặc điểm: So sánh chữ số hàng đơn vị `n % 10` với kết quả đệ quy phần còn lại `ChuSoMax(n / 10)`.
* **Code minh họa:**
```csharp
static int ChuSoMax(int n)
{
    if (n < 10) return n;
    int maxRest = ChuSoMax(n / 10);
    return (n % 10) > maxRest ? (n % 10) : maxRest;
}
```
* **Kết quả chạy mẫu:**
```text
Nhập n: 38291
Chữ số lớn nhất: 9
```

#### Bài 4 (`Bai4C3.cs`) – Tính tổng đan dấu / chuỗi phân số $S(n) = 1 + \frac{1}{2} + \frac{1}{3} + \dots + \frac{1}{n}$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * `static double TongPhanSo(int n)` | Input: `int n` | Output: `double` (ép kiểu `1.0 / n` để tránh phép chia lấy nguyên).
* **Code minh họa:**
```csharp
static double TongPhanSo(int n)
{
    if (n == 1) return 1.0;
    return (1.0 / n) + TongPhanSo(n - 1);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập n: 4
Tổng S(4) = 2.0833
```

#### Bài 5 (`Bai5C3.cs`) – Đảo ngược chuỗi ký tự bằng đệ quy
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * `static string DaoChuoi(string s)` | Input: `string s` | Output: `string`
  * Điểm dừng: `if (s.Length <= 1) return s;`
* **Code minh họa:**
```csharp
static string DaoChuoi(string s)
{
    if (s.Length <= 1) return s;
    return s[s.Length - 1] + DaoChuoi(s.Substring(0, s.Length - 1));
}
```
* **Kết quả chạy mẫu:**
```text
Nhập chuỗi: DeQuyCSharp
Chuỗi đảo ngược: prahSCyuQeD
```

#### Bài 6 (`Bai6C3.cs`) – Kiểm tra chuỗi đối xứng (Palindrome)
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * `static bool LaPalindrome(string s, int left, int right)` | Input: `string s`, `int left`, `int right` | Output: `bool`
  * Đặc điểm: So sánh 2 ký tự ngoài cùng và thu hẹp dần vào tâm `(left + 1, right - 1)`.
* **Code minh họa:**
```csharp
static bool LaPalindrome(string s, int left, int right)
{
    if (left >= right) return true;
    if (s[left] != s[right]) return false;
    return LaPalindrome(s, left + 1, right - 1);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập chuỗi: radar
Kết quả: Là chuỗi đối xứng
```

#### Bài 7 (`Bai7C3.cs`) – Tính tổ hợp chập $k$ của $n$: $C(n, k)$
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * `static int ToHop(int n, int k)` | Input: `int n, int k` | Output: `int`
  * Công thức Pascal: $C(n, k) = C(n-1, k-1) + C(n-1, k)$.
  * Điểm dừng: `if (k == 0 || k == n) return 1;`
* **Code minh họa:**
```csharp
static int ToHop(int n, int k)
{
    if (k == 0 || k == n) return 1;
    return ToHop(n - 1, k - 1) + ToHop(n - 1, k);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập n: 5
Nhập k: 2
Tổ hợp C(5, 2) = 10
```

#### Bài 8 (`Bai8C3.cs`) – Tính tổng các số chẵn trong mảng một chiều
* **Đặc điểm hàm & Kiểu dữ liệu:**
  * `static int TongChan(int[] a, int n)` | Input: `int[] a`, `int n` | Output: `int`
  * Đặc điểm: Kiểm tra điều kiện `a[n - 1] % 2 == 0` trước khi cộng dồn vào lời gọi đệ quy.
* **Code minh họa:**
```csharp
static int TongChan(int[] a, int n)
{
    if (n <= 0) return 0;
    int val = (a[n - 1] % 2 == 0) ? a[n - 1] : 0;
    return val + TongChan(a, n - 1);
}
```
* **Kết quả chạy mẫu:**
```text
Nhập số phần tử n: 5
a[0] = 1
a[1] = 4
a[2] = 7
a[3] = 6
a[4] = 2
Tổng các phần tử chẵn: 12
```