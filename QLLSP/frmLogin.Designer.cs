namespace QLLSP
{
    partial class frmLogin
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
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbTK = new System.Windows.Forms.Label();
            this.lbMK = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtMK
            // 
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(346, 183);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(228, 31);
            this.txtMK.TabIndex = 5;
            // 
            // txtTK
            // 
            this.txtTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(346, 124);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(228, 31);
            this.txtTK.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(243, 319);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 33);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(320, 32);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(200, 41);
            this.lbLogin.TabIndex = 6;
            this.lbLogin.Text = "ĐĂNG NHẬP";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.ForeColor = System.Drawing.Color.Black;
            this.lbTK.Location = new System.Drawing.Point(223, 126);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(93, 20);
            this.lbTK.TabIndex = 7;
            this.lbTK.Text = "Tài Khoản";
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.ForeColor = System.Drawing.Color.Black;
            this.lbMK.Location = new System.Drawing.Point(228, 194);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(88, 20);
            this.lbMK.TabIndex = 8;
            this.lbMK.Text = "Mật Khẩu";
            // 
            // cboRole
            // 
            this.cboRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Nhân Viên",
            "Công Nhân",
            "Quản Lý"});
            this.cboRole.Location = new System.Drawing.Point(346, 251);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(228, 28);
            this.cboRole.TabIndex = 9;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.Black;
            this.lbRole.Location = new System.Drawing.Point(181, 259);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(135, 20);
            this.lbRole.TabIndex = 10;
            this.lbRole.Text = "Loại Tài Khoản";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(430, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(580, 189);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(18, 17);
            this.chkShowPassword.TabIndex = 12;
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::QLLSP.Properties.Resources.uwp1271503;
            this.ClientSize = new System.Drawing.Size(831, 455);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.lbTK);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnLogin);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}