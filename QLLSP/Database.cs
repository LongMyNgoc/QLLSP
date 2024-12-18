// Database.cs
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QLSinhVien
{
    internal class Database
    {
        private string connectionString = @"Data Source=MSI;Initial Catalog=QLLSP;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        // Hàm kiểm tra kết nối
        public bool CheckSqlConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối đến cơ sở dữ liệu: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Hàm kiểm tra thông tin đăng nhập
        public bool CheckLoginNV(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM NhanVien WHERE MSNV = @MSNV AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MSNV", username);
                        cmd.Parameters.AddWithValue("@MatKhau", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool CheckLoginCN(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM CongNhan WHERE MSCN = @MSCN AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MSCN", username);
                        cmd.Parameters.AddWithValue("@MatKhau", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool CheckLoginQL(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM QuanLy WHERE MSQL = @MSQL AND MatKhau = @MatKhau";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MSQL", username);
                        cmd.Parameters.AddWithValue("@MatKhau", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EditMKNV(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE NhanVien SET MatKhau = @MatKhau WHERE MSNV = @MSNV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // Thêm tham số với kiểu dữ liệu và giá trị cụ thể
                        cmd.Parameters.AddWithValue("@MatKhau", password);
                        cmd.Parameters.AddWithValue("@MSNV", username);

                        // Thực hiện câu lệnh và kiểm tra số hàng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu ít nhất 1 hàng bị thay đổi
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc ném ngoại lệ để xử lý ở tầng cao hơn
                throw new Exception("Lỗi khi cập nhật mật khẩu", ex);
            }
        }
        public bool EditMKCN(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE CongNhan SET MatKhau = @MatKhau WHERE MSCN = @MSCN";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // Thêm tham số với kiểu dữ liệu và giá trị cụ thể
                        cmd.Parameters.AddWithValue("@MatKhau", password);
                        cmd.Parameters.AddWithValue("@MSCN", username);

                        // Thực hiện câu lệnh và kiểm tra số hàng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu ít nhất 1 hàng bị thay đổi
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc ném ngoại lệ để xử lý ở tầng cao hơn
                throw new Exception("Lỗi khi cập nhật mật khẩu", ex);
            }
        }
        public bool EditMKQL(string username, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE QuanLy SET MatKhau = @MatKhau WHERE MSQL = @MSQL";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // Thêm tham số với kiểu dữ liệu và giá trị cụ thể
                        cmd.Parameters.AddWithValue("@MatKhau", password);
                        cmd.Parameters.AddWithValue("@MSQL", username);

                        // Thực hiện câu lệnh và kiểm tra số hàng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu ít nhất 1 hàng bị thay đổi
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hoặc ném ngoại lệ để xử lý ở tầng cao hơn
                throw new Exception("Lỗi khi cập nhật mật khẩu", ex);
            }
        }
        public DataTable GetCongNhanData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT MSCN, MatKhau, HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac, DonViLamViec, TenSanPham, SoLanHoanThanh, CongDoan, CaLamViec FROM CongNhan";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable); // Đổ dữ liệu vào DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }

            return dataTable;
        }
        public DataTable GetNhanVienData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT MSNV, MatKhau, HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac, DonViQuanLy, SoNgayLamViec, SoNgayNghi, SoNgayNghiCoPhep, SoGioLamThem, ChucVu, TrinhDoChuyenMon, TrinhDoNgoaiNgu FROM NhanVien";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable); // Đổ dữ liệu vào DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }

            return dataTable;
        }
        public void GetQLData(string msql, out string hoTen, out string gioiTinh, out DateTime? ngaySinh, out DateTime ngayBatDauCongTac)
        {
            // Khởi tạo các giá trị mặc định cho các biến trả về
            hoTen = string.Empty;
            gioiTinh = string.Empty;
            ngaySinh = null;
            ngayBatDauCongTac = DateTime.MinValue;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Truy vấn để lấy thông tin nhân viên quản lý theo MSQL
                    string query = "SELECT HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac FROM QuanLy WHERE MSQL = @MSQL";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@MSQL", msql);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Gán dữ liệu từ bảng vào các biến
                                hoTen = reader["HoTen"].ToString();
                                gioiTinh = reader["GioiTinh"].ToString();
                                ngaySinh = reader["NgaySinh"] != DBNull.Value ? (DateTime?)reader["NgaySinh"] : null;
                                ngayBatDauCongTac = reader["NgayBatDauCongTac"] != DBNull.Value ? (DateTime)reader["NgayBatDauCongTac"] : DateTime.MinValue;
                            }
                            else
                            {
                                throw new Exception("Không tìm thấy nhân viên với MSQL: " + msql);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và hiển thị thông báo
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }
        public void GetNhanVienData(
    string msnv,
    out string hoTen,
    out string gioiTinh,
    out DateTime ngaySinh,
    out DateTime ngayBatDauCongTac,
    out string donViQuanLy,
    out int soNgayLamViec,
    out int soNgayNghi,
    out int soNgayNghiCoPhep,
    out int soGioLamThem,
    out string chucVu,
    out string trinhDoChuyenMon,
    out string trinhDoNgoaiNgu)
        {
            // Khởi tạo giá trị mặc định
            hoTen = string.Empty;
            gioiTinh = string.Empty;
            ngaySinh = DateTime.MinValue;
            ngayBatDauCongTac = DateTime.MinValue;
            donViQuanLy = string.Empty;
            soNgayLamViec = 0;
            soNgayNghi = 0;
            soNgayNghiCoPhep = 0;
            soGioLamThem = 0;
            chucVu = string.Empty;
            trinhDoChuyenMon = string.Empty;
            trinhDoNgoaiNgu = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Câu truy vấn lấy toàn bộ cột từ bảng NhanVien
                    string query = @"
                SELECT 
                    HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac,
                    DonViQuanLy, SoNgayLamViec, SoNgayNghi, SoNgayNghiCoPhep, 
                    SoGioLamThem, ChucVu, TrinhDoChuyenMon, TrinhDoNgoaiNgu
                FROM NhanVien 
                WHERE MSNV = @MSNV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số MSNV vào câu truy vấn
                        cmd.Parameters.AddWithValue("@MSNV", msnv);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Gán giá trị từ bảng vào các biến
                                hoTen = reader["HoTen"].ToString();
                                gioiTinh = reader["GioiTinh"].ToString();
                                ngaySinh = reader["NgaySinh"] != DBNull.Value ? (DateTime)reader["NgaySinh"] : DateTime.MinValue;
                                ngayBatDauCongTac = reader["NgayBatDauCongTac"] != DBNull.Value ? (DateTime)reader["NgayBatDauCongTac"] : DateTime.MinValue;
                                donViQuanLy = reader["DonViQuanLy"]?.ToString() ?? string.Empty;
                                soNgayLamViec = reader["SoNgayLamViec"] != DBNull.Value ? Convert.ToInt32(reader["SoNgayLamViec"]) : 0;
                                soNgayNghi = reader["SoNgayNghi"] != DBNull.Value ? Convert.ToInt32(reader["SoNgayNghi"]) : 0;
                                soNgayNghiCoPhep = reader["SoNgayNghiCoPhep"] != DBNull.Value ? Convert.ToInt32(reader["SoNgayNghiCoPhep"]) : 0;
                                soGioLamThem = reader["SoGioLamThem"] != DBNull.Value ? Convert.ToInt32(reader["SoGioLamThem"]) : 0;
                                chucVu = reader["ChucVu"]?.ToString() ?? string.Empty;
                                trinhDoChuyenMon = reader["TrinhDoChuyenMon"]?.ToString() ?? string.Empty;
                                trinhDoNgoaiNgu = reader["TrinhDoNgoaiNgu"]?.ToString() ?? string.Empty;
                            }
                            else
                            {
                                throw new Exception($"Không tìm thấy nhân viên với MSNV: {msnv}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
        }
        public void GetCongNhanData(
    string mscn,
    out string hoTen,
    out string gioiTinh,
    out DateTime ngaySinh,
    out DateTime ngayBatDauCongTac,
    out string donViLamViec,
    out string tenSanPham,
    out int soLanHoanThanh,
    out string congDoan,
    out string caLamViec)
        {
            // Khởi tạo giá trị mặc định
            hoTen = string.Empty;
            gioiTinh = string.Empty;
            ngaySinh = DateTime.MinValue;
            ngayBatDauCongTac = DateTime.MinValue;
            donViLamViec = string.Empty;
            tenSanPham = string.Empty;
            soLanHoanThanh = 0;
            congDoan = string.Empty;
            caLamViec = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Câu truy vấn lấy toàn bộ cột từ bảng CongNhan
                    string query = @"
            SELECT 
                HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac, 
                DonViLamViec, TenSanPham, SoLanHoanThanh, 
                CongDoan, CaLamViec
            FROM CongNhan 
            WHERE MSCN = @MSCN";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số MSCN vào câu truy vấn
                        cmd.Parameters.AddWithValue("@MSCN", mscn);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Gán giá trị từ bảng vào các biến
                                hoTen = reader["HoTen"].ToString();
                                gioiTinh = reader["GioiTinh"].ToString();
                                ngaySinh = reader["NgaySinh"] != DBNull.Value ? (DateTime)reader["NgaySinh"] : DateTime.MinValue;
                                ngayBatDauCongTac = reader["NgayBatDauCongTac"] != DBNull.Value ? (DateTime)reader["NgayBatDauCongTac"] : DateTime.MinValue;
                                donViLamViec = reader["DonViLamViec"]?.ToString() ?? string.Empty;
                                tenSanPham = reader["TenSanPham"]?.ToString() ?? string.Empty;
                                soLanHoanThanh = reader["SoLanHoanThanh"] != DBNull.Value ? Convert.ToInt32(reader["SoLanHoanThanh"]) : 0;
                                congDoan = reader["CongDoan"]?.ToString() ?? string.Empty;
                                caLamViec = reader["CaLamViec"]?.ToString() ?? string.Empty;
                            }
                            else
                            {
                                throw new Exception($"Không tìm thấy công nhân với MSCN: {mscn}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
            }
        }
        public bool EditQuanLy(string username, string strHoten, string strGioitinh, string strNgaySinh, string strNgayBatDauCongTac)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                UPDATE QuanLy 
                SET 
                    HoTen = @HoTen, 
                    GioiTinh = @GioiTinh, 
                    NgaySinh = @NgaySinh, 
                    NgayBatDauCongTac = @NgayBatDauCongTac 
                WHERE 
                    MSQL = @MSQL";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số với kiểu dữ liệu rõ ràng
                        cmd.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar) { Value = strHoten });
                        cmd.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.NVarChar) { Value = strGioitinh });

                        // Kiểm tra và chuyển đổi giá trị ngày tháng
                        if (DateTime.TryParse(strNgaySinh, out DateTime ngaySinh))
                        {
                            cmd.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = ngaySinh });
                        }
                        else
                        {
                            throw new ArgumentException("Ngày sinh không đúng định dạng.");
                        }

                        if (DateTime.TryParse(strNgayBatDauCongTac, out DateTime ngayBatDauCongTac))
                        {
                            cmd.Parameters.Add(new SqlParameter("@NgayBatDauCongTac", SqlDbType.Date) { Value = ngayBatDauCongTac });
                        }
                        else
                        {
                            throw new ArgumentException("Ngày bắt đầu công tác không đúng định dạng.");
                        }

                        cmd.Parameters.Add(new SqlParameter("@MSQL", SqlDbType.NVarChar) { Value = username });

                        // Thực hiện câu lệnh và kiểm tra số hàng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu ít nhất 1 hàng bị thay đổi
                    }
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi phù hợp
                throw new Exception("Lỗi khi cập nhật thông tin quản lý", ex);
            }
        }
        public bool EditNhanVien(string msnv, string strHoten, string strGioitinh, string strNgaySinh, string strNgayBatDauCongTac,
    string strDonViQuanLy, int soNgayLamViec, int soNgayNghi, int soNgayNghiCoPhep, int soGioLamThem,
    string strChucVu, string strTrinhDoChuyenMon, string strTrinhDoNgoaiNgu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
            UPDATE NhanVien 
            SET 
                HoTen = @HoTen, 
                GioiTinh = @GioiTinh, 
                NgaySinh = @NgaySinh, 
                NgayBatDauCongTac = @NgayBatDauCongTac, 
                DonViQuanLy = @DonViQuanLy, 
                SoNgayLamViec = @SoNgayLamViec, 
                SoNgayNghi = @SoNgayNghi, 
                SoNgayNghiCoPhep = @SoNgayNghiCoPhep, 
                SoGioLamThem = @SoGioLamThem, 
                ChucVu = @ChucVu, 
                TrinhDoChuyenMon = @TrinhDoChuyenMon, 
                TrinhDoNgoaiNgu = @TrinhDoNgoaiNgu
            WHERE 
                MSNV = @MSNV";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số với kiểu dữ liệu rõ ràng
                        cmd.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar) { Value = strHoten });
                        cmd.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.NVarChar) { Value = strGioitinh });

                        // Kiểm tra và chuyển đổi giá trị ngày tháng
                        if (DateTime.TryParse(strNgaySinh, out DateTime ngaySinh))
                        {
                            cmd.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = ngaySinh });
                        }
                        else
                        {
                            throw new ArgumentException("Ngày sinh không đúng định dạng.");
                        }

                        if (DateTime.TryParse(strNgayBatDauCongTac, out DateTime ngayBatDauCongTac))
                        {
                            cmd.Parameters.Add(new SqlParameter("@NgayBatDauCongTac", SqlDbType.Date) { Value = ngayBatDauCongTac });
                        }
                        else
                        {
                            throw new ArgumentException("Ngày bắt đầu công tác không đúng định dạng.");
                        }

                        // Thêm các tham số khác
                        cmd.Parameters.Add(new SqlParameter("@DonViQuanLy", SqlDbType.NVarChar) { Value = strDonViQuanLy });
                        cmd.Parameters.Add(new SqlParameter("@SoNgayLamViec", SqlDbType.Int) { Value = soNgayLamViec });
                        cmd.Parameters.Add(new SqlParameter("@SoNgayNghi", SqlDbType.Int) { Value = soNgayNghi });
                        cmd.Parameters.Add(new SqlParameter("@SoNgayNghiCoPhep", SqlDbType.Int) { Value = soNgayNghiCoPhep });
                        cmd.Parameters.Add(new SqlParameter("@SoGioLamThem", SqlDbType.Int) { Value = soGioLamThem });
                        cmd.Parameters.Add(new SqlParameter("@ChucVu", SqlDbType.NVarChar) { Value = strChucVu });
                        cmd.Parameters.Add(new SqlParameter("@TrinhDoChuyenMon", SqlDbType.NVarChar) { Value = strTrinhDoChuyenMon });
                        cmd.Parameters.Add(new SqlParameter("@TrinhDoNgoaiNgu", SqlDbType.NVarChar) { Value = strTrinhDoNgoaiNgu });

                        // Thêm tham số MSNV vào câu truy vấn
                        cmd.Parameters.Add(new SqlParameter("@MSNV", SqlDbType.NVarChar) { Value = msnv });

                        // Thực hiện câu lệnh và kiểm tra số hàng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu ít nhất 1 hàng bị thay đổi
                    }
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi phù hợp
                throw new Exception("Lỗi khi cập nhật thông tin nhân viên", ex);
            }
        }
        public bool EditCongNhan(string msCn, string strHoten, string strGioitinh, string strNgaySinh, string strNgayBatDauCongTac,
            string strDonViLamViec, string strTenSanPham, int soLanHoanThanh, string strCongDoan, string strCaLamViec)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
            UPDATE CongNhan 
            SET 
                HoTen = @HoTen, 
                GioiTinh = @GioiTinh, 
                NgaySinh = @NgaySinh, 
                NgayBatDauCongTac = @NgayBatDauCongTac, 
                DonViLamViec = @DonViLamViec, 
                TenSanPham = @TenSanPham, 
                SoLanHoanThanh = @SoLanHoanThanh, 
                CongDoan = @CongDoan, 
                CaLamViec = @CaLamViec
            WHERE 
                MSCN = @MSCN";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số với kiểu dữ liệu rõ ràng
                        cmd.Parameters.Add(new SqlParameter("@HoTen", SqlDbType.NVarChar) { Value = strHoten });
                        cmd.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.NVarChar) { Value = strGioitinh });

                        // Kiểm tra và chuyển đổi giá trị ngày tháng
                        if (DateTime.TryParse(strNgaySinh, out DateTime ngaySinh))
                        {
                            cmd.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.Date) { Value = ngaySinh });
                        }
                        else
                        {
                            throw new ArgumentException("Ngày sinh không đúng định dạng.");
                        }

                        if (DateTime.TryParse(strNgayBatDauCongTac, out DateTime ngayBatDauCongTac))
                        {
                            cmd.Parameters.Add(new SqlParameter("@NgayBatDauCongTac", SqlDbType.Date) { Value = ngayBatDauCongTac });
                        }
                        else
                        {
                            throw new ArgumentException("Ngày bắt đầu công tác không đúng định dạng.");
                        }

                        // Thêm các tham số khác
                        cmd.Parameters.Add(new SqlParameter("@DonViLamViec", SqlDbType.NVarChar) { Value = strDonViLamViec });
                        cmd.Parameters.Add(new SqlParameter("@TenSanPham", SqlDbType.NVarChar) { Value = strTenSanPham });
                        cmd.Parameters.Add(new SqlParameter("@SoLanHoanThanh", SqlDbType.Int) { Value = soLanHoanThanh });
                        cmd.Parameters.Add(new SqlParameter("@CongDoan", SqlDbType.NVarChar) { Value = strCongDoan });
                        cmd.Parameters.Add(new SqlParameter("@CaLamViec", SqlDbType.NVarChar) { Value = strCaLamViec });

                        // Thêm tham số MSCN vào câu truy vấn
                        cmd.Parameters.Add(new SqlParameter("@MSCN", SqlDbType.NVarChar) { Value = msCn });

                        // Thực hiện câu lệnh và kiểm tra số hàng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu ít nhất 1 hàng bị thay đổi
                    }
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi phù hợp
                throw new Exception("Lỗi khi cập nhật thông tin công nhân", ex);
            }
        }
        public bool DeleteCongNhan(string mscn)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Câu lệnh SQL để xóa bản ghi từ bảng CongNhan
                    string query = "DELETE FROM CongNhan WHERE MSCN = @MSCN";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số MSCN vào câu truy vấn
                        cmd.Parameters.Add(new SqlParameter("@MSCN", SqlDbType.NVarChar) { Value = mscn });

                        // Thực hiện câu lệnh DELETE và kiểm tra số dòng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu ít nhất 1 dòng bị xóa
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ và thông báo lỗi
                MessageBox.Show($"Lỗi khi xóa công nhân: {ex.Message}");
                return false; // Trả về false nếu có lỗi
            }
        }
        public void DeleteNhanVien(string msnv)
        {
            try
            {
                // Mở kết nối tới cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL câu lệnh xóa nhân viên theo MSNV
                    string query = "DELETE FROM NhanVien WHERE MSNV = @MSNV";

                    // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số MSNV vào câu lệnh SQL
                        cmd.Parameters.Add(new SqlParameter("@MSNV", SqlDbType.NVarChar) { Value = msnv });

                        // Thực thi câu lệnh và kiểm tra số bản ghi bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Nếu xóa thành công, thông báo cho người dùng
                            MessageBox.Show("Nhân viên đã được xóa thành công.");
                        }
                        else
                        {
                            // Nếu không có nhân viên nào bị xóa (MSNV không tồn tại)
                            MessageBox.Show("Không tìm thấy nhân viên với Mã số nhân viên này.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }
        public bool InsertCongNhan(string mscn, string matKhau, string hoTen,
                           string donViLamViec = null, string tenSanPham = null,
                           int? soLanHoanThanh = null, string congDoan = null, string caLamViec = null)
        {
            // Kiểm tra các giá trị đầu vào bắt buộc
            if (string.IsNullOrWhiteSpace(mscn) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường bắt buộc: MSCN, Mật khẩu, Họ tên",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Chuỗi kết nối cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Câu lệnh SQL để chèn dữ liệu
                    string query = @"
            INSERT INTO CongNhan (MSCN, MatKhau, HoTen, GioiTinh, NgaySinh, DonViLamViec, 
                                  TenSanPham, SoLanHoanThanh, CongDoan, CaLamViec)
            VALUES (@MSCN, @MatKhau, @HoTen, @GioiTinh, @NgaySinh, 
                    @DonViLamViec, @TenSanPham, @SoLanHoanThanh, @CongDoan, @CaLamViec)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho các trường bắt buộc
                        command.Parameters.Add(new SqlParameter("@MSCN", mscn));
                        command.Parameters.Add(new SqlParameter("@MatKhau", matKhau));
                        command.Parameters.Add(new SqlParameter("@HoTen", hoTen));
                        command.Parameters.Add(new SqlParameter("@GioiTinh", "Nam")); // Chưa có dữ liệu
                        command.Parameters.Add(new SqlParameter("@NgaySinh", DateTime.Now.ToString("yyyy-MM-dd"))); // Chưa có dữ liệu

                        // Thêm tham số cho các trường không bắt buộc
                        command.Parameters.Add(new SqlParameter("@DonViLamViec", (object)donViLamViec ?? DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@TenSanPham", (object)tenSanPham ?? DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@SoLanHoanThanh", (object)soLanHoanThanh ?? DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@CongDoan", (object)congDoan ?? DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@CaLamViec", (object)caLamViec ?? DBNull.Value));

                        // Thực thi câu lệnh
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra kết quả
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm công nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm công nhân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show("Lỗi khi thêm công nhân: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public bool InsertNhanVien(string msnv, string matKhau, string hoTen,
                           int? soNgayLamViec = null, int? soNgayNghi = null,
                           string donViQuanLy = null, string chucVu = null,
                           int? soGioLamThem = null)
        {
            // Kiểm tra các giá trị đầu vào bắt buộc
            if (string.IsNullOrWhiteSpace(msnv) || string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường bắt buộc: MSNV, Mật khẩu, Họ tên",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Chuỗi kết nối cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Câu lệnh SQL để chèn dữ liệu
                    string query = @"
    INSERT INTO NhanVien (MSNV, MatKhau, HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac, 
                          DonViQuanLy, SoNgayLamViec, SoNgayNghi, SoGioLamThem, ChucVu)
    VALUES (@MSNV, @MatKhau, @HoTen, @GioiTinh, @NgaySinh, @NgayBatDauCongTac, 
            @DonViQuanLy, @SoNgayLamViec, @SoNgayNghi, @SoGioLamThem, @ChucVu)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho các trường bắt buộc
                        command.Parameters.Add(new SqlParameter("@MSNV", msnv));
                        command.Parameters.Add(new SqlParameter("@MatKhau", matKhau));
                        command.Parameters.Add(new SqlParameter("@HoTen", hoTen));
                        command.Parameters.Add(new SqlParameter("@GioiTinh", "Nam")); // Mặc định là "Nam"
                        command.Parameters.Add(new SqlParameter("@NgaySinh", DateTime.Now.AddYears(-25).ToString("yyyy-MM-dd"))); // Mặc định cách đây 25 năm
                        command.Parameters.Add(new SqlParameter("@NgayBatDauCongTac", DateTime.Now.ToString("yyyy-MM-dd"))); // Ngày hiện tại

                        // Thêm tham số cho các trường không bắt buộc
                        command.Parameters.Add(new SqlParameter("@DonViQuanLy", (object)donViQuanLy ?? DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@SoNgayLamViec", soNgayLamViec.HasValue ? (object)soNgayLamViec.Value : DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@SoNgayNghi", soNgayNghi.HasValue ? (object)soNgayNghi.Value : DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@SoGioLamThem", soGioLamThem.HasValue ? (object)soGioLamThem.Value : DBNull.Value));
                        command.Parameters.Add(new SqlParameter("@ChucVu", (object)chucVu ?? DBNull.Value));

                        // Thực thi câu lệnh
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra kết quả
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public DataTable GetQuanLyLuongNhanVienData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    LuongID, 
                    MSNV, 
                    Thang, 
                    Nam, 
                    HeSoLuong, 
                    PhuCapChucVu, 
                    SoNgayLamViec, 
                    SoNgayNghiCoPhep,
TienBaoHiemXaHoi,
                    TongLuong
                FROM QuanLyLuongNhanVien";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable); // Đổ dữ liệu vào DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }

            return dataTable;
        }
        public bool InsertQuanLyLuongNhanVienData(
    string MSNV,
    int Thang,
    int Nam,
    decimal HeSoLuong,
    decimal PhuCapChucVu,
    int SoNgayLamViec,
    int SoNgayNghiCoPhep,
    decimal TienBaoHiemXaHoi,
    decimal TongLuong)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                INSERT INTO QuanLyLuongNhanVien 
                (MSNV, Thang, Nam, HeSoLuong, PhuCapChucVu, SoNgayLamViec, SoNgayNghiCoPhep, TienBaoHiemXaHoi, TongLuong)
                VALUES 
                (@MSNV, @Thang, @Nam, @HeSoLuong, @PhuCapChucVu, @SoNgayLamViec, @SoNgayNghiCoPhep, @TienBaoHiemXaHoi, @TongLuong)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gán giá trị tham số
                        cmd.Parameters.AddWithValue("@MSNV", MSNV);
                        cmd.Parameters.AddWithValue("@Thang", Thang);
                        cmd.Parameters.AddWithValue("@Nam", Nam);
                        cmd.Parameters.AddWithValue("@HeSoLuong", HeSoLuong);
                        cmd.Parameters.AddWithValue("@PhuCapChucVu", PhuCapChucVu);
                        cmd.Parameters.AddWithValue("@SoNgayLamViec", SoNgayLamViec);
                        cmd.Parameters.AddWithValue("@SoNgayNghiCoPhep", SoNgayNghiCoPhep);
                        cmd.Parameters.AddWithValue("@TienBaoHiemXaHoi", TienBaoHiemXaHoi);
                        cmd.Parameters.AddWithValue("@TongLuong", TongLuong);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Kiểm tra xem có thêm được dữ liệu không
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                return false;
            }
        }
        public bool EditQuanLyLuongNhanVienData(
            string LuongID,
    string MSNV,
    int? Thang = null,
    int? Nam = null,
    decimal? HeSoLuong = null,
    decimal? PhuCapChucVu = null,
    int? SoNgayLamViec = null,
    int? SoNgayNghiCoPhep = null,
    decimal? TienBaoHiemXaHoi = null,
    decimal? TongLuong = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                UPDATE QuanLyLuongNhanVien
                SET 
                    Thang = ISNULL(@Thang, Thang),
                    Nam = ISNULL(@Nam, Nam),
                    HeSoLuong = ISNULL(@HeSoLuong, HeSoLuong),
                    PhuCapChucVu = ISNULL(@PhuCapChucVu, PhuCapChucVu),
                    SoNgayLamViec = ISNULL(@SoNgayLamViec, SoNgayLamViec),
                    SoNgayNghiCoPhep = ISNULL(@SoNgayNghiCoPhep, SoNgayNghiCoPhep),
TienBaoHiemXaHoi = ISNULL(@TienBaoHiemXaHoi, TienBaoHiemXaHoi),
                    TongLuong = ISNULL(@TongLuong, TongLuong)
                WHERE LuongID = @LuongID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gán giá trị tham số
                        cmd.Parameters.AddWithValue("@LuongID", LuongID);

                        // Kiểm tra giá trị null và gán giá trị
                        cmd.Parameters.AddWithValue("@Thang", (object)Thang ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Nam", (object)Nam ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@HeSoLuong", (object)HeSoLuong ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PhuCapChucVu", (object)PhuCapChucVu ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoNgayLamViec", (object)SoNgayLamViec ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoNgayNghiCoPhep", (object)SoNgayNghiCoPhep ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TienBaoHiemXaHoi", (object)TienBaoHiemXaHoi ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TongLuong", (object)TongLuong ?? DBNull.Value);

                        // Thực thi câu lệnh
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Trả về true nếu có ít nhất 1 dòng được cập nhật
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
                return false;
            }
        }
        public DataTable SearchQuanLyLuongNhanVien(string keyword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Câu lệnh SQL với LIKE để tìm kiếm trong tất cả các cột
                    string query = @"
                SELECT *
                FROM QuanLyLuongNhanVien
                WHERE (CAST(LuongID AS NVARCHAR) LIKE '%' + @Keyword + '%'
                    OR MSNV LIKE '%' + @Keyword + '%'
                    OR CAST(Thang AS NVARCHAR) LIKE '%' + @Keyword + '%'
                    OR CAST(Nam AS NVARCHAR) LIKE '%' + @Keyword + '%'
                    OR CAST(HeSoLuong AS NVARCHAR) LIKE '%' + @Keyword + '%'
                    OR CAST(PhuCapChucVu AS NVARCHAR) LIKE '%' + @Keyword + '%'
                    OR CAST(SoNgayLamViec AS NVARCHAR) LIKE '%' + @Keyword + '%'
                    OR CAST(SoNgayNghiCoPhep AS NVARCHAR) LIKE '%' + @Keyword + '%'
                    OR CAST(TienBaoHiemXaHoi AS NVARCHAR) LIKE '%' + @Keyword + '%'
                    OR CAST(TongLuong AS NVARCHAR) LIKE '%' + @Keyword + '%')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gắn giá trị tham số
                        cmd.Parameters.AddWithValue("@Keyword", keyword);

                        // Thực thi câu lệnh
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);

                        return resultTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                return null;
            }
        }
        public bool DeleteLuongNhanVienById(int luongID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM QuanLyLuongNhanVien WHERE LuongID = @LuongID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LuongID", luongID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu có ít nhất một bản ghi bị xóa
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                return false;
            }
        }

    }
}

