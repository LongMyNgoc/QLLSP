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
        int? _SoNgayLamViec, _SoNgayNghiCoPhep;
        decimal? _TienBaoHiemXaHoi;
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
            txtSNLV.Text = "";
            txtSNNCP.Text = "";
            txtTBHXH.Text = "";
            txtTL.Text = "";
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

                if (!int.TryParse(txtSNLV.Text.Trim(), out int soNgayLamViec))
                {
                    MessageBox.Show("Số ngày làm việc không hợp lệ!");
                    return;
                }

                if (!int.TryParse(txtSNNCP.Text.Trim(), out int soNgayNghiCoPhep))
                {
                    MessageBox.Show("Số ngày nghỉ có phép không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtTBHXH.Text.Trim(), out decimal tienBaoHiemXaHoi))
                {
                    MessageBox.Show("Tiền bảo hiểm xã hội không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtTL.Text.Trim(), out decimal tongLuong))
                {
                    MessageBox.Show("Tổng lương không hợp lệ!");
                    return;
                }

                // Gọi hàm insert
                bool result = database.EditQuanLyLuongNhanVienData(
                    _LuongID,
                    _MSNV,
                    thang,
                    nam,
                    heSoLuong,
                    phuCapChucVu,
                    soNgayLamViec,
                    soNgayNghiCoPhep,
                    tienBaoHiemXaHoi,
                    tongLuong
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
            txtSNLV.Text = strSoNgayLamViec;
            txtSNNCP.Text = strSoNgayNghiCoPhep;
            txtTBHXH.Text = strTienBaoHiemXaHoi;
            txtTL.Text = strTongLuong;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

                if (!int.TryParse(txtSNLV.Text.Trim(), out int soNgayLamViec))
                {
                    MessageBox.Show("Số ngày làm việc không hợp lệ!");
                    return;
                }

                if (!int.TryParse(txtSNNCP.Text.Trim(), out int soNgayNghiCoPhep))
                {
                    MessageBox.Show("Số ngày nghỉ có phép không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtTBHXH.Text.Trim(), out decimal tienBaoHiemXaHoi))
                {
                    MessageBox.Show("Tiền bảo hiểm xã hội không hợp lệ!");
                    return;
                }

                if (!decimal.TryParse(txtTL.Text.Trim(), out decimal tongLuong))
                {
                    MessageBox.Show("Tổng lương không hợp lệ!");
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
                    soNgayNghiCoPhep,
                    tienBaoHiemXaHoi,
                    tongLuong
                );

                // Hiển thị thông báo kết quả
                if (result)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!");
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
            strSoNgayLamViec = SoNgayLamViec;
            strSoNgayNghiCoPhep = SoNgayNghiCoPhep;
            strTienBaoHiemXaHoi = TienBaoHiemXaHoi;
            strTongLuong = TongLuong;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
