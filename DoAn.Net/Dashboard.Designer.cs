
namespace DoAn.Net
{
    partial class Dashboard
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
            System.Windows.Forms.MenuStrip menuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýThẻToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            menuStrip1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.độcGiảToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.mượnSáchToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.giaoDịchToolStripMenuItem,
            this.thoátToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            menuStrip1.Size = new System.Drawing.Size(1174, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(108, 30);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemĐộcGiảToolStripMenuItem,
            this.thêmĐộcGiảToolStripMenuItem,
            this.đăngKýThẻToolStripMenuItem});
            this.độcGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("độcGiảToolStripMenuItem.Image")));
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(125, 30);
            this.độcGiảToolStripMenuItem.Text = "Độc giả";
            // 
            // xemĐộcGiảToolStripMenuItem
            // 
            this.xemĐộcGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xemĐộcGiảToolStripMenuItem.Image")));
            this.xemĐộcGiảToolStripMenuItem.Name = "xemĐộcGiảToolStripMenuItem";
            this.xemĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.xemĐộcGiảToolStripMenuItem.Text = "Quản lý độc giả";
            this.xemĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.xemĐộcGiảToolStripMenuItem_Click);
            // 
            // thêmĐộcGiảToolStripMenuItem
            // 
            this.thêmĐộcGiảToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmĐộcGiảToolStripMenuItem.Image")));
            this.thêmĐộcGiảToolStripMenuItem.Name = "thêmĐộcGiảToolStripMenuItem";
            this.thêmĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.thêmĐộcGiảToolStripMenuItem.Text = "Thêm độc giả";
            this.thêmĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thêmĐộcGiảToolStripMenuItem_Click);
            // 
            // đăngKýThẻToolStripMenuItem
            // 
            this.đăngKýThẻToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngKýThẻToolStripMenuItem.Image")));
            this.đăngKýThẻToolStripMenuItem.Name = "đăngKýThẻToolStripMenuItem";
            this.đăngKýThẻToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.đăngKýThẻToolStripMenuItem.Text = "Quản lý thẻ độc giả";
            this.đăngKýThẻToolStripMenuItem.Click += new System.EventHandler(this.đăngKýThẻToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemSáchToolStripMenuItem,
            this.thêmSáchToolStripMenuItem});
            this.sáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sáchToolStripMenuItem.Image")));
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(100, 30);
            this.sáchToolStripMenuItem.Text = "Sách";
            // 
            // xemSáchToolStripMenuItem
            // 
            this.xemSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xemSáchToolStripMenuItem.Image")));
            this.xemSáchToolStripMenuItem.Name = "xemSáchToolStripMenuItem";
            this.xemSáchToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.xemSáchToolStripMenuItem.Text = "Xem sách";
            // 
            // thêmSáchToolStripMenuItem
            // 
            this.thêmSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmSáchToolStripMenuItem.Image")));
            this.thêmSáchToolStripMenuItem.Name = "thêmSáchToolStripMenuItem";
            this.thêmSáchToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.thêmSáchToolStripMenuItem.Text = "Thêm sách";
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mượnSáchToolStripMenuItem.Image")));
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.mượnSáchToolStripMenuItem.Text = "Mượn Sách";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sửaToolStripMenuItem.Image")));
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(137, 30);
            this.sửaToolStripMenuItem.Text = "Trả sách";
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmGiaoDịchToolStripMenuItem,
            this.thôngKêGiaoDịchToolStripMenuItem});
            this.giaoDịchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("giaoDịchToolStripMenuItem.Image")));
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.giaoDịchToolStripMenuItem.Text = "Giao dịch";
            // 
            // thêmGiaoDịchToolStripMenuItem
            // 
            this.thêmGiaoDịchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmGiaoDịchToolStripMenuItem.Image")));
            this.thêmGiaoDịchToolStripMenuItem.Name = "thêmGiaoDịchToolStripMenuItem";
            this.thêmGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.thêmGiaoDịchToolStripMenuItem.Text = "Thêm giao dịch";
            this.thêmGiaoDịchToolStripMenuItem.Click += new System.EventHandler(this.thêmGiaoDịchToolStripMenuItem_Click);
            // 
            // thôngKêGiaoDịchToolStripMenuItem
            // 
            this.thôngKêGiaoDịchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngKêGiaoDịchToolStripMenuItem.Image")));
            this.thôngKêGiaoDịchToolStripMenuItem.Name = "thôngKêGiaoDịchToolStripMenuItem";
            this.thôngKêGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.thôngKêGiaoDịchToolStripMenuItem.Text = "Thông kê giao dịch";
            this.thôngKêGiaoDịchToolStripMenuItem.Click += new System.EventHandler(this.thôngKêGiaoDịchToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(108, 30);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 655);
            this.Controls.Add(menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmGiaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýThẻToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngKêGiaoDịchToolStripMenuItem;
    }
}