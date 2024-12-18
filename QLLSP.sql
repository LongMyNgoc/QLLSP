-- Tạo cơ sở dữ liệu QLLSP
CREATE DATABASE QLLSP;
GO

-- Sử dụng cơ sở dữ liệu QLLSP
USE QLLSP;

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MSNV NVARCHAR(20) PRIMARY KEY,         -- Mã số nhân viên (khóa chính)
    MatKhau NVARCHAR(255) NOT NULL,        -- Mật khẩu (đã mã hóa)
    HoTen NVARCHAR(100) NOT NULL,          -- Họ tên nhân viên
    GioiTinh NVARCHAR(5) CHECK (GioiTinh IN (N'Nam', N'Nữ')) NOT NULL, -- Nam hoặc Nữ
    NgaySinh DATE NOT NULL,                -- Ngày sinh (không để trống)
    NgayBatDauCongTac DATE DEFAULT GETDATE(), -- Ngày bắt đầu công tác
    DonViQuanLy NVARCHAR(100),             -- Đơn vị quản lý (nếu có)
    SoNgayLamViec INT CHECK (SoNgayLamViec >= 0), -- Số ngày làm việc
    SoNgayNghi INT CHECK (SoNgayNghi >= 0),      -- Số ngày nghỉ
    SoNgayNghiCoPhep INT CHECK (SoNgayNghiCoPhep >= 0), -- Nghỉ phép có lương
    SoGioLamThem INT CHECK (SoGioLamThem >= 0),  -- Số giờ làm thêm
    ChucVu NVARCHAR(50),                  -- Chức vụ (Quản lý, Nhân viên, v.v.)
    TrinhDoChuyenMon NVARCHAR(50),        -- Trình độ chuyên môn (Cử nhân, Thạc sĩ, v.v.)
    TrinhDoNgoaiNgu NVARCHAR(50)          -- Trình độ ngoại ngữ
);

-- Chèn dữ liệu mẫu vào bảng NhanVien
INSERT INTO NhanVien (MSNV, MatKhau, HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac, DonViQuanLy, SoNgayLamViec, SoNgayNghi, SoNgayNghiCoPhep, SoGioLamThem, ChucVu, TrinhDoChuyenMon, TrinhDoNgoaiNgu)
VALUES 
('NV001', 'password123', N'Nguyễn Văn A', N'Nam', '1990-01-01', '2015-06-15', N'Phòng Kinh Doanh', 220, 12, 10, 15, N'Trưởng phòng', N'Thạc sĩ Quản trị Kinh doanh', N'Tiếng Anh C1'),
('NV002', 'qwerty', N'Trần Thị B', N'Nữ', '1992-03-15', '2018-01-10', N'Phòng Kế Toán', 230, 8, 5, 20, N'Nhân viên', N'Cử nhân Kế toán', N'Tiếng Anh B2');

-- Tạo bảng CongNhan
CREATE TABLE CongNhan (
    MSCN NVARCHAR(20) PRIMARY KEY,         -- Mã số công nhân (khóa chính)
    MatKhau NVARCHAR(255) NOT NULL,        -- Mật khẩu (đã mã hóa)
    HoTen NVARCHAR(100) NOT NULL,          -- Họ tên công nhân
    GioiTinh NVARCHAR(5) CHECK (GioiTinh IN (N'Nam', N'Nữ')) NOT NULL, -- Nam hoặc Nữ
    NgaySinh DATE NOT NULL,                -- Ngày sinh (bắt buộc)
    NgayBatDauCongTac DATE DEFAULT GETDATE(), -- Ngày bắt đầu công tác
    DonViLamViec NVARCHAR(100),            -- Đơn vị làm việc
    TenSanPham NVARCHAR(100),              -- Tên sản phẩm sản xuất
    SoLanHoanThanh INT CHECK (SoLanHoanThanh >= 0), -- Số lần hoàn thành công đoạn
    CongDoan NVARCHAR(50),                 -- Công đoạn làm việc (ví dụ: "Hàn", "Sơn")
    CaLamViec NVARCHAR(10) CHECK (CaLamViec IN (N'Ca sáng', N'Ca chiều', N'Ca tối')) -- Loại ca làm việc
);

-- Chèn dữ liệu mẫu vào bảng CongNhan
INSERT INTO CongNhan (MSCN, MatKhau, HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac, DonViLamViec, TenSanPham, SoLanHoanThanh, CongDoan, CaLamViec)
VALUES 
('CN001', 'password123', N'Nguyễn Văn C', N'Nam', '1990-01-15', '2024-01-01', N'Phân xưởng A', N'Tủ điện', 120, N'Gia công cơ khí', N'Ca sáng'),
('CN002', 'password456', N'Trần Thị D', N'Nữ', '1995-06-20', '2024-06-01', N'Phân xưởng B', N'Máy bơm nước', 80, N'Đóng gói', N'Ca tối'),
('CN003', 'password789', N'Phạm Văn E', N'Nam', '1985-12-25', '2023-05-01', N'Phân xưởng C', N'Máy lọc nước', 150, N'Lắp ráp', N'Ca chiều');


CREATE TABLE QuanLy (
    MSQL NVARCHAR(50) PRIMARY KEY,         -- Mã số nhân viên (khóa chính)
    MatKhau NVARCHAR(255) NOT NULL,        -- Mật khẩu
    HoTen NVARCHAR(100) NOT NULL,          -- Họ tên
    GioiTinh NVARCHAR(10) NOT NULL,        -- Giới tính
    NgaySinh DATE,                         -- Ngày sinh
    NgayBatDauCongTac DATE DEFAULT GETDATE() -- Ngày bắt đầu công tác (mặc định là ngày hiện tại)
);

INSERT INTO QuanLy (MSQL, MatKhau, HoTen, GioiTinh, NgaySinh) 
VALUES 
    ('QL001', 'MatKhau123', 'Nguyen Van A', 'Nam', '1990-05-20'),
    ('QL002', 'MatKhau456', 'Tran Thi B', 'Nu', '1995-08-15');
-- Xem dữ liệu trong bảng NhanVien

CREATE TABLE HopDong (
    MaHopDong NVARCHAR(50) PRIMARY KEY,          
    TenHopDong NVARCHAR(255),                          
    TinhTrangHopDong NVARCHAR(50),
	NgayBatDau DATE,
    NgayKetThuc DATE,
	SoLuongLSP int,
	SoLuongTSP int
);

INSERT INTO HopDong (MaHopDong, TenHopDong, TinhTrangHopDong, NgayBatDau, NgayKetThuc, SoLuongLSP, SoLuongTSP)
VALUES 
('HD001', N'Hợp đồng sản xuất A', N'Đang thực hiện', '2024-01-01', '2024-12-31', 1000, 500),
('HD002', N'Hợp đồng sản xuất B', N'Hoàn thành', '2023-05-15', '2023-11-15', 1500, 750),
('HD003', N'Hợp đồng sản xuất C', N'Chưa thực hiện', '2024-06-01', '2024-12-01', 2000, 1000);

CREATE TABLE SanPham (
    MaSanPham INT PRIMARY KEY,            
    TenSanPham NVARCHAR(255),         
    DonGia NVARCHAR(50),                
    SoLuong INT,                          
    TienDo NVARCHAR(50),                  
    MaHopDong NVARCHAR(50),                     
    FOREIGN KEY (MaHopDong) REFERENCES HopDong(MaHopDong) 
);

-- Insert dữ liệu vào bảng SanPham
INSERT INTO SanPham (MaSanPham, TenSanPham, DonGia, SoLuong, TienDo, MaHopDong)
VALUES 
(1, 'Khô gà xé', '500.000đ', 10, 'Đang thực hiện', 'HD001'),
(2, 'Khô heo', '700.000đ', 5, 'Chưa thực hiện', 'HD001'),
(3, 'chổi ', '15.000đ', 50, 'Hoàn thành', 'HD002'),
(4, 'Nồi', '100.000đ', 30, 'Đang thực hiện', 'HD002');

CREATE TABLE QuanLyLuongNhanVien (
    LuongID INT IDENTITY(1,1) PRIMARY KEY,   -- Mã lương (khóa chính tự động tăng)
    MSNV NVARCHAR(20) NOT NULL,             -- Mã số nhân viên (liên kết với bảng NhanVien)
    Thang INT CHECK (Thang BETWEEN 1 AND 12) NOT NULL, -- Tháng tính lương (1-12)
    Nam INT CHECK (Nam > 2000) NOT NULL,             -- Năm tính lương
    HeSoLuong FLOAT CHECK (HeSoLuong > 0),  -- Hệ số lương
    PhuCapChucVu FLOAT DEFAULT 0,           -- Phụ cấp chức vụ
    SoNgayLamViec INT CHECK (SoNgayLamViec >= 0), -- Số ngày làm việc thực tế
    SoNgayNghiCoPhep INT CHECK (SoNgayNghiCoPhep >= 0), -- Ngày nghỉ có phép
    TienBaoHiemXaHoi FLOAT DEFAULT 0,       -- Tiền bảo hiểm xã hội
    TongLuong FLOAT,                        -- Tổng lương sau khi tính
    FOREIGN KEY (MSNV) REFERENCES NhanVien(MSNV) -- Ràng buộc khóa ngoại
);

CREATE TRIGGER TinhLuongNhanVien
ON QuanLyLuongNhanVien
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @DonGiaNgay FLOAT = 200000; -- Đơn giá một ngày làm việc
    DECLARE @DonGiaBaoHiem FLOAT = 100000; -- Đơn giá bảo hiểm xã hội mỗi ngày

    UPDATE ql
    SET ql.TongLuong = (ql.HeSoLuong * ql.SoNgayLamViec * @DonGiaNgay)  -- Lương cơ bản
                      + (ql.SoNgayNghiCoPhep * @DonGiaBaoHiem)         -- Tiền bảo hiểm xã hội
                      + ql.PhuCapChucVu                                -- Phụ cấp chức vụ
    FROM QuanLyLuongNhanVien ql
    JOIN inserted i ON ql.LuongID = i.LuongID; -- Chỉ cập nhật các bản ghi được thêm hoặc sửa đổi
END;

INSERT INTO QuanLyLuongNhanVien (MSNV, Thang, Nam, HeSoLuong, PhuCapChucVu, SoNgayLamViec, SoNgayNghiCoPhep)
VALUES 
('NV001', 12, 2024, 3.5, 500000, 20, 2), 
('NV002', 12, 2024, 4.0, 800000, 22, 3);

CREATE TABLE LuongCongNhan (
    MSLuong NVARCHAR(20) PRIMARY KEY,
    SoCa INT,
    CaToi INT,
    CaCN INT,
    CongDoan NVARCHAR(50),
    TongLuong Int,
    MSCN NVARCHAR(20) UNIQUE, 
    FOREIGN KEY (MSCN) REFERENCES CongNhan(MSCN)
);
INSERT INTO LuongCongNhan (MSLuong, SoCa, CaToi, CaCN, CongDoan, TongLuong, MSCN)
VALUES
('L001', 30, 10, 20, '4', 15000000.00, 'CN001'),
('L002', 25, 15, 10, '3', 12000000.00, 'CN002'),
('L003', 40, 10, 30, '2', 18000000.00, 'CN003');

CREATE TABLE CongNhan_SanPham (
    MSCN NVARCHAR(20),  
    MaSanPham INT,     
    SoLuong INT ,
    PRIMARY KEY (MSCN, MaSanPham),
    FOREIGN KEY (MSCN) REFERENCES CongNhan(MSCN),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

INSERT INTO CongNhan_SanPham (MSCN, MaSanPham, SoLuong)
VALUES
('CN001', 1, 5),  -- Nguyễn Văn C làm Khô gà xé
('CN001', 2, 3),  -- Nguyễn Văn C làm Khô heo
('CN002', 3, 20), -- Trần Thị D làm Chổi
('CN002', 4, 15), -- Trần Thị D làm Nồi
('CN003', 3, 25), -- Phạm Văn E làm Chổi
('CN003', 4, 10); -- Phạm Văn E làm Nồi