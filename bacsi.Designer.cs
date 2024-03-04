namespace đồán
{
    partial class bacsi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaBS = new System.Windows.Forms.TextBox();
            this.txttenBS = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtCK = new System.Windows.Forms.TextBox();
            this.txtPK = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.dgvBacSI = new System.Windows.Forms.DataGridView();
            this.luu = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã bác sĩ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "tên bác sĩ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "chuyên khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "phòng khám";
            // 
            // txtmaBS
            // 
            this.txtmaBS.Location = new System.Drawing.Point(122, 2);
            this.txtmaBS.Name = "txtmaBS";
            this.txtmaBS.Size = new System.Drawing.Size(231, 20);
            this.txtmaBS.TabIndex = 5;
            // 
            // txttenBS
            // 
            this.txttenBS.Location = new System.Drawing.Point(123, 31);
            this.txttenBS.Name = "txttenBS";
            this.txttenBS.Size = new System.Drawing.Size(230, 20);
            this.txttenBS.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(123, 66);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(229, 20);
            this.txtSDT.TabIndex = 7;
            // 
            // txtCK
            // 
            this.txtCK.Location = new System.Drawing.Point(123, 95);
            this.txtCK.Name = "txtCK";
            this.txtCK.Size = new System.Drawing.Size(229, 20);
            this.txtCK.TabIndex = 8;
            // 
            // txtPK
            // 
            this.txtPK.Location = new System.Drawing.Point(122, 127);
            this.txtPK.Name = "txtPK";
            this.txtPK.Size = new System.Drawing.Size(228, 20);
            this.txtPK.TabIndex = 9;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(403, 12);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 10;
            this.them.Text = "thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click_1);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(403, 61);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 11;
            this.xoa.Text = "xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click_1);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(403, 95);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 12;
            this.sua.Text = "sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click_1);
            // 
            // dgvBacSI
            // 
            this.dgvBacSI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBacSI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvBacSI.Location = new System.Drawing.Point(15, 175);
            this.dgvBacSI.Name = "dgvBacSI";
            this.dgvBacSI.Size = new System.Drawing.Size(546, 195);
            this.dgvBacSI.TabIndex = 13;
            // 
            // luu
            // 
            this.luu.Location = new System.Drawing.Point(403, 126);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 21);
            this.luu.TabIndex = 14;
            this.luu.Text = "lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maBS";
            this.Column1.HeaderText = "mã bác sĩ";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenBS";
            this.Column2.HeaderText = "tên bác sĩ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "số điện thoại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CK";
            this.Column4.HeaderText = "chuyên khoa";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PK";
            this.Column5.HeaderText = "phòng khám";
            this.Column5.Name = "Column5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 375);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.dgvBacSI);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.txtPK);
            this.Controls.Add(this.txtCK);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txttenBS);
            this.Controls.Add(this.txtmaBS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaBS;
        private System.Windows.Forms.TextBox txttenBS;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtCK;
        private System.Windows.Forms.TextBox txtPK;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.DataGridView dgvBacSI;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}