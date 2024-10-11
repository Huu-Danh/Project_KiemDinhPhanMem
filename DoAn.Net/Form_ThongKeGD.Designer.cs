namespace DoAn.Net
{
    partial class Form_ThongKeGD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ThongKeGD));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_ngaygd = new System.Windows.Forms.ComboBox();
            this.cbo_loaigd = new System.Windows.Forms.ComboBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lọcTheoLoạiGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lọcTheoNgàyGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 150);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1102, 599);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loai giao dich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngay giao dich";
            // 
            // cbo_ngaygd
            // 
            this.cbo_ngaygd.Enabled = false;
            this.cbo_ngaygd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbo_ngaygd.FormattingEnabled = true;
            this.cbo_ngaygd.Location = new System.Drawing.Point(136, 99);
            this.cbo_ngaygd.Name = "cbo_ngaygd";
            this.cbo_ngaygd.Size = new System.Drawing.Size(186, 26);
            this.cbo_ngaygd.TabIndex = 3;
            // 
            // cbo_loaigd
            // 
            this.cbo_loaigd.Enabled = false;
            this.cbo_loaigd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbo_loaigd.FormattingEnabled = true;
            this.cbo_loaigd.Location = new System.Drawing.Point(136, 46);
            this.cbo_loaigd.Name = "cbo_loaigd";
            this.cbo_loaigd.Size = new System.Drawing.Size(186, 26);
            this.cbo_loaigd.TabIndex = 4;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim.Image")));
            this.btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tim.Location = new System.Drawing.Point(985, 38);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(129, 42);
            this.btn_Tim.TabIndex = 5;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dong.Image")));
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dong.Location = new System.Drawing.Point(985, 89);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(129, 44);
            this.btn_Dong.TabIndex = 6;
            this.btn_Dong.Text = "Refresh";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lọcTheoLoạiGiaoDịchToolStripMenuItem,
            this.lọcTheoNgàyGiaoDịchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lọcTheoLoạiGiaoDịchToolStripMenuItem
            // 
            this.lọcTheoLoạiGiaoDịchToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.lọcTheoLoạiGiaoDịchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lọcTheoLoạiGiaoDịchToolStripMenuItem.Name = "lọcTheoLoạiGiaoDịchToolStripMenuItem";
            this.lọcTheoLoạiGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.lọcTheoLoạiGiaoDịchToolStripMenuItem.Text = "Lọc theo loại giao dịch";
            this.lọcTheoLoạiGiaoDịchToolStripMenuItem.Click += new System.EventHandler(this.lọcTheoLoạiGiaoDịchToolStripMenuItem_Click);
            // 
            // lọcTheoNgàyGiaoDịchToolStripMenuItem
            // 
            this.lọcTheoNgàyGiaoDịchToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.lọcTheoNgàyGiaoDịchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lọcTheoNgàyGiaoDịchToolStripMenuItem.Name = "lọcTheoNgàyGiaoDịchToolStripMenuItem";
            this.lọcTheoNgàyGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.lọcTheoNgàyGiaoDịchToolStripMenuItem.Text = "Lọc theo ngày giao dịch";
            this.lọcTheoNgàyGiaoDịchToolStripMenuItem.Click += new System.EventHandler(this.lọcTheoNgàyGiaoDịchToolStripMenuItem_Click);
            // 
            // Form_ThongKeGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 747);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.cbo_loaigd);
            this.Controls.Add(this.cbo_ngaygd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_ThongKeGD";
            this.Text = "Thong Ke Giao Dich";
            this.Load += new System.EventHandler(this.Form_ThongKeGD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_ngaygd;
        private System.Windows.Forms.ComboBox cbo_loaigd;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lọcTheoLoạiGiaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lọcTheoNgàyGiaoDịchToolStripMenuItem;
    }
}