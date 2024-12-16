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
    public partial class frmDMK : Form
    {
        private Database database;
        private string _msnv;
        private string _role;
        public frmDMK(string msnv, string role)
        {
            InitializeComponent();
            txtMKC.PasswordChar = '*';
            txtMKM.PasswordChar = '*';
            txtNLMK.PasswordChar = '*';
            _msnv = msnv;
            _role = role;
            database = new Database();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string MKC = txtMKC.Text.Trim();
            string MKM = txtMKM.Text.Trim();
            string NLMK = txtNLMK.Text.Trim();
            if(MKM != NLMK)
            {
                MessageBox.Show("Mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                switch (_role)
                {
                    case "Nhân Viên":
                        if(database.CheckLoginNV(_msnv, MKC))
                        {
                            if(database.EditMKNV(_msnv, MKM))
                            {
                                MessageBox.Show("Mật khẩu đã thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }    
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }    
                        break;
                    case "Công Nhân":
                        if(database.CheckLoginCN(_msnv,MKC))
                        {
                            if (database.EditMKCN(_msnv, MKM))
                            {
                                MessageBox.Show("Mật khẩu đã thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    case "Quản Lý":
                        if(database.CheckLoginQL(_msnv, MKC))
                        {
                            if (database.EditMKQL(_msnv, MKM))
                            {
                                MessageBox.Show("Mật khẩu đã thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    default:
                        break;
                }
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chkMKC_CheckedChanged(object sender, EventArgs e)
        {
            txtMKC.PasswordChar = chkMKC.Checked ? '\0' : '*';
        }

        private void chkMKM_CheckedChanged(object sender, EventArgs e)
        {
            txtMKM.PasswordChar = chkMKM.Checked ? '\0' : '*';
        }

        private void chkNLMK_CheckedChanged(object sender, EventArgs e)
        {
            txtNLMK.PasswordChar = chkNLMK.Checked ? '\0' : '*';
        }
    }
}
