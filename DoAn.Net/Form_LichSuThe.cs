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
    public partial class Form_LichSuThe : Form
    {
        DataConnect dataConnect = new DataConnect();
        int MaDG;
        public Form_LichSuThe(int pMaDG)
        {
            MaDG = pMaDG;
            InitializeComponent();
        }

        private void Form_LichSuThe_Load(object sender, EventArgs e)
        {
            List<LichSuDungThe> listLSDT = dataConnect.GetHistoryOfTheDG(MaDG);
            if (listLSDT != null)
            {
                // Tạo DataTable để chứa dữ liệu giao dịch
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã Thẻ");
                dt.Columns.Add("Mã Lịch sử dùng");
                dt.Columns.Add("Hoạt động");
                dt.Columns.Add("Lý do");
                dt.Columns.Add("Thời gian");


                // Thêm dữ liệu từ danh sách giao dịch vào DataTable
                foreach (var ls in listLSDT)
                {
                    dt.Rows.Add(ls.MaThe, ls.MaLSD, ls.HoatDong, ls.LyDo, ls.ThoiGian); ;
                }
                // Gán dữ liệu giao dịch vào dataGridViewGiaoDich
                dgv_LichSuThe.DataSource = dt;
                dgv_LichSuThe.Columns["Mã Thẻ"].Width = 70;
                dgv_LichSuThe.Columns["Mã Lịch sử dùng"].Width = 130;
                dgv_LichSuThe.Columns["Hoạt động"].Width = 100;
                dgv_LichSuThe.Columns["Lý do"].Width = 100;
                dgv_LichSuThe.Columns["Thời gian"].Width = 150;

            }
            else
            {
                MessageBox.Show("Không tìm thấy lịch sử dùng thẻ");
            }
        }

        private void Form_LichSuThe_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
