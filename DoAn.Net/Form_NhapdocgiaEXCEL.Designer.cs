
namespace DoAn.Net
{
    partial class Form_NhapdocgiaEXCEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NhapdocgiaEXCEL));
            this.btn_adddulieu = new System.Windows.Forms.Button();
            this.btn_chonFile = new System.Windows.Forms.Button();
            this.txt_TenTapTin = new System.Windows.Forms.TextBox();
            this.dgv_thongtindocgia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtindocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_adddulieu
            // 
            this.btn_adddulieu.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_adddulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adddulieu.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adddulieu.Location = new System.Drawing.Point(1329, 26);
            this.btn_adddulieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_adddulieu.Name = "btn_adddulieu";
            this.btn_adddulieu.Size = new System.Drawing.Size(184, 63);
            this.btn_adddulieu.TabIndex = 13;
            this.btn_adddulieu.Text = "Xác nhận";
            this.btn_adddulieu.UseVisualStyleBackColor = false;
            this.btn_adddulieu.Click += new System.EventHandler(this.btn_adddulieu_Click);
            // 
            // btn_chonFile
            // 
            this.btn_chonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_chonFile.Image")));
            this.btn_chonFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_chonFile.Location = new System.Drawing.Point(1136, 26);
            this.btn_chonFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_chonFile.Name = "btn_chonFile";
            this.btn_chonFile.Size = new System.Drawing.Size(184, 63);
            this.btn_chonFile.TabIndex = 12;
            this.btn_chonFile.Text = "Chọn file";
            this.btn_chonFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_chonFile.UseVisualStyleBackColor = true;
            this.btn_chonFile.Click += new System.EventHandler(this.btn_chonFile_Click);
            // 
            // txt_TenTapTin
            // 
            this.txt_TenTapTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.txt_TenTapTin.Location = new System.Drawing.Point(160, 32);
            this.txt_TenTapTin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenTapTin.Name = "txt_TenTapTin";
            this.txt_TenTapTin.Size = new System.Drawing.Size(968, 54);
            this.txt_TenTapTin.TabIndex = 11;
            // 
            // dgv_thongtindocgia
            // 
            this.dgv_thongtindocgia.AllowUserToAddRows = false;
            this.dgv_thongtindocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongtindocgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_thongtindocgia.Location = new System.Drawing.Point(-2, 98);
            this.dgv_thongtindocgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_thongtindocgia.Name = "dgv_thongtindocgia";
            this.dgv_thongtindocgia.RowHeadersVisible = false;
            this.dgv_thongtindocgia.RowHeadersWidth = 51;
            this.dgv_thongtindocgia.Size = new System.Drawing.Size(1570, 837);
            this.dgv_thongtindocgia.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên tập tin:";
            // 
            // Form_NhapdocgiaEXCEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 931);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adddulieu);
            this.Controls.Add(this.btn_chonFile);
            this.Controls.Add(this.txt_TenTapTin);
            this.Controls.Add(this.dgv_thongtindocgia);
            this.Name = "Form_NhapdocgiaEXCEL";
            this.Text = "NhapdocgiaEXCEL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_NhapdocgiaEXCEL_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongtindocgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adddulieu;
        private System.Windows.Forms.Button btn_chonFile;
        private System.Windows.Forms.TextBox txt_TenTapTin;
        private System.Windows.Forms.DataGridView dgv_thongtindocgia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Label label1;
    }
}