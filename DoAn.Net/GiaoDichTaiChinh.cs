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
    public partial class GiaoDichTaiChinh : Form
    {
        public GiaoDichTaiChinh()
        {
            InitializeComponent();
        }

        DataConnect dataConnect = new DataConnect();

        private void button_Nap_Click(object sender, EventArgs e)
        {
            try
            {
                int maDG = int.Parse(textBoxMaDG.Text);
                Form_NapTien napTien = new Form_NapTien(maDG);
                napTien.FormClosed += FormClosed;
                napTien.Show();
            }catch(Exception ex )
            {
                MessageBox.Show("Có lỗi xảy ra, có vẻ bạn chưa nhập mã độc giả để thực hiện chức năng! " + ex.Message); MessageBox.Show(ex.Message);
            }
        }
        //Dùng để load lại data khi đóng form
        private void FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                textBoxMaDG_TextChanged(textBoxMaDG, EventArgs.Empty);
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, có vẻ bạn chưa nhập mã độc giả để thực hiện chức năng! " + ex.Message);
            }
           
        }
        private void label3_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_MoThe_Click(object sender, EventArgs e)
        {
            try
            {
                int maDG = int.Parse(textBoxMaDG.Text);
                Form_MoKhoaThe moKhoaThe = new Form_MoKhoaThe(maDG);
                moKhoaThe.FormClosed += FormClosed;
                moKhoaThe.Show();
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, có vẻ bạn chưa nhập mã độc giả để thực hiện chức năng! " + ex.Message);
            }
        }

        private void button_Den_Click(object sender, EventArgs e)
        {
            try
            {
            int maDG = int.Parse(textBoxMaDG.Text);
            Form_DenBu denBu = new Form_DenBu(maDG);
            denBu.FormClosed += FormClosed;
            denBu.Show();
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, có vẻ bạn chưa nhập mã độc giả để thực hiện chức năng! " + ex.Message);
            }
        }

        private void button_Phat_Click(object sender, EventArgs e)
        {
            try
            {
                int maDG = int.Parse(textBoxMaDG.Text);
                Form_PhatTien phatTien = new Form_PhatTien(maDG);
                phatTien.FormClosed += FormClosed;
                phatTien.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, có vẻ bạn chưa nhập mã độc giả để thực hiện chức năng! " + ex.Message);
            }
        }

        private void button_Rut_Click(object sender, EventArgs e)
        {
            try
            {
                int maDG = int.Parse(textBoxMaDG.Text);
                Form_RutTien rutTien = new Form_RutTien(maDG);
                rutTien.FormClosed += FormClosed;
                rutTien.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, có vẻ bạn chưa nhập mã độc giả để thực hiện chức năng! " + ex.Message);
            }
        }

        private void button_Thu_Click(object sender, EventArgs e)
        {
            try
            {
                int maDG = int.Parse(textBoxMaDG.Text);
                Form_ThuPhi thuPhi = new Form_ThuPhi(maDG);
                thuPhi.FormClosed += FormClosed;
                thuPhi.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, có vẻ bạn chưa nhập mã độc giả để thực hiện chức năng! " + ex.Message);
            }
        }

        private void textBoxMaDG_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ textBox
            try
            {
                string input = textBoxMaDG.Text;
                DataSet ds_Madg = dataConnect.KiemtraTheDG();
                
                if (string.IsNullOrWhiteSpace(input))
                {
                    this.errorProvider1.SetError(textBoxMaDG, "Trường này không được để trống.");
                    listBoxDocGia.Visible = false;
                }
                else if (!int.TryParse(input, out int ma))
                {
                    this.errorProvider1.SetError(textBoxMaDG, "Nhập số hợp lệ.");
                    listBoxDocGia.Visible = false;
                }
                else
                {
                    this.errorProvider1.Clear();
                    for (int i = 0; i<ds_Madg.Tables[0].Rows.Count; i++)
                    {
                        if (input== ds_Madg.Tables[0].Rows[i]["MaDG"].ToString())
                        {
                            button_MoThe.Enabled = true;
                            break;
                        }
                        else
                        {
                            button_MoThe.Enabled = false;
                        }
                    }
                    // Lấy thông tin độc giả từ hàm LayThongTinDocGia
                    DocGia docgia = dataConnect.LayThongTinDocGia(ma);
                    List<GiaoDich> listGiaoDich = dataConnect.LayDSGiaoDich(ma);
                    // Kiểm tra xem có tìm thấy độc giả hay không
                    if (docgia != null)
                    {
                        // Gán dữ liệu độc giả vào listBoxDocGia
                        listBoxDocGia.Items.Clear();
                        string str = null;
                        if (docgia.MaLDG == 1)
                        {
                            str = "Sinh viên";
                        }
                        else if (docgia.MaLDG == 2)
                        {
                            str = "Giảng viên";
                        }
                        else
                        {
                            str = "Cán bộ";
                        }
                        listBoxDocGia.Items.Add("Loại độc giả: " + str);
                        listBoxDocGia.Items.Add("Họ tên: " + docgia.HoTen);
                        listBoxDocGia.Items.Add("Ngày sinh: " + docgia.NgaySinh.ToString("yyyy - MM - dd"));
                        listBoxDocGia.Items.Add("Giới tính: " + docgia.GioiTinh);
                        listBoxDocGia.Items.Add("Địa chỉ: " + docgia.DiaChi);
                        listBoxDocGia.Items.Add("SĐT: " + docgia.SDT);
                        listBoxDocGia.Items.Add("Email: " + docgia.Email);
                        listBoxDocGia.Items.Add("Fax: " + docgia.Fax);
                        listBoxDocGia.Items.Add("Số dư: " + docgia.SoDu);

                        // Hiển thị listBoxDocGia
                        listBoxDocGia.Visible = true;
                        // Tạo DataTable để chứa dữ liệu giao dịch
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Mã GD");
                        dt.Columns.Add("Loại GD");
                        dt.Columns.Add("Số Tiền");
                        dt.Columns.Add("Ngày Giao Dịch");
                        dt.Columns.Add("Ghi Chú");

                        // Thêm dữ liệu từ danh sách giao dịch vào DataTable
                        foreach (var gd in listGiaoDich)
                        {
                            dt.Rows.Add(gd.MaGD, gd.LoaiGD, gd.SoTien, gd.NgayGD, gd.GhiChu);
                        }
                        // Gán dữ liệu giao dịch vào dataGridViewGiaoDich
                        dataGridViewGiaoDich.DataSource = dt;
                        dataGridViewGiaoDich.Columns["Mã GD"].Width = 80;
                        dataGridViewGiaoDich.Columns["Loại GD"].Width = 100;
                        dataGridViewGiaoDich.Columns["Số Tiền"].Width = 150;
                        dataGridViewGiaoDich.Columns["Ngày Giao Dịch"].Width = 150;
                        dataGridViewGiaoDich.Columns["Ghi Chú"].Width = 150;
                    }
                    else
                    {
                        // Nếu không tìm thấy độc giả, hiển thị thông báo lỗi
                        MessageBox.Show("Không tìm thấy độc giả với mã số đã nhập.");
                        // Ẩn listBoxDocGia
                        listBoxDocGia.Visible = false;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, có vẻ bạn chưa nhập mã độc giả để thực hiện chức năng! "+ ex.Message);
            }
        }

        private void GiaoDichTaiChinh_Load(object sender, EventArgs e)
        {
            button_MoThe.Enabled = false;
        }

        private void GiaoDichTaiChinh_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
