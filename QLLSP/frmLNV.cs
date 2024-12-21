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
    public partial class frmLNV : Form
    {
        private Database database = new Database();
        string _LuongID;
        string _MSNV;
        int? _Thang, _Nam;
        decimal? _HeSoLuong, _PhuCapChucVu;
        int? _SoNgayLamViec = null, _SoNgayNghiCoPhep = null;
        decimal? _TienBaoHiemXaHoi = null;
        decimal? _TongLuong;
        string strLID, strMNV, strThang, strNam, strHeSoLuong, strPhuCapChucVu, strSoNgayLamViec, strSoNgayNghiCoPhep, strTienBaoHiemXaHoi, strTongLuong;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _LuongID = txtLID.Text.Trim();
            if(database.DeleteLuongNhanVienById(int.Parse(_LuongID)))
            {
                MessageBox.Show("xóa dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("xóa dữ liệu thất bại!");
            }    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLID.Text = "";
            txtMNV.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            txtHSL.Text = "";
            txtPCCV.Text = "";
            txtLID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _LuongID = txtLID.Text.Trim();
                if (string.IsNullOrEmpty(_LuongID))
                {
                    MessageBox.Show("Lương ID không được để trống!");
                    return;
                }
                _MSNV = txtMNV.Text.Trim();
                if (string.IsNullOrEmpty(_MSNV))
                {
                    MessageBox.Show("Mã nhân viên không được để trống!");
                    return;
                }

                // Chuyển đổi các giá trị nhập từ TextBox
                if (!int.TryParse(txtMonth.Text.Trim(), out int thang))
                {
                    MessageBox.Show("Tháng không hợp lệ!");
                    return;
                }

                if (!int.TryParse(txtYear.Text.Trim(), out int nam))
                {
                    MessageBox.Show("Năm không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtHSL.Text.Trim(), out decimal heSoLuong))
                {
                    MessageBox.Show("Hệ số lương không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtPCCV.Text.Trim(), out decimal phuCapChucVu))
                {
                    MessageBox.Show("Phụ cấp chức vụ không hợp lệ!");
                    return;
                }

                // Gọi hàm insert
                bool result = database.EditQuanLyLuongNhanVienData(
                    _LuongID,
                    _MSNV,
                    thang,
                    nam,
                    heSoLuong,
                    phuCapChucVu
                );

                // Hiển thị thông báo kết quả
                if (result)
                {
                    MessageBox.Show("chỉnh sửa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("chỉnh sửa dữ liệu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtLID.Text = strLID;
            txtMNV.Text = strMNV;
            txtMonth.Text = strThang;
            txtYear.Text = strNam;
            txtHSL.Text = strHeSoLuong;
            txtPCCV.Text = strPhuCapChucVu;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            try
            {
                _LuongID = txtLID.Text.Trim();
                
                _MSNV = txtMNV.Text.Trim();
                if (string.IsNullOrEmpty(_MSNV))
                {
                    MessageBox.Show("Mã nhân viên không được để trống!");
                    return;
                }

                // Chuyển đổi các giá trị nhập từ TextBox
                if (!int.TryParse(txtMonth.Text.Trim(), out int thang))
                {
                    MessageBox.Show("Tháng không hợp lệ!");
                    return;
                }

                if (!int.TryParse(txtYear.Text.Trim(), out int nam))
                {
                    MessageBox.Show("Năm không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtHSL.Text.Trim(), out decimal heSoLuong))
                {
                    MessageBox.Show("Hệ số lương không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtPCCV.Text.Trim(), out decimal phuCapChucVu))
                {
                    MessageBox.Show("Phụ cấp chức vụ không hợp lệ!");
                    return;
                }

                // Gọi hàm insert
                bool result = database.InsertQuanLyLuongNhanVienData(
                    _MSNV,
                    thang,
                    nam,
                    heSoLuong,
                    phuCapChucVu,
                    soNgayLamViec,
                    soNgayNghiCoPhep
                );

                // Hiển thị thông báo kết quả
                if (result)
                {
                    MessageBox.Show("Tính lương thành công. ");
                }
                else
                {
                    MessageBox.Show("Tính lương thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        public frmLNV(string LuongID, string MSNV,
    string Thang = null,
    string Nam = null,
    string HeSoLuong = null,
    string PhuCapChucVu = null,
    string SoNgayLamViec = null,
    string SoNgayNghiCoPhep = null,
    string TienBaoHiemXaHoi = null,
    string TongLuong = null)
        {
            InitializeComponent();
            txtLID.Text = LuongID;
            strLID = LuongID;
            txtMNV.Text = MSNV;
            strMNV = MSNV;
            strThang = Thang;
            strNam = Nam;
            strHeSoLuong = HeSoLuong;
            strPhuCapChucVu = PhuCapChucVu;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
