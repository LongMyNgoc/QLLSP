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
    public partial class QLHD : Form
    {
        SqlCommand command;
        SqlConnection conn;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public QLHD()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        private void disp_data()
        {
            //SELECT * FROM Customers;
            string query = "SELECT * FROM HopDong";
            command = conn.CreateCommand();
            command.CommandText = query;
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);

            //SqlCommand cmd = new SqlCommand(query, conn);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            DTG1.DataSource = dt;
            DTG1.AutoGenerateColumns = true;
            //conn.Close();
        }

        private void QLHD_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=QLLSP;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            conn.Open();
            disp_data();
        }

        private void AddContract_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            string dth = "Dang thuc hien";
            //command.CommandText = "INSERT INTO HopDong VALUES ('" + txtMHD.Text + "' , '" + txtTenHD.Text + "' , '" + 30 + "','" + "Dang Thuc hien" + "', '" + DTNKT.Text +" AS DATETIME2" +"','" + DTNBD.Text +  " AS DATETIME2" + "','" + txtSLSP.Text + "')";
            command.CommandText = "INSERT INTO HopDong VALUES ('" + txtMHD.Text + "' , '" + txtTenHD.Text + "' , '" + 30 + "','" + dth + "', '" + DTNKT.Text + "', '" + DTNBD.Text + "', '" + txtSLSP.Text +"', '"+txtSLTSP.Text +"')";
            command.ExecuteNonQuery();
            disp_data();
        }

        private void DTG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DTG1.CurrentRow.Index;
            txtMHD.Text = DTG1.Rows[i].Cells[0].Value.ToString();
            txtTenHD.Text = DTG1.Rows[i].Cells[1].Value.ToString();
            DTNKT.Text = DTG1.Rows[i].Cells[4].Value.ToString();
            DTNBD.Text = DTG1.Rows[i].Cells[5].Value.ToString();
            txtSLSP.Text = DTG1.Rows[i].Cells[6].Value.ToString();
        }

        private void UpdContract_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            //command.CommandText = "INSERT INTO HopDong VALUES ('" + txtMHD.Text + "' , '" + txtTenHD.Text + "' , '" + 30 + "','" + "Dang Thuc hien" + "', '" + DTNKT.Text +" AS DATETIME2" +"','" + DTNBD.Text +  " AS DATETIME2" + "','" + txtSLSP.Text + "')";
            command.CommandText = "Update HopDong set TenHopDong= '" + txtTenHD.Text + "', NgayKetThuc= '" + DTNKT.Text + "', NgayBatDau= '" + DTNBD.Text + "', SoLuongLSP= '" + txtSLSP.Text +"', SoLuongTSP = '"+ txtSLTSP.Text +"' where MaHopDong = '" + txtMHD.Text + "'";
            command.ExecuteNonQuery();
            disp_data();
        }

        private void DelContract_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            //command.CommandText = "INSERT INTO HopDong VALUES ('" + txtMHD.Text + "' , '" + txtTenHD.Text + "' , '" + 30 + "','" + "Dang Thuc hien" + "', '" + DTNKT.Text +" AS DATETIME2" +"','" + DTNBD.Text +  " AS DATETIME2" + "','" + txtSLSP.Text + "')";
            command.CommandText = "Delete from HopDong where MaHopDong ='" + txtMHD.Text + "'";
            command.ExecuteNonQuery();
            disp_data();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "";

            SqlCommand command = conn.CreateCommand();
            if (ctgSearch.SelectedItem.ToString().Equals("id"))
            {

                query = "select * from HopDong where MaHopDong like '%" + txtSearch.Text + "%'";
                //query = "SELECT * FROM HopDong WHERE MaHopDong = @searchText";
                //command.Parameters.AddWithValue("@searchText", txtSearch.Text);
            }
            else if (ctgSearch.SelectedItem.ToString().Equals("TenHd"))
            {

                query = "select * from HopDong where TenHopDong like '%" + txtSearch.Text + "%'";
            }
            else if (ctgSearch.SelectedItem.ToString().Equals("NgayBatDau"))
            {
                TimeSearch.Visible = true;
                txtSearch.Visible = false;
                query = "select * from HopDong where NgayBatDau = '" + TimeSearch.Text + "'";
            }
            else if (ctgSearch.SelectedItem.ToString().Equals("NgayKetThuc"))
            {
                TimeSearch.Visible = true;
                txtSearch.Visible = false;
                query = "select * from HopDong where NgayKetThuc = '" + txtSearch.Text + "'";
            }
            else if (ctgSearch.SelectedItem.ToString().Equals("SoLuongLSP"))
            {

                query = "select * from HopDong where SoLuongLSP = '" + txtSearch.Text + "'";
            }

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show(query);
                return;
            }


            //command = conn.CreateCommand();
            command.CommandText = query;
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);

            //SqlCommand cmd = new SqlCommand(query, conn);
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            DTG1.DataSource = dt;
            DTG1.AutoGenerateColumns = true;
            //disp_data();
            if (txtSearch.Text == "")
            {
                this.OnLoad(e);
            }
        }
    }
}
