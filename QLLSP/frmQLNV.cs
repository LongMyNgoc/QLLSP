using QLSinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLSP
{
    public partial class frmQLNV : Form
    {
        private Database database = new Database();
        public frmQLNV()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            try
            {
                DataTable dataTable = database.GetNhanVienData(); // Gọi hàm lấy dữ liệu
                dataGridView1.DataSource = dataTable; // Gắn dữ liệu vào DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một hàng (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy Mã số công nhân từ cột đầu tiên (giả sử cột MSCN là cột đầu tiên)
                string msnv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?",
                                                            "Xác nhận xóa",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);

                // Nếu người dùng chọn Yes thì thực hiện xóa
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        // Thực hiện hành động xóa công nhân theo MSCN
                        database.DeleteNhanVien(msnv);
                        MessageBox.Show("Nhân viên đã được xóa thành công.");
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
            string msnv, matKhau, hoTen;
            int? soNgayLamViec = null, soNgayNghi = null;
            string donViQuanLy = null, chucVu = null;
            int? soGioLamThem = null;
            msnv = txtMNV.Text.Trim();
            matKhau = txtMK.Text.Trim();
            hoTen = txtHT.Text.Trim();
            soNgayLamViec = int.Parse(txtNCDL.Text.Trim());
            soNgayNghi = int.Parse(txtNN.Text.Trim());
            donViQuanLy = txtDV.Text.Trim();
            chucVu = txtCV.Text.Trim();
            soGioLamThem = int.Parse(txtSGLT.Text.Trim());
            if(database.InsertNhanVien(msnv,matKhau,hoTen,soNgayLamViec,soNgayNghi,donViQuanLy,chucVu,soGioLamThem))
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
            string msnv;
            msnv = txtMNV.Text.Trim();
            string hoTen, gioiTinh, donViQuanLy, chucVu, trinhDoChuyenMon, trinhDoNgoaiNgu;
            DateTime ngaySinh, ngayBatDauCongTac;
            int soNgayLamViec, soNgayNghi, soNgayNghiCoPhep, soGioLamThem;
            database.GetNhanVienData(msnv,
    out hoTen, out gioiTinh, out ngaySinh, out ngayBatDauCongTac,
    out donViQuanLy, out soNgayLamViec, out soNgayNghi, out soNgayNghiCoPhep,
    out soGioLamThem, out chucVu, out trinhDoChuyenMon, out trinhDoNgoaiNgu);
            txtHT.Text = hoTen;
            txtDV.Text = donViQuanLy;
            txtNN.Text = soNgayNghi.ToString();
            txtSGLT.Text = soGioLamThem.ToString();
            txtCV.Text = chucVu;
            txtNCDL.Text = soNgayLamViec.ToString();
            string strMatKhau = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra nếu giá trị trong cột 1 khớp với MSNV
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == msnv)
                {
                    // Lấy giá trị từ cột 2
                    strMatKhau = row.Cells[1].Value?.ToString();
                    break; // Dừng lại nếu tìm thấy
                }
            }
            txtMK.Text = strMatKhau;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msnv;
            msnv = txtMNV.Text.Trim();
            string strHoten, strGioitinh, strDonViQuanLy;
            DateTime strNgaySinh, strNgayBatDauCongTac;
            int soNgayLamViec, soNgayNghi, soNgayNghiCoPhep, soGioLamThem;
            string strChucVu, strTrinhDoChuyenMon, strTrinhDoNgoaiNgu;
            database.GetNhanVienData(msnv,
    out strHoten, out strGioitinh, out strNgaySinh, out strNgayBatDauCongTac,
    out strDonViQuanLy, out soNgayLamViec, out soNgayNghi, out soNgayNghiCoPhep,
    out soGioLamThem, out strChucVu, out strTrinhDoChuyenMon, out strTrinhDoNgoaiNgu);
            string ngaySinhString = strNgaySinh.ToString("yyyy-MM-dd");
            string ngayBatDauCongTacString = strNgayBatDauCongTac.ToString("yyyy-MM-dd");
            strHoten = txtHT.Text.Trim();
            soNgayLamViec = int.Parse(txtNCDL.Text.Trim());
            strChucVu = txtCV.Text.Trim();
            soNgayNghi = int.Parse(txtNN.Text.Trim());
            strDonViQuanLy = txtDV.Text.Trim();
            soGioLamThem = int.Parse(txtSGLT.Text.Trim());
            string strMatKhau = txtMK.Text.Trim();
            if (database.EditNhanVien(msnv, strHoten, strGioitinh, ngaySinhString, ngayBatDauCongTacString, strDonViQuanLy, soNgayLamViec, soNgayNghi, soNgayNghiCoPhep, soGioLamThem, strChucVu, strTrinhDoChuyenMon, strTrinhDoNgoaiNgu) && database.EditMKNV(msnv, strMatKhau))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataToDataGridView();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
