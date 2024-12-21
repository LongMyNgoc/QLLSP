namespace QLLSP
{
    partial class frmUserInformation
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbTK = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDMK = new System.Windows.Forms.Button();
            this.lbHT = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.lbGT = new System.Windows.Forms.Label();
            this.lbNS = new System.Windows.Forms.Label();
            this.lbNBDCT = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtNBDCT = new System.Windows.Forms.TextBox();
            this.dtkNS = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(386, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(101, 36);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "label1";
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Location = new System.Drawing.Point(21, 103);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(112, 25);
            this.lbTK.TabIndex = 1;
            this.lbTK.Text = "Tài Khoản";
            this.lbTK.Click += new System.EventHandler(this.lbTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(148, 97);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.ReadOnly = true;
            this.txtTK.Size = new System.Drawing.Size(228, 31);
            this.txtTK.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(20, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 68);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDMK
            // 
            this.btnDMK.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMK.ForeColor = System.Drawing.Color.White;
            this.btnDMK.Location = new System.Drawing.Point(767, 409);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(182, 68);
            this.btnDMK.TabIndex = 8;
            this.btnDMK.Text = "Đổi Mật Khẩu";
            this.btnDMK.UseVisualStyleBackColor = false;
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHT.Location = new System.Drawing.Point(404, 103);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(83, 25);
            this.lbHT.TabIndex = 9;
            this.lbHT.Text = "Họ Tên";
            // 
            // txtHT
            // 
            this.txtHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHT.Location = new System.Drawing.Point(537, 97);
            this.txtHT.Multiline = true;
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(306, 31);
            this.txtHT.TabIndex = 10;
            // 
            // lbGT
            // 
            this.lbGT.AutoSize = true;
            this.lbGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGT.Location = new System.Drawing.Point(21, 175);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(99, 25);
            this.lbGT.TabIndex = 11;
            this.lbGT.Text = "Giới Tính";
            // 
            // lbNS
            // 
            this.lbNS.AutoSize = true;
            this.lbNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNS.Location = new System.Drawing.Point(404, 169);
            this.lbNS.Name = "lbNS";
            this.lbNS.Size = new System.Drawing.Size(112, 25);
            this.lbNS.TabIndex = 12;
            this.lbNS.Text = "Ngày Sinh";
            // 
            // lbNBDCT
            // 
            this.lbNBDCT.AutoSize = true;
            this.lbNBDCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNBDCT.Location = new System.Drawing.Point(21, 244);
            this.lbNBDCT.Name = "lbNBDCT";
            this.lbNBDCT.Size = new System.Drawing.Size(246, 25);
            this.lbNBDCT.TabIndex = 13;
            this.lbNBDCT.Text = "Ngày Bắt Đầu Công Tác";
            // 
            // txtGT
            // 
            this.txtGT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGT.Location = new System.Drawing.Point(148, 169);
            this.txtGT.Multiline = true;
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(228, 31);
            this.txtGT.TabIndex = 14;
            // 
            // txtNBDCT
            // 
            this.txtNBDCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNBDCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNBDCT.Location = new System.Drawing.Point(288, 238);
            this.txtNBDCT.Multiline = true;
            this.txtNBDCT.Name = "txtNBDCT";
            this.txtNBDCT.Size = new System.Drawing.Size(228, 31);
            this.txtNBDCT.TabIndex = 15;
            // 
            // dtkNS
            // 
            this.dtkNS.CustomFormat = "yyyy-MM-dd";
            this.dtkNS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtkNS.Location = new System.Drawing.Point(537, 169);
            this.dtkNS.Name = "dtkNS";
            this.dtkNS.Size = new System.Drawing.Size(306, 27);
            this.dtkNS.TabIndex = 16;
            // 
            // frmUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 489);
            this.Controls.Add(this.dtkNS);
            this.Controls.Add(this.txtNBDCT);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.lbNBDCT);
            this.Controls.Add(this.lbNS);
            this.Controls.Add(this.lbGT);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.lbHT);
            this.Controls.Add(this.btnDMK);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.lbUser);
            this.Name = "frmUserInformation";
            this.Text = "UserInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDMK;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label lbGT;
        private System.Windows.Forms.Label lbNS;
        private System.Windows.Forms.Label lbNBDCT;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtNBDCT;
        private System.Windows.Forms.DateTimePicker dtkNS;
    }
}