namespace QLLSP
{
    partial class frmLNV
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
            this.txtMNV = new System.Windows.Forms.TextBox();
            this.lbMNV = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbThang = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lbHSL = new System.Windows.Forms.Label();
            this.txtHSL = new System.Windows.Forms.TextBox();
            this.txtPCCV = new System.Windows.Forms.TextBox();
            this.lbPCCV = new System.Windows.Forms.Label();
            this.lbSNLV = new System.Windows.Forms.Label();
            this.txtSNLV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSNNCP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTBHXH = new System.Windows.Forms.TextBox();
            this.lbTL = new System.Windows.Forms.Label();
            this.txtTL = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbLID = new System.Windows.Forms.Label();
            this.txtLID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMNV
            // 
            this.txtMNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMNV.Location = new System.Drawing.Point(470, 18);
            this.txtMNV.Multiline = true;
            this.txtMNV.Name = "txtMNV";
            this.txtMNV.Size = new System.Drawing.Size(121, 31);
            this.txtMNV.TabIndex = 12;
            // 
            // lbMNV
            // 
            this.lbMNV.AutoSize = true;
            this.lbMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNV.Location = new System.Drawing.Point(306, 20);
            this.lbMNV.Name = "lbMNV";
            this.lbMNV.Size = new System.Drawing.Size(126, 20);
            this.lbMNV.TabIndex = 13;
            this.lbMNV.Text = "Mã Nhân Viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(154, 287);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 37);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(286, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 37);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(697, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 39);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(667, 20);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(60, 20);
            this.lbThang.TabIndex = 53;
            this.lbThang.Text = "Tháng";
            // 
            // txtMonth
            // 
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(759, 20);
            this.txtMonth.Multiline = true;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(121, 31);
            this.txtMonth.TabIndex = 54;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(3, 78);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(47, 20);
            this.lbYear.TabIndex = 55;
            this.lbYear.Text = "Năm";
            // 
            // txtYear
            // 
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(82, 76);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(85, 31);
            this.txtYear.TabIndex = 56;
            // 
            // lbHSL
            // 
            this.lbHSL.AutoSize = true;
            this.lbHSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHSL.Location = new System.Drawing.Point(191, 78);
            this.lbHSL.Name = "lbHSL";
            this.lbHSL.Size = new System.Drawing.Size(110, 20);
            this.lbHSL.TabIndex = 57;
            this.lbHSL.Text = "Hệ số lương";
            // 
            // txtHSL
            // 
            this.txtHSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSL.Location = new System.Drawing.Point(336, 76);
            this.txtHSL.Multiline = true;
            this.txtHSL.Name = "txtHSL";
            this.txtHSL.Size = new System.Drawing.Size(121, 31);
            this.txtHSL.TabIndex = 58;
            // 
            // txtPCCV
            // 
            this.txtPCCV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCCV.Location = new System.Drawing.Point(671, 84);
            this.txtPCCV.Multiline = true;
            this.txtPCCV.Name = "txtPCCV";
            this.txtPCCV.Size = new System.Drawing.Size(249, 31);
            this.txtPCCV.TabIndex = 59;
            // 
            // lbPCCV
            // 
            this.lbPCCV.AutoSize = true;
            this.lbPCCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCCV.Location = new System.Drawing.Point(486, 86);
            this.lbPCCV.Name = "lbPCCV";
            this.lbPCCV.Size = new System.Drawing.Size(157, 20);
            this.lbPCCV.TabIndex = 60;
            this.lbPCCV.Text = "Phụ Cấp Chức Vụ";
            // 
            // lbSNLV
            // 
            this.lbSNLV.AutoSize = true;
            this.lbSNLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSNLV.Location = new System.Drawing.Point(3, 143);
            this.lbSNLV.Name = "lbSNLV";
            this.lbSNLV.Size = new System.Drawing.Size(164, 20);
            this.lbSNLV.TabIndex = 61;
            this.lbSNLV.Text = "Số Ngày Làm Việc";
            // 
            // txtSNLV
            // 
            this.txtSNLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSNLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSNLV.Location = new System.Drawing.Point(207, 141);
            this.txtSNLV.Multiline = true;
            this.txtSNLV.Name = "txtSNLV";
            this.txtSNLV.Size = new System.Drawing.Size(133, 31);
            this.txtSNLV.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Số Ngày Nghỉ Có Phép";
            // 
            // txtSNNCP
            // 
            this.txtSNNCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSNNCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSNNCP.Location = new System.Drawing.Point(671, 143);
            this.txtSNNCP.Multiline = true;
            this.txtSNNCP.Name = "txtSNNCP";
            this.txtSNNCP.Size = new System.Drawing.Size(142, 31);
            this.txtSNNCP.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tiền Bảo Hiểm Xã Hội";
            // 
            // txtTBHXH
            // 
            this.txtTBHXH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTBHXH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTBHXH.Location = new System.Drawing.Point(255, 201);
            this.txtTBHXH.Multiline = true;
            this.txtTBHXH.Name = "txtTBHXH";
            this.txtTBHXH.Size = new System.Drawing.Size(249, 31);
            this.txtTBHXH.TabIndex = 66;
            // 
            // lbTL
            // 
            this.lbTL.AutoSize = true;
            this.lbTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTL.Location = new System.Drawing.Point(536, 203);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(107, 20);
            this.lbTL.TabIndex = 67;
            this.lbTL.Text = "Tổng Lương";
            // 
            // txtTL
            // 
            this.txtTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTL.Location = new System.Drawing.Point(671, 203);
            this.txtTL.Multiline = true;
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(249, 31);
            this.txtTL.TabIndex = 68;
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(16, 285);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(91, 39);
            this.btnGet.TabIndex = 69;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(436, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 37);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(569, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 39);
            this.btnClear.TabIndex = 71;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbLID
            // 
            this.lbLID.AutoSize = true;
            this.lbLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLID.Location = new System.Drawing.Point(3, 20);
            this.lbLID.Name = "lbLID";
            this.lbLID.Size = new System.Drawing.Size(85, 20);
            this.lbLID.TabIndex = 72;
            this.lbLID.Text = "Lương ID";
            // 
            // txtLID
            // 
            this.txtLID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLID.Location = new System.Drawing.Point(124, 16);
            this.txtLID.Multiline = true;
            this.txtLID.Name = "txtLID";
            this.txtLID.Size = new System.Drawing.Size(121, 31);
            this.txtLID.TabIndex = 73;
            // 
            // frmLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 364);
            this.Controls.Add(this.txtLID);
            this.Controls.Add(this.lbLID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtTL);
            this.Controls.Add(this.lbTL);
            this.Controls.Add(this.txtTBHXH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSNNCP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSNLV);
            this.Controls.Add(this.lbSNLV);
            this.Controls.Add(this.lbPCCV);
            this.Controls.Add(this.txtPCCV);
            this.Controls.Add(this.txtHSL);
            this.Controls.Add(this.lbHSL);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbMNV);
            this.Controls.Add(this.txtMNV);
            this.Name = "frmLNV";
            this.Text = "frmLNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMNV;
        private System.Windows.Forms.Label lbMNV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lbHSL;
        private System.Windows.Forms.TextBox txtHSL;
        private System.Windows.Forms.TextBox txtPCCV;
        private System.Windows.Forms.Label lbPCCV;
        private System.Windows.Forms.Label lbSNLV;
        private System.Windows.Forms.TextBox txtSNLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSNNCP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTBHXH;
        private System.Windows.Forms.Label lbTL;
        private System.Windows.Forms.TextBox txtTL;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbLID;
        private System.Windows.Forms.TextBox txtLID;
    }
}