using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLSP
{
    public partial class CongNhan : Form
    {
        string connectstring = @"Data Source=MSI;Initial Catalog=QLLSP;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn;
        SqlDataAdapter adt;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string query;
        long TongLuong;
        private void LoadDataCN()
        {
            try
            {
                conn.Open();
                //MessageBox.Show("Kết nối thành công!");
                string query = "SELECT * FROM CongNhan";
                cmd = new SqlCommand(query, conn);
                dt = new DataTable();
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dtCongNhan.DataSource = dt;
                dtCongNhan.AutoGenerateColumns = true;
                dtCongNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //tính công đoạn
        private int CongDoan()
        {
            int tongLuong = 0;
            int soLuongCongDoan = 0;

            if (cbcongdoan1.Checked) soLuongCongDoan++;
            if (cbcongdoan2.Checked) soLuongCongDoan++;
            if (cbcongdoan3.Checked) soLuongCongDoan++;

            if (soLuongCongDoan == 1)
            {
                tongLuong = 50000;
            }
            else if (soLuongCongDoan == 2)
            {
                tongLuong = 100000;
            }
            else if (soLuongCongDoan == 3)
            {
                tongLuong = 150000;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 công đoạn.");
                return 0;
            }
            return tongLuong;

        }
        //tinh ca lam
        private int Calam()
        {
            int tong = 0;
            int Ca_1 = 100000;
            int Ca_2 = 100000;
            int Ca_3 = 150000;

            if (cbcd1.Checked) tong += Ca_1;
            if (cbcd2.Checked) tong += Ca_2;
            if (cbcd3.Checked) tong += Ca_3;
            if (tong == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ca làm.");
                return 0;
            }
            return tong;
        }
        //Tinh số lượng sản phẩm 1 công nhân đã làm bằng MSCN
        private int SLsanpham_CongNhan()
        {
            int tongSoLuong = 0;
            object result;

            // Kiểm tra mã công nhân
            if (!string.IsNullOrWhiteSpace(txtMscn.Text))
            {
                try
                {
                    string query = @"
                SELECT 
                    SoLanHoanThanh
                FROM 
                    CongNhan
                WHERE
                    MSCN = @MSCN
            ";

                    using (SqlConnection conn = new SqlConnection(connectstring))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MSCN", txtMscn.Text);

                        conn.Open();
                        result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            tongSoLuong = Convert.ToInt32(result);
                        }
                        else
                        {
                            tongSoLuong = 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tính số lượng sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Mã công nhân không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return tongSoLuong;
        }


        //tính lương bằng = Ca làm + (Công đoạn * số lượng sản phẩm) 
        //riêng ngày chủ nhật tất cả ca làm đều được nhân 2 lương
        private void TinhLuongCongNhan()
        {
            try
            {
                int luongCaLam = Calam();
                int luongCD_Sp = CongDoan() * SLsanpham_CongNhan();
                // Tổng lương ban đầu
                int tongLuong = luongCD_Sp + luongCaLam;

                // Xác định ngày bắt đầu công tác
                if (DateTime.TryParse(dtNgayCongTac.Text, out DateTime ngayCongTac))
                {
                    if (ngayCongTac.DayOfWeek == DayOfWeek.Sunday)
                    {
                        tongLuong *= 2;
                    }
                }
                else
                {
                    MessageBox.Show("Ngày công tác không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Lương của công nhân: {tongLuong:N0} VND", "Tính Lương Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TongLuong = tongLuong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Setnull()
        {
            txtMscn.Text = "";
            txtmk.Text = "";
            txtGioitinh.Text = "";
            txtNgaysinh.Text = "";
            dtNgayCongTac.Text = "";
            txtDvlamviec.Text = "";
            txtTensp.Text = "";
            txtSlhoanthanh.Text = "";
            cbcongdoan1.Checked = false;
            cbcongdoan2.Checked = false;
            cbcongdoan3.Checked = false;
            cbcd1.Checked = false;
            cbcd2.Checked = false;
            cbcd3.Checked = false;

            txtMscn.Focus();
        }
        public CongNhan()
        {
            InitializeComponent();
        }

        private void dtCongNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtCongNhan.CurrentRow.Index;
            txtMscn.Text = dtCongNhan.Rows[i].Cells[0].Value.ToString();
            txtmk.Text = dtCongNhan.Rows[i].Cells[1].Value.ToString();
            txtHoten.Text = dtCongNhan.Rows[i].Cells[2].Value.ToString();
            txtGioitinh.Text = dtCongNhan.Rows[i].Cells[3].Value.ToString();
            txtNgaysinh.Text = dtCongNhan.Rows[i].Cells[4].Value.ToString();
            dtNgayCongTac.Text = dtCongNhan.Rows[i].Cells[5].Value.ToString();
            txtDvlamviec.Text = dtCongNhan.Rows[i].Cells[6].Value.ToString();
            txtTensp.Text = dtCongNhan.Rows[i].Cells[7].Value.ToString();
            txtSlhoanthanh.Text = dtCongNhan.Rows[i].Cells[8].Value.ToString();
            int TongCaLam, TongCongDoan;
            TongCaLam = int.Parse(dtCongNhan.Rows[i].Cells[10].Value.ToString());
            TongCongDoan = int.Parse(dtCongNhan.Rows[i].Cells[9].Value.ToString());
            if (TongCongDoan == 2)
            {
                cbcongdoan1.Checked = true;
                cbcongdoan2.Checked = true;
                cbcongdoan3.Checked = false;
            }   
            else if (TongCongDoan == 1)
            {
                cbcongdoan1.Checked = true;
                cbcongdoan2.Checked = false;
                cbcongdoan3.Checked = false;
            }
            else if(TongCongDoan == 3)
            {
                cbcongdoan1.Checked = true;
                cbcongdoan2.Checked = true;
                cbcongdoan3.Checked = true;
            }  
            else
            {
                cbcongdoan1.Checked = false;
                cbcongdoan2.Checked = false;
                cbcongdoan3.Checked = false;
            }
            if (TongCaLam == 2)
            {
                cbcd1.Checked = true;
                cbcd2.Checked = true;
                cbcd3.Checked = false;
            }
            else if (TongCongDoan == 1)
            {
                cbcd1.Checked = true;
                cbcd2.Checked = false;
                cbcd3.Checked = false;
            }
            else if(TongCaLam == 3)
            {
                cbcd1.Checked = true;
                cbcd2.Checked = true;
                cbcd3.Checked = true;
            }  
            else
            {
                cbcd1.Checked = false;
                cbcd2.Checked = false;
                cbcd3.Checked = false;
            }    
            cbcd1.Text = dtCongNhan.Rows[i].Cells[10].Value.ToString();
            cbcd2.Text = dtCongNhan.Rows[i].Cells[10].Value.ToString();
            cbcd3.Text = dtCongNhan.Rows[i].Cells[10].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CongNhan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            LoadDataCN();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TinhLuongCongNhan();
            SaveLuongCongNhanToDatabase();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void cbcongdoan1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMscn.Text))
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngayCongTac;
                if (!DateTime.TryParse(dtNgayCongTac.Text, out ngayCongTac))
                {
                    MessageBox.Show("Ngày công tác không đúng định dạng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"
        UPDATE CongNhan 
        SET 
            MatKhau = @MatKhau, 
            HoTen = @HoTen, 
            GioiTinh = @GioiTinh, 
            NgaySinh = @NgaySinh,
            NgayBatDauCongTac = @NgayBatDauCongTac, 
            DonViLamViec = @DonViLamViec, 
            TenSanPham = @TenSanPham, 
            SoLanHoanThanh = @SoLuongHoanThanh, 
            TongCongDoan = @TongcongDoan,
            TongCaLamViec = @Tongcalamviec
        WHERE 
            MSCN = @OldMSCN;

        ";

                if (!int.TryParse(txtSlhoanthanh.Text, out int soLuong))
                {
                    MessageBox.Show("Số lượng hoàn thành không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@MatKhau", txtmk.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", txtHoten.Text.Trim());
                        cmd.Parameters.AddWithValue("@GioiTinh", txtGioitinh.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", txtNgaysinh.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayBatDauCongTac", ngayCongTac);
                        cmd.Parameters.AddWithValue("@DonViLamViec", txtDvlamviec.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenSanPham", txtTensp.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoLuongHoanThanh", soLuong);
                        cmd.Parameters.AddWithValue("@OldMSCN", txtMscn.Text.Trim());

                        // Tính tổng công đoạn
                        int tongCongDoan = 0;
                        if (cbcongdoan1.Checked) tongCongDoan++;
                        if (cbcongdoan2.Checked) tongCongDoan++;
                        if (cbcongdoan3.Checked) tongCongDoan++;
                        cmd.Parameters.AddWithValue("@TongcongDoan", tongCongDoan);

                        // Tính tổng ca làm việc
                        int tongCa = 0;
                        if (cbcd1.Checked) tongCa++;
                        if (cbcd2.Checked) tongCa++;
                        if (cbcd3.Checked) tongCa++;
                        cmd.Parameters.AddWithValue("@Tongcalamviec", tongCa);
                        // Thực thi câu lệnh SQL
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataCN();
                        }
                        else
                        {
                            MessageBox.Show("Không có dòng nào được cập nhật. Vui lòng kiểm tra lại mã công nhân (MSCN)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(txtMscn.Text) || string.IsNullOrEmpty(txtmk.Text) || string.IsNullOrEmpty(txtHoten.Text) ||
                    string.IsNullOrEmpty(txtGioitinh.Text) || string.IsNullOrEmpty(txtNgaysinh.Text) ||
                    string.IsNullOrEmpty(dtNgayCongTac.Text) || string.IsNullOrEmpty(txtDvlamviec.Text) ||
                    string.IsNullOrEmpty(txtTensp.Text) || string.IsNullOrEmpty(txtSlhoanthanh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string query = @"INSERT INTO CongNhan (MSCN, MatKhau, HoTen, GioiTinh, NgaySinh, NgayBatDauCongTac, DonViLamViec, TenSanPham, SoLuongHoanThanh, TongCongDoan) 
                                 VALUES (@MSCN, @MatKhau, @HoTen, @GioiTinh, @NgaySinh, @NgayBatDauCongTac, @DonViLamViec, @TenSanPham, @SoLuongHoanThanh, @TongcongDoan)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int soLuong = int.Parse(txtSlhoanthanh.Text);
                    cmd.Parameters.AddWithValue("@MSCN", txtMscn.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtmk.Text);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoten.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", txtGioitinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", txtNgaysinh.Text);
                    cmd.Parameters.AddWithValue("@NgayBatDauCongTac", dtNgayCongTac.Text);
                    cmd.Parameters.AddWithValue("@DonViLamViec", txtDvlamviec.Text);
                    cmd.Parameters.AddWithValue("@TenSanPham", txtTensp.Text);
                    cmd.Parameters.AddWithValue("@SoLuongHoanThanh", soLuong);
                    int tongCongDoan = (cbcongdoan1.Checked ? 1 : 0) +
                                       (cbcongdoan2.Checked ? 1 : 0) +
                                       (cbcongdoan3.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@TongcongDoan", tongCongDoan);
                    int tongCa = (cbcd1.Checked ? 1 : 0) +
                                 (cbcd1.Checked ? 1 : 0) +
                                 (cbcd1.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Tongcalamviec", tongCa);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataCN();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void txtNgaysinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void SaveLuongCongNhanToDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectstring))
                {
                    conn.Open();
                    string query = @"
             INSERT INTO LuongCongNhan 
             (SoCa,CongDoan,TongLuong,MSCN) 
             VALUES (@SoCa,@CongDoan,@TongLuong,@MSCN)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoCa", tongca());
                        cmd.Parameters.AddWithValue("@CongDoan", tongCD());
                        cmd.Parameters.AddWithValue("@TongLuong", TongLuong);
                        cmd.Parameters.AddWithValue("@MSCN", txtMscn.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataCN();
                        }
                        else
                        {
                            MessageBox.Show("Không có dòng nào được cập nhật. Vui lòng kiểm tra lại mã công nhân (MSCN)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int tongca()
        {
            int tong = 0;
            int Ca_1 = 1;
            int Ca_2 = 1;
            int Ca_3 = 1;
            if (cbcd1.Checked)
            {
                tong = tong + Ca_1;
            }
            else if (cbcd2.Checked)
            {
                tong = tong + Ca_2;
            }
            else if (cbcd3.Checked)
            {
                tong = tong + Ca_3;
            }
            else if (cbcd1.Checked && cbcd2.Checked)
            {
                tong = Ca_1 + Ca_2;
            }
            else if (cbcd1.Checked && cbcd3.Checked)
            {
                tong = Ca_1 + Ca_3;
            }
            else if (cbcd2.Checked && cbcd3.Checked)
            {
                tong = Ca_2 + Ca_3;
            }
            else if (cbcd1.Checked && cbcd2.Checked && cbcd3.Checked)
            {
                tong = Ca_1 + Ca_2 + Ca_3;
            }
            else
            {
                return 0;
            }
            return tong;
        }
        private int tongCD()
        {
            int tongcd1 = 1;
            int tongcd2 = 1;
            int tongcd3 = 1;
            int tong = 0;
            if (cbcongdoan1.Checked)
            {
                tong = tong + tongcd1;
            }
            else if (cbcongdoan2.Checked)
            {
                tong = tong + tongcd2;
            }
            else if (cbcongdoan3.Checked)
            {
                tong = tong + tongcd3;
            }
            else if (cbcongdoan1.Checked && cbcongdoan2.Checked)
            {
                tong = tongcd1 + tongcd2;
            }
            else if (cbcongdoan1.Checked && cbcongdoan3.Checked)
            {
                tong = tongcd1 + tongcd3;
            }
            else if (cbcongdoan2.Checked && cbcongdoan3.Checked)
            {
                tong = tongcd2 + tongcd3;
            }
            else if (cbcongdoan1.Checked && cbcongdoan2.Checked && cbcongdoan3.Checked)
            {
                tong = tongcd1 + tongcd2 + tongcd3;
            }
            else
            {
                return 0;
            }
            return tong;
        }

        private void btnSLCN_Click(object sender, EventArgs e)
        {
            frmQLLCN frmQLLCN = new frmQLLCN();
            frmQLLCN.Show();
        }
    }
}
