-- Tạo cơ sở dữ liệu QLLSP
CREATE DATABASE QLLSP;
GO

-- Sử dụng cơ sở dữ liệu QLLSP
USE QLLSP;

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MSNV NVARCHAR(50) PRIMARY KEY,         -- Mã số nhân viên (khóa chính)
    MatKhau NVARCHAR(255) NOT NULL,        -- Mật khẩu
    HoTen NVARCHAR(100) NOT NULL,          -- Họ tên
    GioiTinh NVARCHAR(10) NOT NULL,        -- Giới tính
    NgaySinh DATE,                         -- Ngày sinh
    NgayBatDauCongTac DATE DEFAULT GETDATE() -- Ngày bắt đầu công tác (mặc định là ngày hiện tại)
);

-- Chèn dữ liệu mẫu vào bảng NhanVien
INSERT INTO NhanVien (MSNV, MatKhau, HoTen, GioiTinh, NgaySinh)
VALUES 
('NV001', 'password123', 'Nguyen Van A', 'Nam', '1990-01-01'),
('NV002', 'qwerty', 'Tran Thi B', 'Nữ', '1992-03-15');

CREATE TABLE CongNhan (
    MSCN NVARCHAR(50) PRIMARY KEY,         -- Mã số nhân viên (khóa chính)
    MatKhau NVARCHAR(255) NOT NULL,        -- Mật khẩu
    HoTen NVARCHAR(100) NOT NULL,          -- Họ tên
    GioiTinh NVARCHAR(10) NOT NULL,        -- Giới tính
    NgaySinh DATE,                         -- Ngày sinh
    NgayBatDauCongTac DATE DEFAULT GETDATE() -- Ngày bắt đầu công tác (mặc định là ngày hiện tại)
);

INSERT INTO CongNhan (MSCN, MatKhau, HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac)
VALUES 
('CN001', 'password123', 'Nguyen Van A', 'Nam', '1990-01-15', '2024-01-01'),
('CN002', 'password456', 'Tran Thi B', N'Nữ', '1995-06-20', '2024-06-01');

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
SELECT * FROM NhanVien;
SELECT * FROM CongNhan
SELECT * FROM QuanLy
