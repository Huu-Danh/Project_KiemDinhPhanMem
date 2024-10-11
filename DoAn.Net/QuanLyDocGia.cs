using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using CrystalDecisions.Windows.Forms;
using DoAn.Net;


namespace DoAn.Net
{
    public partial class QuanLyDocGia : Form
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
            
        }

        DataSet ds = new DataSet();
        DataConnect dataConnect = new DataConnect();

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TimKiemDocGia_Load(object sender, EventArgs e)
        {
            panel.Visible = false;
            ds = dataConnect.GetAllDG();
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy");
            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());

                LoaiDocGia loaiDocGia = new LoaiDocGia();

                if (ds.Tables[0].Rows[i][1].ToString() == "1")
                    loaiDocGia.TenLDG = "Sinh viên";
                else if (ds.Tables[0].Rows[i][1].ToString() == "2")
                    loaiDocGia.TenLDG = "Giảng viên";
                else
                    loaiDocGia.TenLDG = "Cán bộ";
                item.SubItems.Add(loaiDocGia.TenLDG);

                item.SubItems.Add(ds.Tables[0].Rows[i][2].ToString());

                DateTime date = DateTime.Parse(ds.Tables[0].Rows[i][3].ToString());
                string NgaySinh = date.ToString("yyyy-MM-dd");
                item.SubItems.Add(NgaySinh);

                string str = ds.Tables[0].Rows[i][4].ToString();
                if (str == "True")
                    str = "Nam";
                else
                    str = "Nữ";
                item.SubItems.Add(str);

                item.SubItems.Add(ds.Tables[0].Rows[i][5].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i][6].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i][7].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i][8].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i][9].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i][10].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i][11].ToString());
                item.SubItems.Add(ds.Tables[0].Rows[i][12].ToString());

                lsvt_DSDG.Items.Add(item);

            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            lsvt_DSDG.Items.Clear();

            if (cbo_TimKiem.Text == "Loại độc giả")
            {
                string str;
                if (txt_TimKiem.Text.ToUpper() == "Sinh viên".ToUpper())
                {
                    str = "1";
                }
                else if (txt_TimKiem.Text.ToUpper() == "Giảng viên".ToUpper())
                {
                    str = "2";
                }
                else
                {
                    str = "3";
                }
                ds = dataConnect.FindDG(cbo_TimKiem.Text, str);
            }
            else
            {
                ds = dataConnect.FindDG(cbo_TimKiem.Text, txt_TimKiem.Text);
            }

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(ds.Tables[0].Rows[i][0].ToString());

                    LoaiDocGia loaiDocGia = new LoaiDocGia();

                    if (ds.Tables[0].Rows[i][1].ToString() == "1")
                        loaiDocGia.TenLDG = "Sinh viên";
                    else if (ds.Tables[0].Rows[i][1].ToString() == "2")
                        loaiDocGia.TenLDG = "Giảng viên";
                    else
                        loaiDocGia.TenLDG = "Cán bộ";
                    item.SubItems.Add(loaiDocGia.TenLDG);

                    item.SubItems.Add(ds.Tables[0].Rows[i][2].ToString());

                    DateTime date = DateTime.Parse(ds.Tables[0].Rows[i][3].ToString());
                    string NgaySinh = date.ToString("yyyy-MM-dd");
                    item.SubItems.Add(NgaySinh);

                    string str = ds.Tables[0].Rows[i][4].ToString();
                    if (str == "True")
                        str = "Nam";
                    else
                        str = "Nữ";
                    item.SubItems.Add(str);

                    item.SubItems.Add(ds.Tables[0].Rows[i][5].ToString());
                    item.SubItems.Add(ds.Tables[0].Rows[i][6].ToString());
                    item.SubItems.Add(ds.Tables[0].Rows[i][7].ToString());
                    item.SubItems.Add(ds.Tables[0].Rows[i][8].ToString());
                    item.SubItems.Add(ds.Tables[0].Rows[i]["BoPhan"].ToString());
                    item.SubItems.Add(ds.Tables[0].Rows[i]["ChuyenMon"].ToString());
                    item.SubItems.Add(ds.Tables[0].Rows[i]["Lop"].ToString());
                    item.SubItems.Add(ds.Tables[0].Rows[i]["NamHoc"].ToString());


                    lsvt_DSDG.Items.Add(item);

                }
            }

            lb_Ketquatimkiem.Text = "Tìm được tất cả " + lsvt_DSDG.Items.Count + " kết quả";
        }

        private void cbo_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();
            cbo_TimKiem.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = dataConnect.DeleteDG(lsvt_DSDG.SelectedItems[0].Text);
            if (check)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            lsvt_DSDG.Items.Clear();
            TimKiemDocGia_Load(sender, e);

            txt_TenDayDu.Clear();
            txt_BoPhan.Clear();
            txt_SoDienThoai.Clear();
            txt_DiaChi.Clear();
            txt_LoaiDG.Clear();
            txt_Email.Clear();
            txt_Fax.Clear();
            txt_GioTinh.Clear();
            txt_Khoa.Clear();
            txt_Lop.Clear();
            txt_ChuyenMon.Clear();
        }

        public SinhVien GanSV()
        {
            SinhVien sv = new SinhVien();
            sv.MaDG = int.Parse(lsvt_DSDG.SelectedItems[0].Text);
            sv.HoTen = txt_TenDayDu.Text;
            sv.NgaySinh = dt_NgaySinh.Value;
            sv.GioiTinh = txt_GioTinh.Text;
            sv.DiaChi = txt_DiaChi.Text;
            sv.SDT = txt_SoDienThoai.Text;
            sv.Email = txt_Email.Text;
            sv.Fax = txt_Fax.Text;
            sv.Lop = txt_Lop.Text;
            sv.NamHoc = txt_Khoa.Text;
            return sv;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GanSV();

            bool check = dataConnect.UpdateSV(sv);
            if (check)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }

            lsvt_DSDG.Items.Clear();
            ds = dataConnect.GetAllDG();
            TimKiemDocGia_Load(sender, e);

            txt_TenDayDu.Clear();
            txt_BoPhan.Clear();
            txt_SoDienThoai.Clear();
            txt_DiaChi.Clear();
            txt_LoaiDG.Clear();
            txt_Email.Clear();
            txt_Fax.Clear();
            txt_GioTinh.Clear();
            txt_Khoa.Clear();
            txt_Lop.Clear();
            txt_ChuyenMon.Clear();

        }

        private void lsvt_DSDG_MouseClick(object sender, MouseEventArgs e)
        {
            if (lsvt_DSDG.Items != null)
            {
                panel.Visible = true;
            }

            string str = lsvt_DSDG.SelectedItems[0].SubItems[1].Text;
            if (str == "Giảng viên")
            {
                txt_ChuyenMon.Visible = true;
                txt_ChuyenMon.Text = lsvt_DSDG.SelectedItems[0].SubItems[10].Text;
                txt_BoPhan.Visible = false;
                txt_Lop.Visible = false;
                txt_Khoa.Visible = false;
            }
            else if (str == "Cán bộ")
            {
                txt_BoPhan.Visible = true;
                txt_BoPhan.Text = lsvt_DSDG.SelectedItems[0].SubItems[9].Text;
                txt_ChuyenMon.Visible = false;
                txt_Lop.Visible = false;
                txt_Khoa.Visible = false;
            }
            else
            {
                txt_Lop.Visible = true;
                txt_Khoa.Visible = true;
                txt_Lop.Text = lsvt_DSDG.SelectedItems[0].SubItems[11].Text;
                txt_Khoa.Text = lsvt_DSDG.SelectedItems[0].SubItems[12].Text;
                txt_BoPhan.Visible = false;
                txt_ChuyenMon.Visible = false;
            }

            txt_LoaiDG.Text = str;
            txt_TenDayDu.Text = lsvt_DSDG.SelectedItems[0].SubItems[2].Text;
            DateTime date = DateTime.ParseExact(lsvt_DSDG.SelectedItems[0].SubItems[3].Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            dt_NgaySinh.Value = date;
            txt_GioTinh.Text = lsvt_DSDG.SelectedItems[0].SubItems[4].Text;
            txt_DiaChi.Text = lsvt_DSDG.SelectedItems[0].SubItems[5].Text;
            txt_SoDienThoai.Text = lsvt_DSDG.SelectedItems[0].SubItems[6].Text;
            txt_Email.Text = lsvt_DSDG.SelectedItems[0].SubItems[7].Text;
            txt_Fax.Text = lsvt_DSDG.SelectedItems[0].SubItems[8].Text;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            lsvt_DSDG.Items.Clear();
            TimKiemDocGia_Load(sender, e);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
