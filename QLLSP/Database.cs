// Database.cs
using System;
using System.Data;
using System.Data.SqlClient;
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
    }
}
