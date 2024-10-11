using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoAn.Net
{
    public partial class From_DangKy : Form
    {
        DataSet ds = new DataSet();
        DataConnect dataConnect = new DataConnect();
        public From_DangKy()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void From_DangKy_Load(object sender, EventArgs e)
        {
            try
            {
                rdo_Nam.Checked = true;
                ds = dataConnect.GetLoaiDocGia();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cbo_LoaiDG.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                    cbo_LoaiDG.SelectedIndex = 0;
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int getMaLDG(string pTenLDG)
        {
            if (pTenLDG == "Sinh viên")
                return 1;
            else if (pTenLDG == "Giảng viên")
                return 2;
            else if (pTenLDG == "Cán bộ")
                return 3;
            else
            {
                MessageBox.Show("Loại độc giả phải là một trong ba loại: (Giảng viên), (Sinh viên) hoặc (Cán bộ)");
                return 0;
            }
}

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try { 
            int macb = getMaLDG(cbo_LoaiDG.Text);
                if (macb == 1)
                {
                    SinhVien sinhVien = new SinhVien();
                    sinhVien.MaLDG = macb;
                    sinhVien.HoTen = txt_TenDayDu.Text;
                    string ngaysinh = dt_NgaySinh.Value.ToString("yyyy-MM-dd");
                    sinhVien.NgaySinh = DateTime.ParseExact(ngaysinh, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    if (rdo_Nam.Checked)
                        sinhVien.GioiTinh = "Nam";
                    else
                        sinhVien.GioiTinh = "Nữ";
                    sinhVien.DiaChi = txt_DiaChi.Text;
                    sinhVien.SDT = txt_SoDienThoai.Text;
                    sinhVien.Email = txt_Email.Text;
                    sinhVien.SoDu = 0;
                    sinhVien.Fax = txt_Fax.Text;
                    sinhVien.Lop = txt_Lop.Text;
                    sinhVien.NamHoc = txt_Khoa.Text;

                    bool check = dataConnect.DangKyDocGia(sinhVien); // kiểm trả chèn thành công chưa
                    if (check)
                        MessageBox.Show("Đăng ký độc giả thành công");
                    else
                        MessageBox.Show("Đăng ký độc giả thất bài");

                }
                else if (macb == 2)
                {
                    GiangVien giangVien = new GiangVien();
                    giangVien.MaLDG = macb;
                    giangVien.HoTen = txt_TenDayDu.Text;
                    string ngaysinh = dt_NgaySinh.Value.ToString("yyyy-MM-dd");
                    giangVien.NgaySinh = DateTime.ParseExact(ngaysinh, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    if (rdo_Nam.Checked)
                        giangVien.GioiTinh = "Nam";
                    else
                        giangVien.GioiTinh = "Nữ";
                    giangVien.DiaChi = txt_DiaChi.Text;
                    giangVien.SDT = txt_SoDienThoai.Text;
                    giangVien.Email = txt_Email.Text;
                    giangVien.SoDu = 0;
                    giangVien.Fax = txt_Fax.Text;
                    giangVien.ChuyenMon = txt_ChuyenMon.Text;

                    bool check = dataConnect.DangKyDocGia(giangVien);
                    if (check)
                        MessageBox.Show("Đăng ký độc giả thành công");
                    else
                        MessageBox.Show("Đăng ký độc giả thất bài");
                }
                else
                {
                    CanBo canBo = new CanBo();
                    canBo.MaLDG = macb;
                    canBo.HoTen = txt_TenDayDu.Text;

                    string ngaysinh = dt_NgaySinh.Value.ToString("yyyy-MM-dd");
                    canBo.NgaySinh = DateTime.ParseExact(ngaysinh, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    if (rdo_Nam.Checked)
                        canBo.GioiTinh = "Nam";
                    else
                        canBo.GioiTinh = "Nữ";
                    canBo.DiaChi = txt_DiaChi.Text;
                    canBo.SDT = txt_SoDienThoai.Text;
                    canBo.Email = txt_Email.Text;
                    canBo.SoDu = 0;
                    canBo.Fax = txt_Fax.Text;
                    canBo.BoPhan = txt_BoPhan.Text;

                    bool check = dataConnect.DangKyDocGia(canBo);
                    if (check)
                        MessageBox.Show("Đăng ký độc giả thành công");
                    else
                        MessageBox.Show("Đăng ký độc giả thất bài");
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_LoaiDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (cbo_LoaiDG.Text == "Sinh viên")
                {

                    txt_BoPhan.Hide();
                    txt_ChuyenMon.Hide();
                    txt_Khoa.Show();
                    txt_Lop.Show();
                }
                else if (cbo_LoaiDG.Text == "Giảng viên")
                {
                    txt_Lop.Hide();
                    txt_Khoa.Hide();
                    txt_BoPhan.Hide();
                    txt_ChuyenMon.Show();
                }
                else
                {
                    txt_Lop.Hide();
                    txt_Khoa.Hide();
                    txt_ChuyenMon.Hide();
                    txt_BoPhan.Show();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {
            try { 
            int number;
            if (int.TryParse(txt_SoDienThoai.Text, out number))
                errorSDT.Clear();
            else
                errorSDT.SetError(txt_SoDienThoai, "Số điện thoại sai");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try { 
                txt_TenDayDu.Clear();
                txt_BoPhan.Clear();
                txt_SoDienThoai.Clear();
                txt_Khoa.Clear();
                txt_Email.Clear();
                txt_Lop.Clear();
                txt_Fax.Clear();
                txt_ChuyenMon.Clear();
                txt_DiaChi.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lb_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void insertNhieuDocGia_Click(object sender, EventArgs e)
        {
            Form_NhapdocgiaEXCEL nhapNhieuDG = new Form_NhapdocgiaEXCEL();
            nhapNhieuDG.Show();
        }

        private void From_DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
