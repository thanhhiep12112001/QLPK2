namespace đồán
{
    partial class menu
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
            this.benhNhan = new System.Windows.Forms.Button();
            this.bacSi = new System.Windows.Forms.Button();
            this.thuoc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // benhNhan
            // 
            this.benhNhan.Location = new System.Drawing.Point(93, 104);
            this.benhNhan.Name = "benhNhan";
            this.benhNhan.Size = new System.Drawing.Size(205, 80);
            this.benhNhan.TabIndex = 0;
            this.benhNhan.Text = "BenhNhan";
            this.benhNhan.UseVisualStyleBackColor = true;
            this.benhNhan.Click += new System.EventHandler(this.benhNhan_Click);
            // 
            // bacSi
            // 
            this.bacSi.Location = new System.Drawing.Point(462, 104);
            this.bacSi.Name = "bacSi";
            this.bacSi.Size = new System.Drawing.Size(226, 80);
            this.bacSi.TabIndex = 1;
            this.bacSi.Text = "BacSI";
            this.bacSi.UseVisualStyleBackColor = true;
            this.bacSi.Click += new System.EventHandler(this.bacSi_Click);
            // 
            // thuoc
            // 
            this.thuoc.Location = new System.Drawing.Point(270, 226);
            this.thuoc.Name = "thuoc";
            this.thuoc.Size = new System.Drawing.Size(217, 86);
            this.thuoc.TabIndex = 2;
            this.thuoc.Text = "Thuoc";
            this.thuoc.UseVisualStyleBackColor = true;
            this.thuoc.Click += new System.EventHandler(this.thuoc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thuoc);
            this.Controls.Add(this.bacSi);
            this.Controls.Add(this.benhNhan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button benhNhan;
        private System.Windows.Forms.Button bacSi;
        private System.Windows.Forms.Button thuoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}