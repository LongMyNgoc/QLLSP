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
    public partial class frmUserInformation : Form
    {
        private string _msnv;
        private string _role;
        private Database database;
        public frmUserInformation(string msnv, string role)
        {
            InitializeComponent();
            _msnv = msnv;
            lbUser.Text = "Thông tin " + role;
            txtTK.Text = _msnv;
            _role = role;
            database = new Database();
            getData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strHoten = txtHT.Text.Trim();
            string strGioiTinh = txtGT.Text.Trim();
            string strNgaySinh = dtkNS.Value.ToString("yyyy-MM-dd");
            string strNgayBatDauCongTac = txtNBDCT.Text.Trim();
            if(database.EditQuanLy(_msnv,strHoten,strGioiTinh,strNgaySinh,strNgayBatDauCongTac))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            frmDMK frmDMK = new frmDMK(_msnv, _role);
            frmDMK.Show();
        }

        private void lbTK_Click(object sender, EventArgs e)
        {

        }
        private void getData()
        {
            string strHoTen, strGioiTinh;
            DateTime? NgaySinh;
            DateTime NgayBatDauCongTac;
            database.GetQLData(_msnv, out strHoTen, out strGioiTinh, out NgaySinh, out NgayBatDauCongTac);
            txtHT.Text = strHoTen;
            txtGT.Text = strGioiTinh;
            txtNBDCT.Text = NgayBatDauCongTac.ToString();
            dtkNS.Value = NgaySinh.Value;
        }
    }
}
