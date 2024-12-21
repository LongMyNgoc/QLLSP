namespace QLLSP
{
    partial class frmDMK
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
            this.lbDMK = new System.Windows.Forms.Label();
            this.lbMKC = new System.Windows.Forms.Label();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.chkMKC = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMKM = new System.Windows.Forms.Label();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.chkMKM = new System.Windows.Forms.CheckBox();
            this.lbNLMK = new System.Windows.Forms.Label();
            this.txtNLMK = new System.Windows.Forms.TextBox();
            this.chkNLMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbDMK
            // 
            this.lbDMK.AutoSize = true;
            this.lbDMK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDMK.Location = new System.Drawing.Point(272, 44);
            this.lbDMK.Name = "lbDMK";
            this.lbDMK.Size = new System.Drawing.Size(242, 41);
            this.lbDMK.TabIndex = 7;
            this.lbDMK.Text = "ĐỔI MẬT KHẨU";
            this.lbDMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMKC
            // 
            this.lbMKC.AutoSize = true;
            this.lbMKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMKC.ForeColor = System.Drawing.Color.Black;
            this.lbMKC.Location = new System.Drawing.Point(123, 134);
            this.lbMKC.Name = "lbMKC";
            this.lbMKC.Size = new System.Drawing.Size(117, 20);
            this.lbMKC.TabIndex = 9;
            this.lbMKC.Text = "Mật Khẩu Cũ";
            // 
            // txtMKC
            // 
            this.txtMKC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKC.Location = new System.Drawing.Point(279, 131);
            this.txtMKC.Multiline = true;
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.Size = new System.Drawing.Size(228, 31);
            this.txtMKC.TabIndex = 10;
            // 
            // chkMKC
            // 
            this.chkMKC.AutoSize = true;
            this.chkMKC.Location = new System.Drawing.Point(513, 137);
            this.chkMKC.Name = "chkMKC";
            this.chkMKC.Size = new System.Drawing.Size(18, 17);
            this.chkMKC.TabIndex = 13;
            this.chkMKC.UseVisualStyleBackColor = true;
            this.chkMKC.CheckedChanged += new System.EventHandler(this.chkMKC_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(228, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(382, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMKM
            // 
            this.lbMKM.AutoSize = true;
            this.lbMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMKM.ForeColor = System.Drawing.Color.Black;
            this.lbMKM.Location = new System.Drawing.Point(116, 186);
            this.lbMKM.Name = "lbMKM";
            this.lbMKM.Size = new System.Drawing.Size(124, 20);
            this.lbMKM.TabIndex = 16;
            this.lbMKM.Text = "Mật Khẩu Mới";
            // 
            // txtMKM
            // 
            this.txtMKM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKM.Location = new System.Drawing.Point(279, 183);
            this.txtMKM.Multiline = true;
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Size = new System.Drawing.Size(228, 31);
            this.txtMKM.TabIndex = 17;
            // 
            // chkMKM
            // 
            this.chkMKM.AutoSize = true;
            this.chkMKM.Location = new System.Drawing.Point(513, 189);
            this.chkMKM.Name = "chkMKM";
            this.chkMKM.Size = new System.Drawing.Size(18, 17);
            this.chkMKM.TabIndex = 18;
            this.chkMKM.UseVisualStyleBackColor = true;
            this.chkMKM.CheckedChanged += new System.EventHandler(this.chkMKM_CheckedChanged);
            // 
            // lbNLMK
            // 
            this.lbNLMK.AutoSize = true;
            this.lbNLMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNLMK.ForeColor = System.Drawing.Color.Black;
            this.lbNLMK.Location = new System.Drawing.Point(71, 241);
            this.lbNLMK.Name = "lbNLMK";
            this.lbNLMK.Size = new System.Drawing.Size(169, 20);
            this.lbNLMK.TabIndex = 19;
            this.lbNLMK.Text = "Nhập Lại Mật Khẩu";
            // 
            // txtNLMK
            // 
            this.txtNLMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNLMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNLMK.Location = new System.Drawing.Point(279, 231);
            this.txtNLMK.Multiline = true;
            this.txtNLMK.Name = "txtNLMK";
            this.txtNLMK.Size = new System.Drawing.Size(228, 31);
            this.txtNLMK.TabIndex = 20;
            // 
            // chkNLMK
            // 
            this.chkNLMK.AutoSize = true;
            this.chkNLMK.Location = new System.Drawing.Point(513, 245);
            this.chkNLMK.Name = "chkNLMK";
            this.chkNLMK.Size = new System.Drawing.Size(18, 17);
            this.chkNLMK.TabIndex = 21;
            this.chkNLMK.UseVisualStyleBackColor = true;
            this.chkNLMK.CheckedChanged += new System.EventHandler(this.chkNLMK_CheckedChanged);
            // 
            // frmDMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLLSP.Properties.Resources.uwp1271503;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkNLMK);
            this.Controls.Add(this.txtNLMK);
            this.Controls.Add(this.lbNLMK);
            this.Controls.Add(this.chkMKM);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.lbMKM);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkMKC);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.lbMKC);
            this.Controls.Add(this.lbDMK);
            this.Name = "frmDMK";
            this.Text = "frmDMK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDMK;
        private System.Windows.Forms.Label lbMKC;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.CheckBox chkMKC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMKM;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.CheckBox chkMKM;
        private System.Windows.Forms.Label lbNLMK;
        private System.Windows.Forms.TextBox txtNLMK;
        private System.Windows.Forms.CheckBox chkNLMK;
    }
}