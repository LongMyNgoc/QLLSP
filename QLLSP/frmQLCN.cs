using QLSinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLSP
{
    public partial class frmQLCN : Form
    {
        private Database database = new Database();

        public frmQLCN()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                DataTable dataTable = database.GetCongNhanData(); // Gọi hàm lấy dữ liệu
                dataGridView1.DataSource = dataTable; // Gắn dữ liệu vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một hàng (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy Mã số công nhân từ cột đầu tiên (giả sử cột MSCN là cột đầu tiên)
                string msnv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa công nhân này không?",
                                                            "Xác nhận xóa",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                // Nếu người dùng chọn Yes thì thực hiện xóa
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Thực hiện hành động xóa công nhân theo MSCN
                        database.DeleteCongNhan(msnv);
                        MessageBox.Show("Công nhân đã được xóa thành công.");
                        LoadDataToDataGridView(); // Tải lại dữ liệu sau khi xóa
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa công nhân: " + ex.Message);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mscn = txtMCN.Text.Trim();
            string matKhau = txtMK.Text.Trim();
            string hoTen = txtHT.Text.Trim();
            string congDoan = txtCD.Text.Trim();
            string sanPham = txtSP.Text.Trim();
            string donVi = txtDV.Text.Trim();
            string caLamViec = txtCLV.Text.Trim();

            int? soLanHoanThanh = null;
            if (!string.IsNullOrEmpty(txtSLHT.Text.Trim()) && int.TryParse(txtSLHT.Text.Trim(), out int parsedValue))
            {
                soLanHoanThanh = parsedValue;
            }

            bool isSuccess = database.InsertCongNhan(mscn, matKhau, hoTen, donVi, sanPham, soLanHoanThanh, congDoan, caLamViec);
            if (isSuccess)
            {
                MessageBox.Show("Thêm công nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView(); // Tải lại dữ liệu nếu cần
            }
            else
            {
                MessageBox.Show("Không thể thêm công nhân. Vui lòng kiểm tra lại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string mscn;
            mscn = txtMCN.Text.Trim();
            string hoTen, gioiTinh, donViLamViec, tenSanPham, congDoan, caLamViec;
            DateTime ngaySinh, ngayBatDauCongTac;
            int soLanHoanThanh;
            database.GetCongNhanData(mscn, out hoTen, out gioiTinh, out ngaySinh, out ngayBatDauCongTac,
                out donViLamViec, out tenSanPham, out soLanHoanThanh, out congDoan, out caLamViec);
            txtHT.Text = hoTen;
            txtCD.Text = congDoan;
            txtCLV.Text = caLamViec;
            txtDV.Text = donViLamViec;
            txtSLHT.Text = soLanHoanThanh.ToString();
            txtSP.Text = tenSanPham;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mscn;
            mscn = txtMCN.Text.Trim();
            string strHoten, strGioitinh, strDonViLamViec, strTenSanPham;
            int soLanHoanThanh;
            string strCongDoan, strCaLamViec;
            DateTime strNgaySinh, strNgayBatDauCongTac;
            database.GetCongNhanData(mscn, out strHoten, out strGioitinh, out strNgaySinh, out strNgayBatDauCongTac,
                out strDonViLamViec, out strTenSanPham, out soLanHoanThanh, out strCongDoan, out strCaLamViec);
            string ngaySinhString = strNgaySinh.ToString("yyyy-MM-dd");
            string ngayBatDauCongTacString = strNgayBatDauCongTac.ToString("yyyy-MM-dd");
            if (database.EditCongNhan(mscn, strHoten, strGioitinh, ngaySinhString, ngayBatDauCongTacString, strDonViLamViec, strTenSanPham, soLanHoanThanh, strCongDoan, strCaLamViec))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView();
            }
        }
    }
}
