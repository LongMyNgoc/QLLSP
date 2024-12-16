using QLSinhVien;
using System;
using System.Windows.Forms;

namespace QLLSP
{
    public partial class frmLogin : Form
    {
        private Database database;

        public frmLogin()
        {
            InitializeComponent();
            database = new Database(); // Khởi tạo đối tượng Database
            txtMK.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ giao diện
            string msnv = txtTK.Text.Trim();
            string matKhau = txtMK.Text.Trim();
            string role = cboRole.SelectedItem?.ToString(); // Lấy giá trị văn bản của mục được chọn

            if (string.IsNullOrEmpty(msnv) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (role == "Nhân Viên")
            {
                // Kiểm tra thông tin đăng nhập qua lớp Database
                if (database.CheckLoginNV(msnv, matKhau))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Điều hướng sang form khác nếu cần
                    this.Hide();
                    frmMainUI frmMainUI = new frmMainUI(msnv);
                    frmMainUI.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(role == "Công Nhân")
            {
                if (database.CheckLoginCN(msnv, matKhau))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Điều hướng sang form khác nếu cần
                    this.Hide();
                    frmMainUI frmMainUI = new frmMainUI(msnv);
                    frmMainUI.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(role == "Quản Lý")
            {
                if(database.CheckLoginQL(msnv, matKhau))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Điều hướng sang form khác nếu cần
                    this.Hide();
                    frmMainUI frmMainUI = new frmMainUI(msnv);
                    frmMainUI.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}
