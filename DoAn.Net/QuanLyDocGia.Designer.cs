
namespace DoAn.Net
{
    partial class QuanLyDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDocGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.cbo_TimKiem = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvt_DSDG = new System.Windows.Forms.ListView();
            this.MaDG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenLDG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BoPhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChuyenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_Ketquatimkiem = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.txt_LoaiDG = new System.Windows.Forms.TextBox();
            this.txt_GioTinh = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_ChuyenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Fax = new System.Windows.Forms.TextBox();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Khoa = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_BoPhan = new System.Windows.Forms.TextBox();
            this.txt_TenDayDu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.cbo_TimKiem);
            this.panel1.Location = new System.Drawing.Point(4, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 37);
            this.panel1.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(242, 10);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(661, 23);
            this.txt_TimKiem.TabIndex = 1;
            this.txt_TimKiem.Text = "Từ Khóa";
            // 
            // cbo_TimKiem
            // 
            this.cbo_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TimKiem.FormattingEnabled = true;
            this.cbo_TimKiem.Items.AddRange(new object[] {
            "Mã độc giả",
            "Họ tên",
            "Ngày sinh",
            "Số điện thoại",
            "Email",
            "Địa chỉ",
            "Loại độc giả",
            "Giới tính"});
            this.cbo_TimKiem.Location = new System.Drawing.Point(6, 9);
            this.cbo_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_TimKiem.Name = "cbo_TimKiem";
            this.cbo_TimKiem.Size = new System.Drawing.Size(234, 24);
            this.cbo_TimKiem.TabIndex = 0;
            this.cbo_TimKiem.SelectedIndexChanged += new System.EventHandler(this.cbo_TimKiem_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lsvt_DSDG);
            this.panel2.Controls.Add(this.lb_Ketquatimkiem);
            this.panel2.Location = new System.Drawing.Point(4, 161);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 325);
            this.panel2.TabIndex = 1;
            // 
            // lsvt_DSDG
            // 
            this.lsvt_DSDG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaDG,
            this.TenLDG,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SDT,
            this.Email,
            this.Fax,
            this.BoPhan,
            this.ChuyenMon,
            this.Lop,
            this.NamHoc});
            this.lsvt_DSDG.HideSelection = false;
            this.lsvt_DSDG.Location = new System.Drawing.Point(0, 21);
            this.lsvt_DSDG.Margin = new System.Windows.Forms.Padding(2);
            this.lsvt_DSDG.Name = "lsvt_DSDG";
            this.lsvt_DSDG.Size = new System.Drawing.Size(1112, 304);
            this.lsvt_DSDG.TabIndex = 13;
            this.lsvt_DSDG.UseCompatibleStateImageBehavior = false;
            this.lsvt_DSDG.View = System.Windows.Forms.View.Details;
            this.lsvt_DSDG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvt_DSDG_MouseClick);
            // 
            // MaDG
            // 
            this.MaDG.Text = "Mã độc giả";
            this.MaDG.Width = 74;
            // 
            // TenLDG
            // 
            this.TenLDG.Text = "Tên loại độc giả";
            this.TenLDG.Width = 95;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 100;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "Ngày sinh";
            this.NgaySinh.Width = 110;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "Giới tính";
            this.GioiTinh.Width = 91;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 168;
            // 
            // SDT
            // 
            this.SDT.Text = "Số điện thoại";
            this.SDT.Width = 107;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 78;
            // 
            // Fax
            // 
            this.Fax.Text = "Fax";
            this.Fax.Width = 55;
            // 
            // BoPhan
            // 
            this.BoPhan.Text = "Bộ phận";
            this.BoPhan.Width = 81;
            // 
            // ChuyenMon
            // 
            this.ChuyenMon.Text = "Chuyên môn";
            this.ChuyenMon.Width = 111;
            // 
            // Lop
            // 
            this.Lop.Text = "Lớp";
            this.Lop.Width = 89;
            // 
            // NamHoc
            // 
            this.NamHoc.Text = "Năm học";
            this.NamHoc.Width = 147;
            // 
            // lb_Ketquatimkiem
            // 
            this.lb_Ketquatimkiem.AutoSize = true;
            this.lb_Ketquatimkiem.BackColor = System.Drawing.Color.White;
            this.lb_Ketquatimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ketquatimkiem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Ketquatimkiem.Location = new System.Drawing.Point(3, 0);
            this.lb_Ketquatimkiem.Name = "lb_Ketquatimkiem";
            this.lb_Ketquatimkiem.Size = new System.Drawing.Size(199, 18);
            this.lb_Ketquatimkiem.TabIndex = 12;
            this.lb_Ketquatimkiem.Text = "Tìm được tất cả 0 kết quả";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(941, 118);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(73, 41);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel.Controls.Add(this.txt_LoaiDG);
            this.panel.Controls.Add(this.txt_GioTinh);
            this.panel.Controls.Add(this.btn_Xoa);
            this.panel.Controls.Add(this.btn_Sua);
            this.panel.Controls.Add(this.txt_ChuyenMon);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txt_DiaChi);
            this.panel.Controls.Add(this.txt_Fax);
            this.panel.Controls.Add(this.txt_Lop);
            this.panel.Controls.Add(this.txt_Email);
            this.panel.Controls.Add(this.label17);
            this.panel.Controls.Add(this.label16);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.txt_Khoa);
            this.panel.Controls.Add(this.label15);
            this.panel.Controls.Add(this.label14);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.dt_NgaySinh);
            this.panel.Controls.Add(this.txt_SoDienThoai);
            this.panel.Controls.Add(this.txt_BoPhan);
            this.panel.Controls.Add(this.txt_TenDayDu);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Location = new System.Drawing.Point(4, 488);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1111, 208);
            this.panel.TabIndex = 15;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txt_LoaiDG
            // 
            this.txt_LoaiDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoaiDG.Enabled = false;
            this.txt_LoaiDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_LoaiDG.Location = new System.Drawing.Point(487, 129);
            this.txt_LoaiDG.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LoaiDG.Name = "txt_LoaiDG";
            this.txt_LoaiDG.Size = new System.Drawing.Size(220, 27);
            this.txt_LoaiDG.TabIndex = 116;
            // 
            // txt_GioTinh
            // 
            this.txt_GioTinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GioTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_GioTinh.Location = new System.Drawing.Point(856, 91);
            this.txt_GioTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GioTinh.Name = "txt_GioTinh";
            this.txt_GioTinh.Size = new System.Drawing.Size(220, 27);
            this.txt_GioTinh.TabIndex = 115;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Location = new System.Drawing.Point(976, 148);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(99, 44);
            this.btn_Xoa.TabIndex = 114;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Sua.Location = new System.Drawing.Point(856, 148);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(99, 44);
            this.btn_Sua.TabIndex = 113;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_ChuyenMon
            // 
            this.txt_ChuyenMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ChuyenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_ChuyenMon.Location = new System.Drawing.Point(856, 14);
            this.txt_ChuyenMon.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ChuyenMon.Name = "txt_ChuyenMon";
            this.txt_ChuyenMon.Size = new System.Drawing.Size(220, 27);
            this.txt_ChuyenMon.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 111;
            this.label2.Text = "Chuyên môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 110;
            this.label1.Text = "Địa chỉ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_DiaChi.Location = new System.Drawing.Point(142, 172);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(564, 27);
            this.txt_DiaChi.TabIndex = 109;
            // 
            // txt_Fax
            // 
            this.txt_Fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_Fax.Location = new System.Drawing.Point(856, 54);
            this.txt_Fax.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Fax.Name = "txt_Fax";
            this.txt_Fax.Size = new System.Drawing.Size(220, 27);
            this.txt_Fax.TabIndex = 108;
            // 
            // txt_Lop
            // 
            this.txt_Lop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_Lop.Location = new System.Drawing.Point(487, 50);
            this.txt_Lop.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.Size = new System.Drawing.Size(220, 27);
            this.txt_Lop.TabIndex = 107;
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_Email.Location = new System.Drawing.Point(487, 89);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(220, 27);
            this.txt_Email.TabIndex = 106;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(754, 59);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 18);
            this.label17.TabIndex = 105;
            this.label17.Text = "Fax";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(382, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 18);
            this.label16.TabIndex = 104;
            this.label16.Text = "Lớp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(382, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 103;
            this.label9.Text = "Email";
            // 
            // txt_Khoa
            // 
            this.txt_Khoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_Khoa.Location = new System.Drawing.Point(487, 14);
            this.txt_Khoa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Khoa.Name = "txt_Khoa";
            this.txt_Khoa.Size = new System.Drawing.Size(220, 27);
            this.txt_Khoa.TabIndex = 99;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(382, 17);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 18);
            this.label15.TabIndex = 97;
            this.label15.Text = "Khóa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(754, 98);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 96;
            this.label14.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(382, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 95;
            this.label12.Text = "Loại độc giả";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_NgaySinh.Location = new System.Drawing.Point(142, 60);
            this.dt_NgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(219, 23);
            this.dt_NgaySinh.TabIndex = 93;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_SoDienThoai.Location = new System.Drawing.Point(142, 132);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(220, 27);
            this.txt_SoDienThoai.TabIndex = 92;
            // 
            // txt_BoPhan
            // 
            this.txt_BoPhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BoPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_BoPhan.Location = new System.Drawing.Point(142, 94);
            this.txt_BoPhan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BoPhan.Name = "txt_BoPhan";
            this.txt_BoPhan.Size = new System.Drawing.Size(220, 27);
            this.txt_BoPhan.TabIndex = 91;
            // 
            // txt_TenDayDu
            // 
            this.txt_TenDayDu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenDayDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.txt_TenDayDu.Location = new System.Drawing.Point(142, 19);
            this.txt_TenDayDu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenDayDu.Name = "txt_TenDayDu";
            this.txt_TenDayDu.Size = new System.Drawing.Size(220, 27);
            this.txt_TenDayDu.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 61;
            this.label7.Text = "Bộ phận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Tên đầy đủ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1233, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refesh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refesh.Image")));
            this.btn_Refesh.Location = new System.Drawing.Point(1042, 117);
            this.btn_Refesh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(73, 41);
            this.btn_Refesh.TabIndex = 17;
            this.btn_Refesh.UseVisualStyleBackColor = false;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(7, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 106);
            this.panel3.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(578, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Độc giả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(578, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quản lý ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, -19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 701);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Refesh);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý độc gỉa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyDocGia_FormClosing);
            this.Load += new System.EventHandler(this.TimKiemDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.ComboBox cbo_TimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_Ketquatimkiem;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListView lsvt_DSDG;
        private System.Windows.Forms.ColumnHeader MaDG;
        private System.Windows.Forms.ColumnHeader TenLDG;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Fax;
        private System.Windows.Forms.ColumnHeader BoPhan;
        private System.Windows.Forms.ColumnHeader ChuyenMon;
        private System.Windows.Forms.ColumnHeader Lop;
        private System.Windows.Forms.ColumnHeader NamHoc;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_BoPhan;
        private System.Windows.Forms.TextBox txt_TenDayDu;
        private System.Windows.Forms.TextBox txt_Khoa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ChuyenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Fax;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_GioTinh;
        private System.Windows.Forms.TextBox txt_LoaiDG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}