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
using DoAn.Net;
using System.Data.SqlClient;
namespace DoAn.Net
{
    public partial class QuanLyThe : Form
    {
        public QuanLyThe()
        {
            InitializeComponent();
        }

        DataConnect dataConnect = new DataConnect();
        DataSet dataSet = new DataSet();

        private void QuanLyThe_Load(object sender, EventArgs e)
        {
            try { 
                dataSet = dataConnect.GetAllDocGiaCoThe();
                if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dataSet.Tables[0].Rows[i][0].ToString());
                    item.SubItems.Add(dataSet.Tables[0].Rows[i][1].ToString());
                    LoaiDocGia loaiDocGia = new LoaiDocGia();



                    item.SubItems.Add(dataSet.Tables[0].Rows[i][2].ToString());

                    DateTime date1 = DateTime.Parse(dataSet.Tables[0].Rows[i][3].ToString());
                    string NgayDangKy = date1.ToString("yyyy-MM-dd");
                    item.SubItems.Add(NgayDangKy);
                    DateTime date2 = DateTime.Parse(dataSet.Tables[0].Rows[i][4].ToString());
                    string NgayHetHan = date2.ToString("yyyy-MM-dd");
                    item.SubItems.Add(NgayHetHan);
                    item.SubItems.Add(dataSet.Tables[0].Rows[i][5].ToString());
                    DateTime date3 = DateTime.Parse(dataSet.Tables[0].Rows[i][6].ToString());
                    string NgaySinh = date3.ToString("yyyy-MM-dd");
                    item.SubItems.Add(NgaySinh);
                    string str = dataSet.Tables[0].Rows[i][7].ToString();
                    if (str == "True")
                        str = "Nam";
                    else
                        str = "Nữ";
                    item.SubItems.Add(str);
                    item.SubItems.Add(dataSet.Tables[0].Rows[i][8].ToString());
                    item.SubItems.Add(dataSet.Tables[0].Rows[i][9].ToString());
                    item.SubItems.Add(dataSet.Tables[0].Rows[i][10].ToString());
                    if (dataSet.Tables[0].Rows[i][11].ToString() == "1")
                        loaiDocGia.TenLDG = "Sinh viên";
                    else if (dataSet.Tables[0].Rows[i][11].ToString() == "2")
                        loaiDocGia.TenLDG = "Giảng viên";
                    else
                        loaiDocGia.TenLDG = "Cán bộ";
                    item.SubItems.Add(loaiDocGia.TenLDG);
                    lsvt_DSDG.Items.Add(item);
                }
        }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btn_InThe_Click(object sender, EventArgs e)
        {
            try { 
            //Bước 1: Nạp file mẫu
            Document baoCao = new Document(@"D:\New folder\dotNet\MoiNhat\DoAn.Net\DoAn.Net\Mau_Bao_Cao.doc");

            //Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "HO_TEN" }, new[] { txt_TenDayDu.Text });
            baoCao.MailMerge.Execute(new[] { "Ma_The" }, new[] { txt_MaThe.Text });
            baoCao.MailMerge.Execute(new[] { "Loai_DG" }, new[] { txt_LoaiDG.Text});

            baoCao.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { txt_NgaySinh.Text});
      
            baoCao.MailMerge.Execute(new[] { "Ngay_Dang_Ky" }, new[] { txt_NgayDK.Text});
          
            baoCao.MailMerge.Execute(new[] { "Ngay_Het_Han" }, new[] {txt_NgayHetHan.Text });

            //Bước 4: Lưu và mở file
            baoCao.SaveAndOpenFile("BaoCao.doc");
        }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void cbo_TimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            lsvt_DSDG.Items.Clear();
            try
            {
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
                    dataSet = dataConnect.FindTheDG(cbo_TimKiem.Text, str);
                }
                else
                {
                    dataSet = dataConnect.FindTheDG(cbo_TimKiem.Text, txt_TimKiem.Text);
                }

                if (dataSet == null || dataSet.Tables.Count == 0 || dataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {

                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(dataSet.Tables[0].Rows[i][0].ToString());
                        item.SubItems.Add(dataSet.Tables[0].Rows[i][1].ToString());
                        LoaiDocGia loaiDocGia = new LoaiDocGia();



                        item.SubItems.Add(dataSet.Tables[0].Rows[i][2].ToString());

                        DateTime date1 = DateTime.Parse(dataSet.Tables[0].Rows[i][3].ToString());
                        string NgayDangKy = date1.ToString("yyyy-MM-dd");
                        item.SubItems.Add(NgayDangKy);
                        DateTime date2 = DateTime.Parse(dataSet.Tables[0].Rows[i][4].ToString());
                        string NgayHetHan = date2.ToString("yyyy-MM-dd");
                        item.SubItems.Add(NgayHetHan);
                        item.SubItems.Add(dataSet.Tables[0].Rows[i][5].ToString());
                        DateTime date3 = DateTime.Parse(dataSet.Tables[0].Rows[i][6].ToString());
                        string NgaySinh = date3.ToString("yyyy-MM-dd");
                        item.SubItems.Add(NgaySinh);
                        string str = dataSet.Tables[0].Rows[i][7].ToString();
                        if (str == "True")
                            str = "Nam";
                        else
                            str = "Nữ";
                        item.SubItems.Add(str);
                        item.SubItems.Add(dataSet.Tables[0].Rows[i][8].ToString());
                        item.SubItems.Add(dataSet.Tables[0].Rows[i][9].ToString());
                        item.SubItems.Add(dataSet.Tables[0].Rows[i][10].ToString());
                        if (dataSet.Tables[0].Rows[i][11].ToString() == "1")
                            loaiDocGia.TenLDG = "Sinh viên";
                        else if (dataSet.Tables[0].Rows[i][11].ToString() == "2")
                            loaiDocGia.TenLDG = "Giảng viên";
                        else
                            loaiDocGia.TenLDG = "Cán bộ";
                        item.SubItems.Add(loaiDocGia.TenLDG);
                        lsvt_DSDG.Items.Add(item);
                    }
                }

                lb_Ketquatimkiem.Text = "Tìm được tất cả " + lsvt_DSDG.Items.Count + " kết quả";
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvt_DSDG_MouseClick(object sender, MouseEventArgs e)
        {
            try { 
            if (lsvt_DSDG.Items != null)
            {
                panel.Visible = true;
            }

            string str = lsvt_DSDG.SelectedItems[0].SubItems[11].Text;
            if (str == "Giảng viên")
            {
                txt_LoaiDG.Text = lsvt_DSDG.SelectedItems[0].SubItems[11].Text;
            }
            else if (str == "Cán bộ")
            {
                txt_LoaiDG.Text = lsvt_DSDG.SelectedItems[0].SubItems[11].Text;
            }
            else
            {
                txt_LoaiDG.Text = lsvt_DSDG.SelectedItems[0].SubItems[11].Text;
            }

            txt_LoaiDG.Text = str;
            txt_TenDayDu.Text = lsvt_DSDG.SelectedItems[0].SubItems[5].Text;
            txt_NgaySinh.Text = lsvt_DSDG.SelectedItems[0].SubItems[6].Text;
            txt_SoDienThoai.Text = lsvt_DSDG.SelectedItems[0].SubItems[10].Text;
            txt_Email.Text = lsvt_DSDG.SelectedItems[0].SubItems[7].Text;
            txt_MaThe.Text = lsvt_DSDG.SelectedItems[0].SubItems[0].Text;
            txt_TinhTrang.Text = lsvt_DSDG.SelectedItems[0].SubItems[2].Text;
            txt_NgayDK.Text = lsvt_DSDG.SelectedItems[0].SubItems[3].Text;
            txt_NgayHetHan.Text = lsvt_DSDG.SelectedItems[0].SubItems[4].Text;
        }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            try { 
            lsvt_DSDG.Items.Clear();
            QuanLyThe_Load(sender, e);
        }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void buttonLichSuThe_Click(object sender, EventArgs e)
        {
            try
            {
                int maDGN = int.Parse(txt_MaThe.Text);
                Form_LichSuThe flst = new Form_LichSuThe(maDGN);
                flst.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải chọn thẻ trước khi xem lịch sử thẻ." + ex);
            }
        }

        private void QuanLyThe_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
