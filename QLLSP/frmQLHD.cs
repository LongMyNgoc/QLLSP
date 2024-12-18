using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLLSP
{
    public partial class frmQLHD : Form
    {
        string connectstring = @"Data Source=MSI;Initial Catalog=QLLSP;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn;
        SqlDataAdapter adt;
        SqlCommand cmd;
        DataTable dt = new DataTable();

        private void LoadData3()
        {
            try
            {
                conn.Open();
                //MessageBox.Show("Kết nối thành công!");
                string query = "SELECT * FROM LuongCongNhan";
                cmd = new SqlCommand(query, conn);
                dt = new DataTable();
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dtGV2.DataSource = dt;
                dtGV2.AutoGenerateColumns = true;
                dtGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public frmQLHD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtGV2.CurrentRow.Index;
            txtmsLuong.Text = dtGV2.Rows[i].Cells[0].Value.ToString();
            txtSoca.Text = dtGV2.Rows[i].Cells[1].Value.ToString();
            txtCatoi.Text = dtGV2.Rows[i].Cells[2].Value.ToString();
            txtcaCn.Text = dtGV2.Rows[i].Cells[3].Value.ToString();
            txtTCD.Text = dtGV2.Rows[i].Cells[4].Value.ToString();
            txtTongluong.Text = dtGV2.Rows[i].Cells[5].Value.ToString();
            txtMscn.Text = dtGV2.Rows[i].Cells[6].Value.ToString();
        }

        private void QLHD_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            LoadData3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnChuyentrangCN_Click(object sender, EventArgs e)
        {
            CongNhan frm2 = new CongNhan();
            frm2.ShowDialog();
        }
    }
}
