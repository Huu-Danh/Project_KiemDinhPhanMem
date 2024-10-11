using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Net
{
    public partial class Form_PhatTien : Form
    {
        int maDG;
        DataConnect dataConnect = new DataConnect();
        public Form_PhatTien(int pMaDG)
        {
            maDG = pMaDG;
            InitializeComponent();
        }

        private void Form_PhatTien_Load(object sender, EventArgs e)
        {

        }

        private void soTienPhat_TextChanged(object sender, EventArgs e)
        {
            TextBox soTienPhat = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(soTienPhat.Text))
            {
                this.errorProvider1.SetError(soTienPhat, "Trường này không được để trống.");
            }
            else if (!float.TryParse(soTienPhat.Text, out float soTien) || soTien <= 0)
            {
                this.errorProvider1.SetError(soTienPhat, "Bạn phải nhập số vào trường Số tiền, không âm và không chứa ký tự!");
         
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void ghiChuPhat_TextChanged(object sender, EventArgs e)
        {
            TextBox ghiChuPhat = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(ghiChuPhat.Text))
            {
                this.errorProvider1.SetError(ghiChuPhat, "Trường này không được để trống.");
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
                giaoDich.LoaiGD = "Phạt tiền";
                giaoDich.GhiChu = txt_GhiChu.Text;

                if (float.TryParse(txt_SoTien.Text, out float tien) && tien > 0)
                {
                    giaoDich.SoTien = tien;
                    int result = dataConnect.TaoGiaoDich(giaoDich);
                    if (result > 0)
                        MessageBox.Show("Phạt tiền thành công");
                    else MessageBox.Show("Phạt  tiền thất bại!");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số dương.");
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
            txt_SoTien.Clear();
            txt_GhiChu.Clear();
        }

        private void Form_PhatTien_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
