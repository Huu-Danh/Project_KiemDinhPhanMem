
namespace DoAn.Net
{
    partial class Form_MoKhoaThe
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
            this.components = new System.ComponentModel.Container();
            this.HuyNap_button = new System.Windows.Forms.Button();
            this.xacNhanPhat_Button = new System.Windows.Forms.Button();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.txt_SoTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // HuyNap_button
            // 
            this.HuyNap_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyNap_button.Location = new System.Drawing.Point(260, 216);
            this.HuyNap_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HuyNap_button.Name = "HuyNap_button";
            this.HuyNap_button.Size = new System.Drawing.Size(125, 48);
            this.HuyNap_button.TabIndex = 29;
            this.HuyNap_button.Text = "Hủy";
            this.HuyNap_button.UseVisualStyleBackColor = true;
            this.HuyNap_button.Click += new System.EventHandler(this.HuyNap_button_Click);
            // 
            // xacNhanPhat_Button
            // 
            this.xacNhanPhat_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xacNhanPhat_Button.Location = new System.Drawing.Point(46, 216);
            this.xacNhanPhat_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xacNhanPhat_Button.Name = "xacNhanPhat_Button";
            this.xacNhanPhat_Button.Size = new System.Drawing.Size(126, 48);
            this.xacNhanPhat_Button.TabIndex = 28;
            this.xacNhanPhat_Button.Text = "Đồng ý";
            this.xacNhanPhat_Button.UseVisualStyleBackColor = true;
            this.xacNhanPhat_Button.Click += new System.EventHandler(this.xacNhanPhat_Button_Click);
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GhiChu.Location = new System.Drawing.Point(46, 166);
            this.txt_GhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(339, 30);
            this.txt_GhiChu.TabIndex = 27;
            this.txt_GhiChu.TextChanged += new System.EventHandler(this.txt_GhiChu_TextChanged);
            // 
            // txt_SoTien
            // 
            this.txt_SoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoTien.Location = new System.Drawing.Point(46, 68);
            this.txt_SoTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoTien.Name = "txt_SoTien";
            this.txt_SoTien.Size = new System.Drawing.Size(339, 30);
            this.txt_SoTien.TabIndex = 26;
            this.txt_SoTien.TextChanged += new System.EventHandler(this.txt_SoTien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ghi chú:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Số tiền:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_MoKhoaThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(433, 307);
            this.Controls.Add(this.HuyNap_button);
            this.Controls.Add(this.xacNhanPhat_Button);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.txt_SoTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_MoKhoaThe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mở thẻ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MoKhoaThe_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HuyNap_button;
        private System.Windows.Forms.Button xacNhanPhat_Button;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.TextBox txt_SoTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}