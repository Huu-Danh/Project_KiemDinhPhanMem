using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoAn.Net
{
    public partial class Form_NapTien : Form
    {
        DataConnect dataConnect = new DataConnect();
        int maDG;
       
        public Form_NapTien(int pmaDG)
        {
            InitializeComponent();
            maDG = pmaDG;

        }

        private void Form_NapTien_Load(object sender, EventArgs e)
        {

        }

        private void soTienPhat_TextChanged(object sender, EventArgs e)
        {
            TextBox soTienNap = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(soTienNap.Text))
            {
                this.errorProvider1.SetError(soTienNap, "Trường này không được để trống.");
            }
            else if (!float.TryParse(soTienNap.Text, out _))
            {
                this.errorProvider1.SetError(soTienNap, "Bạn phải nhập số vào trường Số tiền, không âm và không chứa ký tự!");

            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void ghiChuPhat_TextChanged(object sender, EventArgs e)
        {
            TextBox ghiChuNap = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(ghiChuNap.Text))
            {
                this.errorProvider1.SetError(ghiChuNap, "Trường này không được để trống.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void xacNhanPhat_Button_Click(object sender, EventArgs e)
        {
            try
            {
            GiaoDich giaoDich = new GiaoDich();
            giaoDich.MaDG = maDG;
            giaoDich.LoaiGD = "Nạp tiền";
            giaoDich.GhiChu = txt_GhiChu.Text;
            if (float.TryParse(txt_SoTien.Text, out float tien) && tien > 0)
                {
                    giaoDich.SoTien = tien;
                    int result = dataConnect.TaoGiaoDich(giaoDich);
                    if (result > 0)
                    MessageBox.Show("Nạp tiền thành công");
                else MessageBox.Show("Nạp tiền thất bại!");
            }
            else
            {
                MessageBox.Show("Có lỗi khi nạp!");
            }
            txt_SoTien.Text = "";
            txt_GhiChu.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void HuyNap_button_Click(object sender, EventArgs e)
        {
            txt_SoTien.Text ="";
            txt_GhiChu.Text = "";
        }

        private void Form_NapTien_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
