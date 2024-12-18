using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace QLLSP
{
    public partial class Form1 : Form
    {
        string connectstring = @"Data Source=MSI;Initial Catalog=QLLSP;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn;
        SqlDataAdapter adt;
        SqlCommand cmd;
        DataTable dt=new DataTable();
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



        public Form1()
        {
            InitializeComponent();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

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



        //hiển thị thông tin  
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


        //giao diện chính
        private void Form1_Load(object sender, EventArgs e)
        {
            conn= new SqlConnection(connectstring);
            LoadData();
        }




        //thêm dữ liệu
        private void btnThem_Click(object sender, EventArgs e)
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


        private void cbbTd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        //Xóa dữ liệu
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




        //Sửa dữ liệu
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



        //tìm kiếm sản phẩm theo Mã sản phẩm và mã hợp đồng(có hiển thị SoLuongSp bên HopDong thiếu,thừa,đủ )
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
                    //query = "SELECT MaSanPham, TenSanPham, DonGia, SUM(SoLuong) AS TongSoLuong, TienDo, MaHopDong FROM SanPham WHERE MaHopDong = @MaHopDong";
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

                            // Kiểm tra số lượng loại sản phẩm
                            string message = "";
                            if (totalQuantity < soLuongLSP)
                            {
                                message += "Thiếu " + (soLuongLSP - totalQuantity) + " loại sản phẩm.\n";
                            }
                            else if (totalQuantity > soLuongLSP)
                            {
                                message += "Cần xóa " + (totalQuantity - soLuongLSP) + " loại sản phẩm.\n";
                            }
                            else
                            {
                                message += "Số lượng loại sản phẩm đủ.\n";
                            }

                            // Kiểm tra tổng số lượng sản phẩm
                            if (sumProductQuantity < soLuongTong)
                            {
                                message += "Thiếu " + (soLuongTong - sumProductQuantity) + " sản phẩm tổng cộng.";
                            }
                            else if (sumProductQuantity > soLuongTong)
                            {
                                message += "Cần xóa " + (sumProductQuantity - soLuongTong) + " sản phẩm tổng cộng.";
                            }
                            else
                            {
                                message += "Tổng số lượng sản phẩm đủ.";
                            }

                            // Hiển thị thông báo
                            MessageBox.Show(message, "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        //button HopDong(Có cập nhật hợp đồng mỗi khi ấn qua btn HopDong)
        private void button1_Click(object sender, EventArgs e)
        {
            frmQLHD frm2 = new frmQLHD();
            CapNhatHD();
            frm2.ShowDialog();
            
        }



        private void btnCntd_Click(object sender, EventArgs e)
        {
            //CapNhatHD();
        }
        private void btnCntd_Click_1(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
              Application.Exit(); 
        }
    }
}
