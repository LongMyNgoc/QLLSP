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
        private string _role;
        private string _firstTwoChars;
        public frmMainUI(string msnv, string role)
        {
            InitializeComponent();
            lbUser.Text = msnv;
            checkUser(msnv);
            _msnv = msnv;
            _role = role;
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
            if (_firstTwoChars == "QL")
            {
                frmUserInformation userInfo = new frmUserInformation(_msnv, _role); // Khởi tạo form thông tin người dùng
                AddForm(userInfo); // Thêm form vào panel3
            }
            else if (_firstTwoChars == "NV")
            {
                frmNVInformation frmNVInformation = new frmNVInformation(_msnv, _role);
                AddForm(frmNVInformation);
            } 
            else if (_firstTwoChars == "CN")
            {
                frmCNInformation frmCNInformation = new frmCNInformation(_msnv, _role);
                AddForm(frmCNInformation);
            }    
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
            _firstTwoChars = firstTwoChars;
            // Kiểm tra giá trị của 2 ký tự đầu
            if (firstTwoChars == "CN")
            {
                btnQLHD.Hide();
                btnQLNV.Hide();
                btnQLSP.Hide();
                btnQLCN.Hide();
                btnQLLCN.Hide();
            }
            else if(firstTwoChars == "NV")
            {
                btnQLNV.Hide();
                btnQLLNV.Hide();
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmQLNV frmQLNV = new frmQLNV();
            AddForm(frmQLNV);
        }

        private void btnQLCN_Click(object sender, EventArgs e)
        {
            frmQLCN frmQLCN = new frmQLCN();
            AddForm(frmQLCN);
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            QLHD qLHD = new QLHD();
            AddForm(qLHD);
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            QLSP qLSP = new QLSP();
            AddForm(qLSP);
        }

        private void btnQLLNV_Click(object sender, EventArgs e)
        {
            frmQLLNV frmQLLNV = new frmQLLNV();
            AddForm(frmQLLNV);
        }

        private void btnQLLCN_Click(object sender, EventArgs e)
        {
            frmQLHD frmQLHD = new frmQLHD();
            AddForm(frmQLHD);
        }
    }
}
