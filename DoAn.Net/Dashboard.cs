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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void thêmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            From_DangKy dk = new From_DangKy();
            dk.Show();
        }

        private void xemĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia quanLyDocGia = new QuanLyDocGia();
            quanLyDocGia.Show();
        }

        private void thêmGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDichTaiChinh giaoDich = new GiaoDichTaiChinh();
            giaoDich.Show();
        }

        private void đăngKýThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThe quanLyThe = new QuanLyThe();
            quanLyThe.Show();
        }

        private void thôngKêGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ThongKeGD GD = new Form_ThongKeGD();
            GD.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataConnect connect = new DataConnect();
            SqlConnection conn = connect.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CheckAndLockExpiredCards";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
