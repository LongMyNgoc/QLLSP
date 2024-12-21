namespace QLLSP
{
    partial class frmQLNV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbMNV = new System.Windows.Forms.Label();
            this.lbNCDL = new System.Windows.Forms.Label();
            this.lbCV = new System.Windows.Forms.Label();
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.txtNCDL = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.lbHT = new System.Windows.Forms.Label();
            this.lbNN = new System.Windows.Forms.Label();
            this.lbDV = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtNN = new System.Windows.Forms.TextBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.lbSGLT = new System.Windows.Forms.Label();
            this.txtSGLT = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMK = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(420, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(298, 36);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Thông tin nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 271);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNV.Location = new System.Drawing.Point(8, 383);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(126, 20);
            this.lbMNV.TabIndex = 5;
            this.lbMNV.Text = "Mã Nhân Viên";
            // 
            // lbNCDL
            // 
            this.lbNCDL.AutoSize = true;
            this.lbNCDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNCDL.Location = new System.Drawing.Point(8, 423);
            this.lbNCDL.Name = "lbNCDL";
            this.lbNCDL.Size = new System.Drawing.Size(159, 20);
            this.lbNCDL.TabIndex = 6;
            this.lbNCDL.Text = "Ngày công đã làm";
            // 
            // lbCV
            // 
            this.lbCV.AutoSize = true;
            this.lbCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCV.Location = new System.Drawing.Point(8, 467);
            this.lbCV.Name = "lbCV";
            this.lbCV.Size = new System.Drawing.Size(80, 20);
            this.lbCV.TabIndex = 7;
            this.lbCV.Text = "Chức Vụ";
            // 
            // txtMNV
            // 
            this.txtMNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNV.Location = new System.Drawing.Point(203, 372);
            this.txtMNV.Multiline = true;
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(311, 31);
            this.txtMNV.TabIndex = 11;
            // 
            // txtNCDL
            // 
            this.txtNCDL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNCDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCDL.Location = new System.Drawing.Point(203, 412);
            this.txtNCDL.Multiline = true;
            this.txtNCDL.Name = "txtNCDL";
            this.txtNCDL.Size = new System.Drawing.Size(311, 31);
            this.txtNCDL.TabIndex = 12;
            // 
            // txtCV
            // 
            this.txtCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCV.Location = new System.Drawing.Point(203, 456);
            this.txtCV.Multiline = true;
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(311, 31);
            this.txtCV.TabIndex = 13;
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHT.Location = new System.Drawing.Point(563, 342);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(70, 20);
            this.lbHT.TabIndex = 14;
            this.lbHT.Text = "Họ Tên";
            // 
            // lbNN
            // 
            this.lbNN.AutoSize = true;
            this.lbNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNN.Location = new System.Drawing.Point(563, 383);
            this.lbNN.Name = "lbNN";
            this.lbNN.Size = new System.Drawing.Size(143, 20);
            this.lbNN.TabIndex = 15;
            this.lbNN.Text = "Ngày Nghỉ Phép";
            // 
            // lbDV
            // 
            this.lbDV.AutoSize = true;
            this.lbDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDV.Location = new System.Drawing.Point(563, 423);
            this.lbDV.Name = "lbDV";
            this.lbDV.Size = new System.Drawing.Size(65, 20);
            this.lbDV.TabIndex = 16;
            this.lbDV.Text = "Đơn Vị";
            // 
            // txtHT
            // 
            this.txtHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHT.Location = new System.Drawing.Point(735, 335);
            this.txtHT.Multiline = true;
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(306, 31);
            this.txtHT.TabIndex = 17;
            // 
            // txtNN
            // 
            this.txtNN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNN.Location = new System.Drawing.Point(735, 372);
            this.txtNN.Multiline = true;
            this.txtNN.Name = "txtNN";
            this.txtNN.Size = new System.Drawing.Size(306, 31);
            this.txtNN.TabIndex = 18;
            // 
            // txtDV
            // 
            this.txtDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDV.Location = new System.Drawing.Point(735, 412);
            this.txtDV.Multiline = true;
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(306, 31);
            this.txtDV.TabIndex = 19;
            // 
            // lbSGLT
            // 
            this.lbSGLT.AutoSize = true;
            this.lbSGLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSGLT.Location = new System.Drawing.Point(563, 467);
            this.lbSGLT.Name = "lbSGLT";
            this.lbSGLT.Size = new System.Drawing.Size(145, 20);
            this.lbSGLT.TabIndex = 20;
            this.lbSGLT.Text = "Số giờ làm thêm";
            // 
            // txtSGLT
            // 
            this.txtSGLT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSGLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGLT.Location = new System.Drawing.Point(735, 456);
            this.txtSGLT.Multiline = true;
            this.txtSGLT.Name = "txtSGLT";
            this.txtSGLT.Size = new System.Drawing.Size(306, 31);
            this.txtSGLT.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1057, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1057, 375);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 37);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Lấy";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1057, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 39);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Location = new System.Drawing.Point(12, 337);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(88, 20);
            this.lbMK.TabIndex = 29;
            this.lbMK.Text = "Mật Khẩu";
            // 
            // txtMK
            // 
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(203, 331);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(311, 31);
            this.txtMK.TabIndex = 49;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1057, 416);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 37);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1177, 510);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSGLT);
            this.Controls.Add(this.lbSGLT);
            this.Controls.Add(this.txtDV);
            this.Controls.Add(this.txtNN);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.lbDV);
            this.Controls.Add(this.lbNN);
            this.Controls.Add(this.lbHT);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.txtNCDL);
            this.Controls.Add(this.txtMNV);
            this.Controls.Add(this.lbCV);
            this.Controls.Add(this.lbNCDL);
            this.Controls.Add(this.lbMNV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbUser);
            this.Name = "frmQLNV";
            this.Text = "frmQLNV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.Label lbNCDL;
        private System.Windows.Forms.Label lbCV;
        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.TextBox txtNCDL;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label lbNN;
        private System.Windows.Forms.Label lbDV;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtNN;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.Label lbSGLT;
        private System.Windows.Forms.TextBox txtSGLT;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnUpdate;
    }
}