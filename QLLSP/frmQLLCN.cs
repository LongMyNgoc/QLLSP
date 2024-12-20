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
    public partial class frmQLLCN : Form
    {
        private Database database = new Database();
        public frmQLLCN()
        {
            InitializeComponent();
        }

        private void frmQLLCN_Load(object sender, EventArgs e)
        {
            DataTable dt = database.GetLuongCongNhanData();
            dataGridView1.DataSource = dt;
        }
    }
}
