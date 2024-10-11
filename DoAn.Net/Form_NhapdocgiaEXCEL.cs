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
    public partial class Form_NhapdocgiaEXCEL : Form
    {
        public Form_NhapdocgiaEXCEL()
        {
            InitializeComponent();
        }

        private void btn_chonFile_Click(object sender, EventArgs e)
        {
            DataConnect utl = new DataConnect();
            DataTable dt = utl.AccessExcel();
            OpenFileDialog openF = new OpenFileDialog();
            openF.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            if (openF.ShowDialog() == DialogResult.OK)
            {
                txt_TenTapTin.Text = openF.FileName;
                dgv_thongtindocgia.DataSource = dt;
            }
        }

        private void btn_adddulieu_Click(object sender, EventArgs e)
        {

            DocGia dg = new DocGia();
            DataConnect utl = new DataConnect();
            string result = "";
            List<int> rowsToRemove = new List<int>();
            DataTable dt = utl.AccessExcel();
            int count = dgv_thongtindocgia.RowCount;
            try
            {
                for (int i = count - 1; i >= 0; i--) // Lặp ngược để xóa các hàng đã được xử lý
                {
                    if (Convert.ToBoolean(dgv_thongtindocgia.Rows[i].Cells["Column1"].Value) == true)
                    {
                        dg.MaLDG = Convert.ToInt32(dgv_thongtindocgia.Rows[i].Cells["MaLDG"].Value?.ToString());
                        dg.HoTen = dgv_thongtindocgia.Rows[i].Cells["Ho Ten"].Value?.ToString();
                        dg.NgaySinh = DateTime.Parse(dgv_thongtindocgia.Rows[i].Cells["NgaySinh"].Value?.ToString());
                        dg.GioiTinh = dgv_thongtindocgia.Rows[i].Cells["GioiTinh"].Value?.ToString();
                        dg.DiaChi = dgv_thongtindocgia.Rows[i].Cells["DiaChi"].Value?.ToString();
                        dg.SDT = dgv_thongtindocgia.Rows[i].Cells["SDT"].Value?.ToString();
                        dg.Email = dgv_thongtindocgia.Rows[i].Cells["Email"].Value?.ToString();
                        dg.SoDu = float.Parse(dgv_thongtindocgia.Rows[i].Cells["SoDu"].Value?.ToString());
                        result = utl.InsertDocGia(dg);
                        if (result == "Success!!")
                        {
                            rowsToRemove.Add(i);
                        }
                    }
                }
                if (rowsToRemove.Count < 0)
                {
                    MessageBox.Show("Ban co muon them du lieu", "Thong Bao", MessageBoxButtons.YesNo);
                    return;
                }
                foreach (int rowIndex in rowsToRemove.OrderByDescending(r => r))
                {
                    dgv_thongtindocgia.Rows.RemoveAt(rowIndex);

                    // Remove the corresponding row from DataTable
                    if (rowIndex < dt.Rows.Count)
                    {
                        dt.Rows[rowIndex].Delete();
                    }
                }

                dt.AcceptChanges(); // Apply the changes in the DataTable

                // Update Excel file from the updated DataTable
                if (dt.Rows.Count > 0)
                {
                    string path = txt_TenTapTin.Text;
                    utl.ExportToExcel(dt, path); // Export data from DataTable to Excel file
                }
                dgv_thongtindocgia.DataSource = dt;
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erorr");
            }
        }

        private void Form_NhapdocgiaEXCEL_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Chắc chưa ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
