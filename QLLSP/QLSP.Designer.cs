namespace QLLSP
{
    partial class QLSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThem = new System.Windows.Forms.Panel();
            this.dtGv = new System.Windows.Forms.DataGridView();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDg = new System.Windows.Forms.TextBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.txtHd = new System.Windows.Forms.TextBox();
            this.cbbTd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTk = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Controls.Add(this.dtGv);
            this.btnThem.Location = new System.Drawing.Point(12, 306);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(837, 308);
            this.btnThem.TabIndex = 0;
            // 
            // dtGv
            // 
            this.dtGv.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGv.Location = new System.Drawing.Point(12, 3);
            this.dtGv.Name = "dtGv";
            this.dtGv.RowHeadersWidth = 51;
            this.dtGv.RowTemplate.Height = 24;
            this.dtGv.Size = new System.Drawing.Size(811, 298);
            this.dtGv.TabIndex = 0;
            this.dtGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGv_CellContentClick);
            // 
            // txtMa
            // 
            this.txtMa.BackColor = System.Drawing.SystemColors.Info;
            this.txtMa.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMa.Location = new System.Drawing.Point(170, 140);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(229, 22);
            this.txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.Info;
            this.txtTen.Location = new System.Drawing.Point(170, 210);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(229, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtDg
            // 
            this.txtDg.BackColor = System.Drawing.SystemColors.Info;
            this.txtDg.Location = new System.Drawing.Point(170, 278);
            this.txtDg.Name = "txtDg";
            this.txtDg.Size = new System.Drawing.Size(229, 22);
            this.txtDg.TabIndex = 3;
            // 
            // txtSl
            // 
            this.txtSl.BackColor = System.Drawing.SystemColors.Info;
            this.txtSl.Location = new System.Drawing.Point(544, 137);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(229, 22);
            this.txtSl.TabIndex = 4;
            // 
            // txtHd
            // 
            this.txtHd.BackColor = System.Drawing.SystemColors.Info;
            this.txtHd.Location = new System.Drawing.Point(544, 275);
            this.txtHd.Name = "txtHd";
            this.txtHd.Size = new System.Drawing.Size(229, 22);
            this.txtHd.TabIndex = 5;
            // 
            // cbbTd
            // 
            this.cbbTd.BackColor = System.Drawing.SystemColors.Info;
            this.cbbTd.FormattingEnabled = true;
            this.cbbTd.Items.AddRange(new object[] {
            "Tiền Xử lí",
            "Xử lí",
            "Hoàn Thành"});
            this.cbbTd.Location = new System.Drawing.Point(544, 208);
            this.cbbTd.Name = "cbbTd";
            this.cbbTd.Size = new System.Drawing.Size(229, 24);
            this.cbbTd.TabIndex = 6;
            this.cbbTd.SelectedIndexChanged += new System.EventHandler(this.cbbTd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiến độ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã hợp đồng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(75, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(225, 78);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(354, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 23);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTk
            // 
            this.btnTk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTk.Location = new System.Drawing.Point(492, 78);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(113, 23);
            this.btnTk.TabIndex = 16;
            this.btnTk.Text = "Tìm kiếm";
            this.btnTk.UseVisualStyleBackColor = false;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQLHD.Location = new System.Drawing.Point(637, 78);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(102, 23);
            this.btnQLHD.TabIndex = 18;
            this.btnQLHD.Text = "Hợp đồng";
            this.btnQLHD.UseVisualStyleBackColor = false;
            this.btnQLHD.Click += new System.EventHandler(this.button6_Click);
            // 
            // QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(914, 622);
            this.Controls.Add(this.btnQLHD);
            this.Controls.Add(this.btnTk);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbTd);
            this.Controls.Add(this.txtHd);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtDg);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnThem);
            this.Name = "QLSP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QLSP_Load);
            this.btnThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel btnThem;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDg;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.TextBox txtHd;
        private System.Windows.Forms.ComboBox cbbTd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.DataGridView dtGv;
    }
}