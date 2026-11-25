# Buổi 02 – Danh sách

Họ tên: ................ · MSV: ................ · Lớp: ................

## Bài đã làm
Bài 1, 2, 3, 4, 5 và TH07 đến TH18 (đủ 17 bài trong menu chương trình).

## Cách chạy
```
dotnet run --project Buoi02_DanhSach
```
Chương trình hiện menu, nhập số của bài muốn chạy (1 đến 5, 7 đến 18), nhấn Enter. Chọn 0 để thoát.

## Kết quả chạy

Mỗi bài chạy với một bộ dữ liệu mẫu. Các dòng sau dấu `:` hoặc `=` ở phần nhập là dữ liệu đã gõ vào.

### Bài 1 – Mảng một chiều
```
Nhập n: 5
a[0] = 10
a[1] = 20
a[2] = 30
a[3] = 40
a[4] = 50
Danh sách: 10 20 30 40 50
Nhập x cần chèn: 99
Nhập vị trí k (0 đến 5): 2
Danh sách sau khi chèn: 10 20 99 30 40 50
```

### Bài 2 – Quản lý nhân viên
```
Danh sách nhân viên:
Mã    Họ tên              NS    Phòng         Lương CB      Thưởng   Thực lĩnh
NV01  Nguyễn Văn An       1995  Kế toán        8000000     1500000     9500000
NV02  Trần Thị Bình       1998  Nhân sự        7000000     1000000     8000000
NV03  Lê Văn Cường        1990  Kế toán        9000000     1200000    10200000
NV04  Phạm Thị Dung       1996  Kỹ thuật       7000000     2000000     9000000
NV05  Hoàng Văn Em        1992  Nhân sự       10000000      800000    10800000

a. Tổng thực lĩnh: 47500000

b. Nhân viên có lương cơ bản thấp nhất:
NV02  Trần Thị Bình       1998  Nhân sự        7000000     1000000     8000000
NV04  Phạm Thị Dung       1996  Kỹ thuật       7000000     2000000     9000000

c. Số nhân viên có thưởng >= 1.200.000: 3

d. Sắp xếp phòng ban tăng dần, mã NV giảm dần:
Mã    Họ tên              NS    Phòng         Lương CB      Thưởng   Thực lĩnh
NV03  Lê Văn Cường        1990  Kế toán        9000000     1200000    10200000
NV01  Nguyễn Văn An       1995  Kế toán        8000000     1500000     9500000
NV04  Phạm Thị Dung       1996  Kỹ thuật       7000000     2000000     9000000
NV05  Hoàng Văn Em        1992  Nhân sự       10000000      800000    10800000
NV02  Trần Thị Bình       1998  Nhân sự        7000000     1000000     8000000

e. Sau khi tăng lương cơ bản 5%:
Mã    Họ tên              NS    Phòng         Lương CB      Thưởng   Thực lĩnh
NV01  Nguyễn Văn An       1995  Kế toán        8400000     1500000     9900000
NV02  Trần Thị Bình       1998  Nhân sự        7350000     1000000     8350000
NV03  Lê Văn Cường        1990  Kế toán        9450000     1200000    10650000
NV04  Phạm Thị Dung       1996  Kỹ thuật       7350000     2000000     9350000
NV05  Hoàng Văn Em        1992  Nhân sự       10500000      800000    11300000
```

### Bài 3 – Ma trận vuông
```
Nhập n (0 <= n < 100): 3
a[0,0] = 1
a[0,1] = 2
a[0,2] = 3
a[1,0] = 4
a[1,1] = 5
a[1,2] = 6
a[2,0] = 7
a[2,1] = 8
a[2,2] = 9

Ma trận:
    1    2    3
    4    5    6
    7    8    9

a. Tổng các phần tử: 45
b. Giá trị dương nhỏ nhất: 1
c. Tổng đường chéo phụ: 15
d. Đường chéo chính tăng dần
```

### Bài 4 – Danh sách liên kết đơn cơ bản
```
Nhập số phần tử n: 5
Phần tử 1 (số nguyên dương): 3
Phần tử 2 (số nguyên dương): 5
Phần tử 3 (số nguyên dương): 3
Phần tử 4 (số nguyên dương): 8
Phần tử 5 (số nguyên dương): 1
Danh sách: 3 5 3 8 1 

a. Nhập x cần đếm: 3
Có 2 số bằng 3
b. Phần tử dương nhỏ nhất: 1
c. Nhập x cần xóa: 5
Đã xóa 5
Danh sách sau khi xóa: 3 3 8 1 
```

### Bài 5 – Danh sách liên kết đơn nâng cao
```
Nhập số phần tử n: 6
Phần tử 1: 2
Phần tử 2: -3
Phần tử 3: 0
Phần tử 4: 7
Phần tử 5: 2
Phần tử 6: 10
Danh sách: 2 -3 0 7 2 10 

a. Phần tử lớn nhất: 10
b. Tổng các phần tử: 18
c. Số lượng số nguyên tố: 3
d. Số âm: 1, số 0: 1, số dương: 4
e. Nhập x cần đếm: 2
Có 2 số bằng 2
f. Phần tử dương nhỏ nhất: 2
```

### TH07 – Quản lý nhiệt độ
```
Nhập số ngày n: 5
Nhiệt độ ngày 1: 30,5
Nhiệt độ ngày 2: 32
Nhiệt độ ngày 3: 28,5
Nhiệt độ ngày 4: 35
Nhiệt độ ngày 5: 31

Ngày cao nhất: ngày 4 (35°C)
Ngày thấp nhất: ngày 3 (28.5°C)
Nhiệt độ trung bình: 31.40°C
```

### TH08 – Thống kê từ
```
Nhập chuỗi văn bản:
Xin chào, xin chào các bạn! Học lập trình rất vui, học mỗi ngày.

Từ                  Số lần
chào                2
học                 2
xin                 2
bạn                 1
các                 1
lập                 1
mỗi                 1
ngày                1
rất                 1
trình               1
vui                 1
```

### TH09 – Xử lý số nguyên
```
Nhập số phần tử n: 6
a[0] = 2
a[1] = 6
a[2] = 7
a[3] = 28
a[4] = 9
a[5] = 10

Số nguyên tố: 2 7
Số chẵn: 2 6 28 10
Số hoàn hảo: 6 28
```

### TH10 – Ma trận xoắn ốc
```
Nhập số dòng m: 3
Nhập số cột n: 4
a[0,0] = 1
a[0,1] = 2
a[0,2] = 3
a[0,3] = 4
a[1,0] = 5
a[1,1] = 6
a[1,2] = 7
a[1,3] = 8
a[2,0] = 9
a[2,1] = 10
a[2,2] = 11
a[2,3] = 12

Ma trận:
    1    2    3    4
    5    6    7    8
    9   10   11   12

Thứ tự xoắn ốc: 1 2 3 4 8 12 11 10 9 5 6 7 
```

### TH11 – Ma trận đặc biệt
```
Nhập cấp n của ma trận vuông: 3
a[0,0] = 1
a[0,1] = 0
a[0,2] = 0
a[1,0] = 0
a[1,1] = 1
a[1,2] = 0
a[2,0] = 0
a[2,1] = 0
a[2,2] = 1

Ma trận:
    1    0    0
    0    1    0
    0    0    1

Đây là ma trận đơn vị
Đây là ma trận đối xứng
```

### TH12 – Minesweeper
```
Nhập số dòng m: 5
Nhập số cột n: 6
Nhập số mìn k: 6

Bảng Minesweeper (* là mìn, . là ô không có mìn xung quanh):
. 2 * 2 . . 
1 3 * 2 . . 
2 * 2 2 1 1 
* 2 2 2 * 1 
1 1 1 * 2 1 
```

### TH13 – Đảo ngược danh sách liên kết
```
Nhập số phần tử n: 5
Phần tử 1: 1
Phần tử 2: 2
Phần tử 3: 3
Phần tử 4: 4
Phần tử 5: 5
Danh sách ban đầu: 1 2 3 4 5 
Danh sách sau khi đảo ngược: 5 4 3 2 1 
```

### TH14 – Gộp hai danh sách đã sắp xếp
```
--- Danh sách 1 ---
Nhập số phần tử n: 3
Phần tử 1 (nhập tăng dần): 1
Phần tử 2 (nhập tăng dần): 3
Phần tử 3 (nhập tăng dần): 5
--- Danh sách 2 ---
Nhập số phần tử n: 4
Phần tử 1 (nhập tăng dần): 2
Phần tử 2 (nhập tăng dần): 4
Phần tử 3 (nhập tăng dần): 6
Phần tử 4 (nhập tăng dần): 8

Danh sách 1: 1 3 5 
Danh sách 2: 2 4 6 8 
Danh sách sau khi gộp: 1 2 3 4 5 6 8 
```

### TH15 – Phát hiện chu trình
```
Nhập số phần tử n: 4
Phần tử 1: 1
Phần tử 2: 2
Phần tử 3: 3
Phần tử 4: 4
Danh sách: 1 2 3 4 
Nối nút cuối về nút thứ k (1 đến 4, nhập 0 nếu không tạo chu trình): 2

Danh sách CÓ chu trình
```

### TH16 – Lịch sử duyệt web
```
--- TRÌNH DUYỆT ---
Trang hiện tại: (trống)
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 1
Nhập địa chỉ trang: google.com

--- TRÌNH DUYỆT ---
Trang hiện tại: google.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 1
Nhập địa chỉ trang: youtube.com

--- TRÌNH DUYỆT ---
Trang hiện tại: youtube.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 1
Nhập địa chỉ trang: github.com

--- TRÌNH DUYỆT ---
Trang hiện tại: github.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 4
google.com
youtube.com
github.com   <-- trang hiện tại

--- TRÌNH DUYỆT ---
Trang hiện tại: github.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 2

--- TRÌNH DUYỆT ---
Trang hiện tại: youtube.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 2

--- TRÌNH DUYỆT ---
Trang hiện tại: google.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 3

--- TRÌNH DUYỆT ---
Trang hiện tại: youtube.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 4
google.com
youtube.com   <-- trang hiện tại
github.com

--- TRÌNH DUYỆT ---
Trang hiện tại: youtube.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 3

--- TRÌNH DUYỆT ---
Trang hiện tại: github.com
1. Truy cập trang mới
2. Back
3. Forward
4. Xem lịch sử
0. Quay lại menu chính
Chọn: 0
```

### TH17 – Playlist nhạc
```
--- PLAYLIST ---
Đang phát: (chưa có bài hát)
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 1
Tên bài hát: Em của ngày hôm qua
Ca sĩ: Sơn Tùng

--- PLAYLIST ---
Đang phát: Em của ngày hôm qua - Sơn Tùng
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 1
Tên bài hát: Lạc trôi
Ca sĩ: Sơn Tùng

--- PLAYLIST ---
Đang phát: Em của ngày hôm qua - Sơn Tùng
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 1
Tên bài hát: Nơi này có anh
Ca sĩ: Sơn Tùng

--- PLAYLIST ---
Đang phát: Em của ngày hôm qua - Sơn Tùng
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 5
> Em của ngày hôm qua - Sơn Tùng
  Lạc trôi - Sơn Tùng
  Nơi này có anh - Sơn Tùng

--- PLAYLIST ---
Đang phát: Em của ngày hôm qua - Sơn Tùng
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 3

--- PLAYLIST ---
Đang phát: Lạc trôi - Sơn Tùng
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 5
  Em của ngày hôm qua - Sơn Tùng
> Lạc trôi - Sơn Tùng
  Nơi này có anh - Sơn Tùng

--- PLAYLIST ---
Đang phát: Lạc trôi - Sơn Tùng
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 2
Nhập tên bài cần xóa: lạc trôi
Đã xóa!

--- PLAYLIST ---
Đang phát: Nơi này có anh - Sơn Tùng
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 5
  Em của ngày hôm qua - Sơn Tùng
> Nơi này có anh - Sơn Tùng

--- PLAYLIST ---
Đang phát: Nơi này có anh - Sơn Tùng
1. Thêm bài hát
2. Xóa bài hát
3. Next
4. Previous
5. Xem playlist
0. Quay lại menu chính
Chọn: 0
```

### TH18 – Hệ thống đặt hàng
```
--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 1
Tên khách hàng: Nguyễn Văn An
Đã tạo đơn hàng mã 1

--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 1
Tên khách hàng: Trần Thị Bình
Đã tạo đơn hàng mã 2

--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 2
Nhập mã đơn hàng: 1
Trạng thái mới: Đang giao

--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 2
Nhập mã đơn hàng: 1
Trạng thái mới: Hoàn thành

--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 2
Nhập mã đơn hàng: 1
Không thể chuyển, đơn đang ở: Hoàn thành

--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 3
Nhập mã đơn hàng: 2
Không thể chuyển, đơn đang ở: Chờ xử lý

--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 4
Mã    Khách hàng          Trạng thái
1     Nguyễn Văn An       Hoàn thành
2     Trần Thị Bình       Chờ xử lý

--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 5
Mã    Khách hàng          Trạng thái
2     Trần Thị Bình       Chờ xử lý
1     Nguyễn Văn An       Hoàn thành

--- QUẢN LÝ ĐƠN HÀNG ---
1. Thêm đơn hàng (Chờ xử lý)
2. Chuyển sang trạng thái tiếp theo
3. Quay lại trạng thái trước
4. Xem danh sách (cũ đến mới)
5. Xem danh sách (mới đến cũ)
0. Quay lại menu chính
Chọn: 0
```
