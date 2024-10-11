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
    public partial class Form_DenBu : Form
    {
        int maDG;
        DataConnect dataConnect = new DataConnect();
        public Form_DenBu(int pmaDG)
        {
            maDG = pmaDG;
            InitializeComponent();
        }

        private void Form_DenBu_Load(object sender, EventArgs e)
        {

        }

        private void txt_SoTien_TextChanged(object sender, EventArgs e)
        {
            TextBox soTienPhat = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(soTienPhat.Text))
            {
                this.errorProvider1.SetError(soTienPhat, "Trường này không được để trống.");
            }
            else if (!float.TryParse(soTienPhat.Text, out _))
            {
                this.errorProvider1.SetError(soTienPhat, "Vui lòng nhập số.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txt_GhiChu_TextChanged(object sender, EventArgs e)
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
                giaoDich.LoaiGD = "Đền bù";
                giaoDich.GhiChu = txt_GhiChu.Text;
                if (float.TryParse(txt_SoTien.Text, out float tien) && tien > 0)
                {
                    giaoDich.SoTien = tien;
                    int result = dataConnect.TaoGiaoDich(giaoDich);
                    if (result > 0)
                        MessageBox.Show("Đền bù thành công");
                    else MessageBox.Show("Đền bù thất bại!");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi đền bù!");
                }
                txt_SoTien.Clear();
                txt_GhiChu.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HuyNap_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy giao dịch", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            txt_SoTien.Clear();
            txt_GhiChu.Clear();
        }

        private void Form_DenBu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
