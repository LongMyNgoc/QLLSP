using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLSP
{
    public partial class QLSP : Form
    {
        string connectstring = @"Data Source=MSI;Initial Catalog=QLLSP;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn;
        SqlDataAdapter adt;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public QLSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string maSP = txtMa.Text;
                string tenSP = txtTen.Text;
                string donGia = txtDg.Text;
                int soLuong = int.Parse(txtSl.Text);
                string tienDo = cbbTd.Text;
                string hopDong = txtHd.Text;

                conn.Open();

                string query = "INSERT INTO SanPham (MaSanPham, TenSanPham, DonGia, SoLuong, TienDo, MaHopDong) " +
                               "VALUES (@MaSanPham, @TenSanPham, @DonGia, @SoLuong, @TienDo, @MaHopDong)";

                using (cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSanPham", maSP);
                    cmd.Parameters.AddWithValue("@TenSanPham", tenSP);
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                    cmd.Parameters.AddWithValue("@TienDo", tienDo);
                    cmd.Parameters.AddWithValue("@MaHopDong", hopDong);

                    cmd.ExecuteNonQuery();
                }

                conn.Close();

                LoadData();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm sản phẩm này không?",
                                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Setnull();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                //MessageBox.Show("Kết nối thành công!");
                string query = "SELECT * FROM SanPham";
                cmd = new SqlCommand(query, conn);
                dt = new DataTable();
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dtGv.DataSource = dt;
                dtGv.AutoGenerateColumns = true;
                dtGv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData2()
        {
            try
            {
                conn.Open();
                //MessageBox.Show("Kết nối thành công!");
                string query = "SELECT * FROM HopDong";
                cmd = new SqlCommand(query, conn);
                dt = new DataTable();
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dtGv.DataSource = dt;
                dtGv.AutoGenerateColumns = true;
                dtGv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Setnull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDg.Text = "";
            txtSl.Text = "";
            cbbTd.Text = "";
            txtHd.Text = "";

            txtMa.Focus();
        }

        //Cap nhật lại hợp đồng trạng thái
        public void CapNhatHD()
        {
            string maHopDong = txtHd.Text;
            try
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(1) FROM HopDong WHERE MaHopDong = @MaHopDong";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists == 0)
                    {
                        
                        return;
                    }
                }

                // Cập nhật tình trạng hợp đồng
                string updateQuery = @"
                UPDATE H
                SET TinhTrangHopDong = CASE
                    WHEN NOT EXISTS (
                        SELECT 1 
                        FROM SanPham Sp
                        WHERE Sp.MaHopDong = H.MaHopDong AND Sp.TienDo <> 'Hoàn thành'
                    ) THEN 'Hoàn thành'
                    ELSE 'Đang thực hiện'
                END
                FROM HopDong H
                INNER JOIN SanPham Sp ON H.MaHopDong = Sp.MaHopDong
                WHERE H.MaHopDong = @MaHopDong;";

                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtGv.CurrentRow != null)
                {
                    string maSP = dtGv.CurrentRow.Cells["MaSanPham"].Value.ToString();

                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?",
                                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();

                        string query = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";

                        using (cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSanPham", maSP);
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();

                        LoadData();

                        MessageBox.Show("Xóa thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMa.Text))
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn.Open();

                string query = "UPDATE SanPham SET TenSanPham = @TenSanPham, DonGia = @DonGia, SoLuong = @SoLuong, TienDo = @TienDo, MaHopDong = @MaHopDong " +
                               "WHERE MaSanPham = @MaSanPham";

                cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaSanPham", txtMa.Text);
                cmd.Parameters.AddWithValue("@TenSanPham", txtTen.Text);
                cmd.Parameters.AddWithValue("@DonGia", txtDg.Text);
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSl.Text));
                cmd.Parameters.AddWithValue("@TienDo", cbbTd.Text);
                cmd.Parameters.AddWithValue("@MaHopDong", txtHd.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadData();

                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Setnull();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            try
            {
                string query;
                int totalQuantity = 0;  // Tổng loại sản phẩm
                int sumProductQuantity = 0; // Tổng số lượng sản phẩm thực tế

                // Trường hợp tìm kiếm theo Mã Hợp Đồng
                if (!string.IsNullOrWhiteSpace(txtHd.Text) && string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    query = @"
SELECT 
    sp.MaSanPham, 
    sp.TenSanPham, 
    sp.DonGia, 
    sp.TienDo, 
    sp.MaHopDong,
    SUM(sp.SoLuong) AS TongSoLuong
FROM SanPham sp
WHERE sp.MaHopDong = @MaHopDong
GROUP BY sp.MaSanPham, sp.TenSanPham, sp.DonGia, sp.TienDo, sp.MaHopDong";
                    //query = "SELECT MaSanPham,TenSanPham,DonGia, SUM(SoLuong) AS TongSoLuong,TienDo,MaHopDong FROM SanPham WHERE MaHopDong = @MaHopDong GROUP BY MaSanPham";
                    conn.Open();

                    using (cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaHopDong", txtHd.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtGv.DataSource = dt; // Hiển thị danh sách sản phẩm

                        totalQuantity = dt.Rows.Count; // Số loại sản phẩm (các MaSanPham khác nhau)
                        sumProductQuantity = dt.AsEnumerable().Sum(row => row.Field<int>("TongSoLuong")); // Tổng số lượng sản phẩm thực tế

                        // Lấy thông tin SoLuongLSP và SoLuongTong từ bảng HopDong
                        string querySoLuongTong = "SELECT SoLuongLSP, SoLuongTSP FROM HopDong WHERE MaHopDong = @MaHopDong";
                        cmd = new SqlCommand(querySoLuongTong, conn);
                        cmd.Parameters.AddWithValue("@MaHopDong", txtHd.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int soLuongLSP = Convert.ToInt32(reader["SoLuongLSP"]); // Số loại sản phẩm cần thiết
                            int soLuongTong = Convert.ToInt32(reader["SoLuongTSP"]); // Tổng số lượng sản phẩm cần thiết
                            bool checkLoi = false;
                            // Kiểm tra số lượng loại sản phẩm
                            string message = "";

                            if (totalQuantity < soLuongLSP)
                            {
                                checkLoi = true;
                                message += "Thiếu " + (soLuongLSP - totalQuantity) + " loại sản phẩm.\n";
                            }
                            else if (totalQuantity > soLuongLSP)
                            {
                                checkLoi = true;
                                message += "Cần xóa " + (totalQuantity - soLuongLSP) + " loại sản phẩm.\n";
                            }
                            else
                            {
                                message += "Số lượng loại sản phẩm đủ.\n";
                            }

                            // Kiểm tra tổng số lượng sản phẩm
                            if (sumProductQuantity < soLuongTong)
                            {
                                checkLoi = true;
                                message += "Thiếu " + (soLuongTong - sumProductQuantity) + " sản phẩm tổng cộng.";
                            }
                            else if (sumProductQuantity > soLuongTong)
                            {
                                checkLoi = true;
                                message += "Cần xóa " + (sumProductQuantity - soLuongTong) + " sản phẩm tổng cộng.";
                            }
                            else
                            {
                                message += "Tổng số lượng sản phẩm đủ.";
                            }
                            if (checkLoi == true)
                            {
                                string mess = "!!!Mâu thuẫn giữa tổng số lượng và loại sản phẩm \n";
                                message = mess + message;
                            MessageBox.Show(message, "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                            MessageBox.Show(message, "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            

                            // Hiển thị thông báo
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy hợp đồng với mã hợp đồng này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();
                    }
                }
                // Trường hợp tìm kiếm theo Mã Sản Phẩm
                else if (!string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    query = "SELECT * FROM SanPham WHERE MaSanPham = @MaSanPham";
                    conn.Open();

                    using (cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSanPham", txtMa.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtGv.DataSource = dt; // Hiển thị kết quả
                    }
                }
                // Trường hợp không nhập gì
                else
                {
                    query = "SELECT * FROM SanPham";
                    query = "SELECT * FROM SanPham";
                    conn.Open();

                    using (cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dtGv.DataSource = dt; // Hiển thị toàn bộ bảng sản phẩm
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QLHD frm2 = new QLHD();
            CapNhatHD();
            frm2.ShowDialog();
        }

        private void dtGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtGv.CurrentRow.Index;
            txtMa.Text = dtGv.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dtGv.Rows[i].Cells[1].Value.ToString();
            txtDg.Text = dtGv.Rows[i].Cells[2].Value.ToString();
            cbbTd.Text = dtGv.Rows[i].Cells[3].Value.ToString();
            txtHd.Text = dtGv.Rows[i].Cells[4].Value.ToString();
            txtSl.Text = dtGv.Rows[i].Cells[5].Value.ToString();
        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            LoadData();
        }

        private void cbbTd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
