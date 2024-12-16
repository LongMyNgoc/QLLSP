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
    }
}
