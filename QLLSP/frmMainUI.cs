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
    public partial class frmMainUI : Form
    {
        private string _msnv;
        public frmMainUI(string msnv)
        {
            InitializeComponent();
            lbUser.Text = msnv;
            checkUser(msnv);
            _msnv = msnv;
        }
        public void AddForm(Form f)
        {
            this.panel3.Controls.Clear();  // Xóa các control cũ trong panel
            f.TopLevel = false;            // Đặt Form không phải là form cấp cao nhất
            f.FormBorderStyle = FormBorderStyle.None; // Loại bỏ viền form
            f.Dock = DockStyle.Fill;       // Đặt form vừa khít panel
            this.panel3.Controls.Add(f);  // Thêm form vào panel
            f.AutoScroll = true;
            f.Show();                     // Hiển thị form
        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUserInformation userInfo = new frmUserInformation(_msnv); // Khởi tạo form thông tin người dùng
            AddForm(userInfo); // Thêm form vào panel3
        }

        private void checkUser(string msnv)
        {
            if (string.IsNullOrEmpty(msnv)) // Kiểm tra chuỗi rỗng hoặc null
            {
                MessageBox.Show("Mã số nhân viên không được để trống.");
                return;
            }

            // Lấy 2 ký tự đầu tiên
            string firstTwoChars = "" + msnv[0] + msnv[1];

            // Kiểm tra giá trị của 2 ký tự đầu
            if (firstTwoChars == "NV" || firstTwoChars == "CN")
            {
                btnQLHD.Hide();
                btnQLL.Hide();
                btnQLNV.Hide();
                btnQLSP.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
