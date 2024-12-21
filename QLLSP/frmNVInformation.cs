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
    public partial class frmNVInformation : Form
    {
        private string _msnv;
        private string _role;
        private Database database = new Database();
        public frmNVInformation(string msnv, string role)
        {
            InitializeComponent();
            _msnv = msnv;
            txtTK.Text = _msnv;
            _role = role;
            getData();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            frmDMK frmDMK = new frmDMK(_msnv, _role);
            frmDMK.Show();
        }

        private void txtNBDCT_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSNN_Click(object sender, EventArgs e)
        {

        }
        private void getData()
        {
            string hoTen, gioiTinh, donViQuanLy, chucVu, trinhDoChuyenMon, trinhDoNgoaiNgu;
            DateTime ngaySinh, ngayBatDauCongTac;
            int soNgayLamViec, soNgayNghi, soNgayNghiCoPhep, soGioLamThem;
            database.GetNhanVienData(_msnv,
    out hoTen, out gioiTinh, out ngaySinh, out ngayBatDauCongTac,
    out donViQuanLy, out soNgayLamViec, out soNgayNghi, out soNgayNghiCoPhep,
    out soGioLamThem, out chucVu, out trinhDoChuyenMon, out trinhDoNgoaiNgu);
            txtHT.Text = hoTen;
            txtGT.Text = gioiTinh;
            txtDVQL.Text = donViQuanLy;
            txtCV.Text = chucVu;
            txtTDCM.Text = trinhDoChuyenMon;
            txtTDNN.Text = trinhDoNgoaiNgu;
            dtkNS.Value = ngaySinh;
            txtNBDCT.Text = ngayBatDauCongTac.ToString();
            txtSNLV.Text = soNgayLamViec.ToString();
            txtSNN.Text = soNgayNghi.ToString();
            txtSNNCP.Text = soNgayNghiCoPhep.ToString();
            txtSGLT.Text = soGioLamThem.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strHoten, strGioitinh, strNgaySinh, strNgayBatDauCongTac, strDonViQuanLy;
            int soNgayLamViec, soNgayNghi, soNgayNghiCoPhep, soGioLamThem;
            string strChucVu, strTrinhDoChuyenMon, strTrinhDoNgoaiNgu;
            strHoten = txtHT.Text;
            strGioitinh = txtGT.Text;
            strNgaySinh = dtkNS.Value.ToString();
            strNgayBatDauCongTac = txtNBDCT.Text;
            strDonViQuanLy = txtDVQL.Text;
            soNgayLamViec = int.Parse(txtSNLV.Text.Trim());
            soNgayNghi = int.Parse(txtSNN.Text);
            soNgayNghiCoPhep = int.Parse(txtSNNCP.Text.Trim());
            soGioLamThem = int.Parse(txtSGLT.Text);
            strChucVu = txtCV.Text;
            strTrinhDoChuyenMon = txtTDCM.Text;
            strTrinhDoNgoaiNgu = txtTDNN.Text;
            if (database.EditNhanVien(_msnv, strHoten,strGioitinh, strNgaySinh, strNgayBatDauCongTac, strDonViQuanLy,soNgayLamViec, soNgayNghi,soNgayNghiCoPhep, soGioLamThem, strChucVu, strTrinhDoChuyenMon, strTrinhDoNgoaiNgu))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
