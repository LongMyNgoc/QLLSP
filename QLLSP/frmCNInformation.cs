using QLSinhVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLSP
{
    public partial class frmCNInformation : Form
    {
        private string _msnv;
        private string _role;
        private Database database = new Database();
        public frmCNInformation(string msnv, string role)
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
        private void getData()
        {
            string hoTen, gioiTinh, donViLamViec, tenSanPham;
            int congDoan, caLamViec;
            DateTime ngaySinh, ngayBatDauCongTac;
            int soLanHoanThanh;

            database.GetCongNhanData(_msnv, out hoTen, out gioiTinh, out ngaySinh, out ngayBatDauCongTac,
                out donViLamViec, out tenSanPham, out soLanHoanThanh, out congDoan, out caLamViec);
            txtHT.Text = hoTen;
            txtGT.Text = gioiTinh;
            dtkNS.Value = ngaySinh;
            txtNBDCT.Text = ngayBatDauCongTac.ToString();
            txtDVLV.Text = donViLamViec;
            txtTSP.Text = tenSanPham;
            txtSLHT.Text = soLanHoanThanh.ToString();
            txtTCD.Text = congDoan.ToString();
            txtTCLV.Text = caLamViec.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strHoten, strGioitinh, strNgaySinh, strNgayBatDauCongTac, strDonViLamViec, strTenSanPham;
            int soLanHoanThanh;
            int strCongDoan, strCaLamViec;
            strHoten = txtHT.Text;
            strGioitinh = txtGT.Text;
            strNgaySinh = dtkNS.Value.ToString();
            strNgayBatDauCongTac = txtNBDCT.Text;
            strDonViLamViec = txtDVLV.Text;
            strTenSanPham = txtTSP.Text;
            soLanHoanThanh = int.Parse(txtSLHT.Text);
            strCongDoan = int.Parse(txtTCD.Text);
            strCaLamViec = int.Parse(txtTCLV.Text);
            if(database.EditCongNhan(_msnv,strHoten,strGioitinh,strNgaySinh,strNgayBatDauCongTac,strDonViLamViec,strTenSanPham,soLanHoanThanh,strCongDoan,strCaLamViec))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
    }
}
