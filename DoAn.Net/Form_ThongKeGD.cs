using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.Net
{
    public partial class Form_ThongKeGD : Form
    {
        public Form_ThongKeGD()
        {
            InitializeComponent();
        }

        private void Form_ThongKeGD_Load(object sender, EventArgs e)
        {
            DataConnect utl = new DataConnect();
            GiaoDichRP rp = new GiaoDichRP();
            crystalReportViewer1.ReportSource = rp;
            DataSet ds_loaiGD = utl.GetAllLoaiGD();
            DataSet ds_ngayGD = utl.GetAllNgayGD();
            for(int i = 0; i<ds_loaiGD.Tables[0].Rows.Count;i++)
            {
                cbo_loaigd.Items.Add(ds_loaiGD.Tables[0].Rows[i][0].ToString());
            }
            for(int i = 0; i<ds_ngayGD.Tables[0].Rows.Count;i++)
            {
                cbo_ngaygd.Items.Add(ds_ngayGD.Tables[0].Rows[i][0].ToString());
            }
        }

        private void lọcTheoLoạiGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbo_loaigd.Enabled = true;
            cbo_ngaygd.Enabled = false;
        }

        private void lọcTheoNgàyGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbo_loaigd.Enabled = false;
            cbo_ngaygd.Enabled = true;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            DataConnect utl = new DataConnect();
            GiaoDich gd = new GiaoDich();
            GiaoDichRP gdrp = new GiaoDichRP();
            if(cbo_loaigd.Enabled == true)
            {
                gd.LoaiGD = cbo_loaigd.SelectedItem.ToString();
                DataSet dataSet = utl.Find_LoaiGD(gd);
                gdrp.SetDataSource(dataSet);
            }
            else if(cbo_ngaygd.Enabled == true)
            {
                gd.NgayGD = cbo_ngaygd.SelectedItem.ToString();
                DataSet dataSet = utl.Find_NgayGD(gd);
                gdrp.SetDataSource(dataSet);
            }
            else
            {
                MessageBox.Show("Nhập thông tin muốn tìm", "Thông báo");
            }
            crystalReportViewer1.ReportSource = gdrp;
            crystalReportViewer1.RefreshReport();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            GiaoDichRP rp = new GiaoDichRP();
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.RefreshReport();
        }

        private void Form_ThongKeGD_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
