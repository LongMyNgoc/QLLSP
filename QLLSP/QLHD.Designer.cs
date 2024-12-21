namespace QLLSP
{
    partial class QLHD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTG1 = new System.Windows.Forms.DataGridView();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.txtSLSP = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctgSearch = new System.Windows.Forms.ComboBox();
            this.DTNBD = new System.Windows.Forms.DateTimePicker();
            this.DTNKT = new System.Windows.Forms.DateTimePicker();
            this.AddContract = new System.Windows.Forms.Button();
            this.UpdContract = new System.Windows.Forms.Button();
            this.DelContract = new System.Windows.Forms.Button();
            this.TimeSearch = new System.Windows.Forms.DateTimePicker();
            this.tst = new System.Windows.Forms.Label();
            this.txtSLTSP = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.DTG1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 383);
            this.panel1.TabIndex = 0;
            // 
            // DTG1
            // 
            this.DTG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG1.Location = new System.Drawing.Point(3, 60);
            this.DTG1.Name = "DTG1";
            this.DTG1.RowHeadersWidth = 51;
            this.DTG1.RowTemplate.Height = 24;
            this.DTG1.Size = new System.Drawing.Size(1102, 320);
            this.DTG1.TabIndex = 0;
            this.DTG1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG1_CellContentClick);
            // 
            // txtMHD
            // 
            this.txtMHD.Location = new System.Drawing.Point(126, 419);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(200, 22);
            this.txtMHD.TabIndex = 1;
            // 
            // txtTenHD
            // 
            this.txtTenHD.Location = new System.Drawing.Point(126, 458);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(200, 22);
            this.txtTenHD.TabIndex = 2;
            // 
            // txtSLSP
            // 
            this.txtSLSP.Location = new System.Drawing.Point(126, 594);
            this.txtSLSP.Name = "txtSLSP";
            this.txtSLSP.Size = new System.Drawing.Size(200, 22);
            this.txtSLSP.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(643, 401);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(354, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Lượng SP";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tìm kiếm";
            // 
            // ctgSearch
            // 
            this.ctgSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctgSearch.FormattingEnabled = true;
            this.ctgSearch.Items.AddRange(new object[] {
            "id",
            "TenHd",
            "NgayBatDau",
            "NgayKetThuc",
            "SoLuongLSP"});
            this.ctgSearch.Location = new System.Drawing.Point(516, 399);
            this.ctgSearch.Name = "ctgSearch";
            this.ctgSearch.Size = new System.Drawing.Size(121, 24);
            this.ctgSearch.TabIndex = 11;
            // 
            // DTNBD
            // 
            this.DTNBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNBD.Location = new System.Drawing.Point(126, 505);
            this.DTNBD.Name = "DTNBD";
            this.DTNBD.Size = new System.Drawing.Size(200, 22);
            this.DTNBD.TabIndex = 12;
            // 
            // DTNKT
            // 
            this.DTNKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNKT.Location = new System.Drawing.Point(126, 549);
            this.DTNKT.Name = "DTNKT";
            this.DTNKT.Size = new System.Drawing.Size(200, 22);
            this.DTNKT.TabIndex = 13;
            // 
            // AddContract
            // 
            this.AddContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContract.Location = new System.Drawing.Point(350, 435);
            this.AddContract.Name = "AddContract";
            this.AddContract.Size = new System.Drawing.Size(75, 23);
            this.AddContract.TabIndex = 14;
            this.AddContract.Text = "Thêm";
            this.AddContract.UseVisualStyleBackColor = true;
            this.AddContract.Click += new System.EventHandler(this.AddContract_Click);
            // 
            // UpdContract
            // 
            this.UpdContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdContract.Location = new System.Drawing.Point(350, 478);
            this.UpdContract.Name = "UpdContract";
            this.UpdContract.Size = new System.Drawing.Size(75, 23);
            this.UpdContract.TabIndex = 15;
            this.UpdContract.Text = "Sửa";
            this.UpdContract.UseVisualStyleBackColor = true;
            this.UpdContract.Click += new System.EventHandler(this.UpdContract_Click);
            // 
            // DelContract
            // 
            this.DelContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelContract.Location = new System.Drawing.Point(350, 520);
            this.DelContract.Name = "DelContract";
            this.DelContract.Size = new System.Drawing.Size(75, 23);
            this.DelContract.TabIndex = 16;
            this.DelContract.Text = "Xóa";
            this.DelContract.UseVisualStyleBackColor = true;
            this.DelContract.Click += new System.EventHandler(this.DelContract_Click);
            // 
            // TimeSearch
            // 
            this.TimeSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeSearch.Location = new System.Drawing.Point(643, 433);
            this.TimeSearch.Name = "TimeSearch";
            this.TimeSearch.Size = new System.Drawing.Size(354, 22);
            this.TimeSearch.TabIndex = 17;
            // 
            // tst
            // 
            this.tst.AutoSize = true;
            this.tst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst.Location = new System.Drawing.Point(12, 638);
            this.tst.Name = "tst";
            this.tst.Size = new System.Drawing.Size(106, 16);
            this.tst.TabIndex = 18;
            this.tst.Text = "Số Lượng TSP";
            // 
            // txtSLTSP
            // 
            this.txtSLTSP.BackColor = System.Drawing.SystemColors.Info;
            this.txtSLTSP.Location = new System.Drawing.Point(126, 638);
            this.txtSLTSP.Name = "txtSLTSP";
            this.txtSLTSP.Size = new System.Drawing.Size(200, 22);
            this.txtSLTSP.TabIndex = 19;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(411, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(286, 36);
            this.lbUser.TabIndex = 52;
            this.lbUser.Text = "Quản Lý Hợp Đồng";
            // 
            // QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1128, 663);
            this.Controls.Add(this.txtSLTSP);
            this.Controls.Add(this.tst);
            this.Controls.Add(this.TimeSearch);
            this.Controls.Add(this.DelContract);
            this.Controls.Add(this.UpdContract);
            this.Controls.Add(this.AddContract);
            this.Controls.Add(this.DTNKT);
            this.Controls.Add(this.DTNBD);
            this.Controls.Add(this.ctgSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSLSP);
            this.Controls.Add(this.txtTenHD);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.panel1);
            this.Name = "QLHD";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QLHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DTG1;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.TextBox txtSLSP;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ctgSearch;
        private System.Windows.Forms.DateTimePicker DTNBD;
        private System.Windows.Forms.DateTimePicker DTNKT;
        private System.Windows.Forms.Button AddContract;
        private System.Windows.Forms.Button UpdContract;
        private System.Windows.Forms.Button DelContract;
        private System.Windows.Forms.DateTimePicker TimeSearch;
        private System.Windows.Forms.Label tst;
        private System.Windows.Forms.TextBox txtSLTSP;
        private System.Windows.Forms.Label lbUser;
    }
}