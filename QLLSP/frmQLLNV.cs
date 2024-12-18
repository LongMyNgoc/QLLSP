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
    public partial class frmQLLNV : Form
    {
        private Database database = new Database();
        public frmQLLNV()
        {
            InitializeComponent();
            LoadQuanLyLuongData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string LuongID = null;
            string MSNV = null;
            string Thang = null;
            string Nam = null;
            string HeSoLuong = null;
            string PhuCapChucVu = null;
            string SoNgayLamViec = null;
            string SoNgayNghiCoPhep = null;
            string TienBaoHiemXaHoi = null;
            string TongLuong = null;
            // Kiểm tra nếu người dùng click vào một hàng (không phải header)
            if (e.RowIndex >= 0)
            {
                // Lấy Mã số công nhân từ cột đầu tiên (giả sử cột MSCN là cột đầu tiên)
                LuongID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                MSNV = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Thang = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Nam = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                HeSoLuong = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                PhuCapChucVu = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                SoNgayLamViec = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                SoNgayNghiCoPhep = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                TienBaoHiemXaHoi = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                TongLuong = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            frmLNV frmLNV = new frmLNV(LuongID, MSNV, Thang, Nam, HeSoLuong, PhuCapChucVu, SoNgayLamViec, SoNgayNghiCoPhep, TienBaoHiemXaHoi, TongLuong);
            frmLNV.Show();
        }
        private void LoadQuanLyLuongData()
        {
            DataTable quanLyLuongData = database.GetQuanLyLuongNhanVienData();
            dataGridView1.DataSource = quanLyLuongData;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadQuanLyLuongData();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTK.Text.Trim();

                // Gọi hàm tìm kiếm từ lớp Database
                DataTable result = database.SearchQuanLyLuongNhanVien(keyword);

                // Hiển thị kết quả trong DataGridView
                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
