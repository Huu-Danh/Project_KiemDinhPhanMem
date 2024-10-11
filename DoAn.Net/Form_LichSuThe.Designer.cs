
namespace DoAn.Net
{
    partial class Form_LichSuThe
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
            this.dgv_LichSuThe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuThe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LichSuThe
            // 
            this.dgv_LichSuThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichSuThe.Location = new System.Drawing.Point(1, 1);
            this.dgv_LichSuThe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_LichSuThe.Name = "dgv_LichSuThe";
            this.dgv_LichSuThe.RowHeadersWidth = 51;
            this.dgv_LichSuThe.RowTemplate.Height = 24;
            this.dgv_LichSuThe.Size = new System.Drawing.Size(795, 348);
            this.dgv_LichSuThe.TabIndex = 1;
            // 
            // Form_LichSuThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 351);
            this.Controls.Add(this.dgv_LichSuThe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_LichSuThe";
            this.Text = "Form_LichSuThe";
            this.Load += new System.EventHandler(this.Form_LichSuThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuThe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LichSuThe;
    }
}