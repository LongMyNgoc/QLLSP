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
        public frmUserInformation(string msnv, string role)
        {
            InitializeComponent();
            _msnv = msnv;
            lbUser.Text = "Thông tin " + role;
            txtTK.Text = _msnv;
            _role = role;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            frmDMK frmDMK = new frmDMK(_msnv, _role);
            frmDMK.Show();
        }
    }
}
