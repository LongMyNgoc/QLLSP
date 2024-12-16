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
        public frmUserInformation(string msnv)
        {
            InitializeComponent();
            _msnv = msnv;
            lbUser.Text = "Thông tin của " + msnv;
            txtTK.Text = _msnv;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
