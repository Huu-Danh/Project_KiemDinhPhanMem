using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using ClosedXML.Excel;
using System.Data.OleDb;
using System.Windows.Forms;
namespace DoAn.Net
{
    public class DataConnect
    {
        public SqlConnection Connect()
        {
            string str = @"Data Source=HUU-DANH\DBMS;Initial Catalog=DoAndotNet;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(str);
            return con;
        }

        // Lấy tên các loại độc giả
        public DataSet GetLoaiDocGia()
        {
            DataSet ds = new DataSet();
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetLoaiDocGia";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        // Đăng ký độc giả cán bộ
        public bool DangKyDocGia(CanBo pCanBo)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddDocGia";

            cmd.Parameters.Add(new SqlParameter("@LoaiDocGia", pCanBo.MaLDG));
            cmd.Parameters.Add(new SqlParameter("@TenDocGia", pCanBo.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", pCanBo.NgaySinh));

            int tmp = 0;
            if (pCanBo.GioiTinh == "Nam")
                tmp = 0;
            else
                tmp = 1;

            cmd.Parameters.Add(new SqlParameter("@GioiTinh", tmp));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", pCanBo.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SoDT", pCanBo.SDT));
            cmd.Parameters.Add(new SqlParameter("@Email", pCanBo.Email));
            cmd.Parameters.Add(new SqlParameter("@Fax", pCanBo.Fax));
            cmd.Parameters.Add(new SqlParameter("@BoPhan", pCanBo.BoPhan));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
            con.Close();
        }

        // Đăng ký độc giả là giảng viên
        public bool DangKyDocGia(GiangVien pGiangVien)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddDocGia";

            cmd.Parameters.Add(new SqlParameter("@LoaiDocGia", pGiangVien.MaLDG));
            cmd.Parameters.Add(new SqlParameter("@TenDocGia", pGiangVien.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", pGiangVien.NgaySinh));

            int tmp = 0;
            if (pGiangVien.GioiTinh == "Nam")
                tmp = 0;
            else
                tmp = 1;

            cmd.Parameters.Add(new SqlParameter("@GioiTinh", tmp));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", pGiangVien.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SoDT", pGiangVien.SDT));
            cmd.Parameters.Add(new SqlParameter("@Email", pGiangVien.Email));
            cmd.Parameters.Add(new SqlParameter("@Fax", pGiangVien.Fax));
            cmd.Parameters.Add(new SqlParameter("@ChuyenMon", pGiangVien.ChuyenMon));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
            con.Close();
        }

        // Đăng ký độc giả là sinh viên
        public bool DangKyDocGia(SinhVien pSinhVien)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddDocGia";

            cmd.Parameters.Add(new SqlParameter("@LoaiDocGia", pSinhVien.MaLDG));
            cmd.Parameters.Add(new SqlParameter("@TenDocGia", pSinhVien.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", pSinhVien.NgaySinh));

            int tmp = 0;
            if (pSinhVien.GioiTinh == "Nam")
                tmp = 0;
            else
                tmp = 1;

            cmd.Parameters.Add(new SqlParameter("@GioiTinh", tmp));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", pSinhVien.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SoDT", pSinhVien.SDT));
            cmd.Parameters.Add(new SqlParameter("@Email", pSinhVien.Email));
            cmd.Parameters.Add(new SqlParameter("@Fax", pSinhVien.Fax));
            cmd.Parameters.Add(new SqlParameter("@Lop", pSinhVien.Lop));
            cmd.Parameters.Add(new SqlParameter("@NamHoc", pSinhVien.NamHoc));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
            con.Close();
        }

        // Tìm kiếm độc giả 
        public DataSet FindDG(string pDK, string pDuLieu)
        {
            DataSet ds = new DataSet();
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetDocGiaByDK";

            cmd.Parameters.Add(new SqlParameter("@DK", pDK));
            cmd.Parameters.Add(new SqlParameter("@DuLieuDauVao", pDuLieu));


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;

        }

        // lấy tất cả độc giả
        public DataSet GetAllDG()
        {
            DataSet ds = new DataSet();
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllDocGia";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        // Xóa độc giả
        public bool DeleteDG(string pMaDG)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteReader";

            cmd.Parameters.Add(new SqlParameter("@MaDG", pMaDG));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
            con.Close();


        }

        // Sửa độc giả là sinh viên
        public bool UpdateSV(SinhVien pSV)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateSinhVien";

            cmd.Parameters.Add(new SqlParameter("@MaDG", pSV.MaDG));
            cmd.Parameters.Add(new SqlParameter("@Hoten", pSV.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", pSV.NgaySinh));
            int tmp = 0;
            if (pSV.GioiTinh == "Nam")
                tmp = 0;
            else
                tmp = 1;

            cmd.Parameters.Add(new SqlParameter("@GioiTinh", tmp));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", pSV.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SDT", pSV.SDT));
            cmd.Parameters.Add(new SqlParameter("@Email", pSV.Email));
            cmd.Parameters.Add(new SqlParameter("@Fax", pSV.Fax));
            cmd.Parameters.Add(new SqlParameter("@Lop", pSV.Lop));
            cmd.Parameters.Add(new SqlParameter("@NamHoc", pSV.NamHoc));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
            con.Close();
        }

        // Đăng ký thẻ độc giả
        public bool Register_The(string pMaDG)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddCard";

            cmd.Parameters.Add(new SqlParameter("@MaDG", pMaDG));

            if (cmd.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
            con.Close();
        }



        //Hiển thị thông tin độc giả dựa trên mã độc giả:
        public DocGia LayThongTinDocGia(int MaDocGia)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("FindMaDG", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDG", MaDocGia);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                bool tmp = bool.Parse(reader["GioiTinh"].ToString());
                string str = null;
                if (tmp)
                    str = "Nam";
                else
                    str = "Nữ";
                DocGia docGia = new DocGia
                {
                    MaLDG = int.Parse(reader["MaLDG"].ToString()),
                    HoTen = reader["HoTen"].ToString(),

                    NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                    GioiTinh = str,
                    DiaChi = reader["DiaChi"].ToString(),
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    SoDu = reader.IsDBNull(reader.GetOrdinal("SoDu")) ? (float?)null : (float)reader.GetDouble(reader.GetOrdinal("SoDu")),
                    Fax = reader["Fax"].ToString()
                };
                con.Close();
                return docGia;
            }
            else
            {
                con.Close();
                return null;
            }
        }
        //kiểm tra maxDG trong thẻ độc giả
        public DataSet KiemtraTheDG()
        {
            try
            {
                DataSet ds = new DataSet();
                Connect().Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connect();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetMaDocGiaFromTheDocGia";
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(ds);
                return ds;
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "Thong bao");
                return null;
            }
        }
        //Hiển thị danh sách giao dịch tài chính của độc giả dựa trên mã độc giả
        public List<GiaoDich> LayDSGiaoDich(int MaDocGia)
        {
            List<GiaoDich> danhSachGiaoDich = new List<GiaoDich>();
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("GetListGiaoDich", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDG", MaDocGia);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GiaoDich giaoDich = new GiaoDich();
                giaoDich.MaGD = int.Parse(reader["MaGD"].ToString());
                giaoDich.LoaiGD = reader["LoaiGD"].ToString();
                giaoDich.SoTien = float.Parse(reader["SoTien"].ToString());
                giaoDich.GhiChu = reader["GhiChu"].ToString();
                giaoDich.NgayGD = reader["NgayGD"].ToString();
                danhSachGiaoDich.Add(giaoDich);
            }
            con.Close();
            return danhSachGiaoDich;
        }
        //Giao dịch nạp tiền vào tài khoản
        public int TaoGiaoDich(GiaoDich pGiaoDich)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (pGiaoDich.LoaiGD == "Nạp tiền")
            {
                SqlCommand cmd = new SqlCommand("CreateGiaoDichThem", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDG", pGiaoDich.MaDG);
                cmd.Parameters.AddWithValue("@LoaiGD", pGiaoDich.LoaiGD);
                cmd.Parameters.AddWithValue("@SoTien", pGiaoDich.SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", pGiaoDich.GhiChu);
                // Thực thi câu lệnh
                int result = cmd.ExecuteNonQuery();
                // Kiểm tra kết quả
                if (result > 0)
                    return result;
                else
                    return 0;
            }
            else if (pGiaoDich.LoaiGD == "Phạt tiền" || pGiaoDich.LoaiGD == "Đền bù" || pGiaoDich.LoaiGD == "Thu phí" || pGiaoDich.LoaiGD == "Rút tiền")
            {
                SqlCommand cmd = new SqlCommand("CreateGiaoDichTru", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDG", pGiaoDich.MaDG);
                cmd.Parameters.AddWithValue("@LoaiGD", pGiaoDich.LoaiGD);
                cmd.Parameters.AddWithValue("@SoTien", pGiaoDich.SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", pGiaoDich.GhiChu);
                int result = cmd.ExecuteNonQuery();
                // Kiểm tra kết quả
                if (result > 0)
                    return result;
                else
                    return 0;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("CreateGiaoDichTru", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDG", pGiaoDich.MaDG);
                cmd.Parameters.AddWithValue("@LoaiGD", pGiaoDich.LoaiGD);
                cmd.Parameters.AddWithValue("@SoTien", pGiaoDich.SoTien);
                cmd.Parameters.AddWithValue("@GhiChu", pGiaoDich.GhiChu);
                // Thực thi câu lệnh
                int result = cmd.ExecuteNonQuery();
                result = result + MoKhoaThe(pGiaoDich.MaDG, pGiaoDich.GhiChu);
                // Kiểm tra kết quả
                if (result > 0)
                    return result;
                else
                    return 0;
            }
            con.Close();
        }
        public int MoKhoaThe(int MaDocGia, string GhiChu)
        {
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("SetUnBlockedCard", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDG", MaDocGia);
            cmd.Parameters.AddWithValue("@LyDo", GhiChu);
            // Thực thi câu lệnh
            int result = cmd.ExecuteNonQuery();
            // Kiểm tra kết quả
            if (result > 0)
                return result;
            else
                return 0;
            con.Close();
        }

        //Lấy danh sách độc giả có thẻ và thông tin thẻ
        public DataSet FindTheDG(string pDK, string pDuLieu)
        {
            DataSet ds = new DataSet();
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetDocGiaByDKAndThe";

            cmd.Parameters.Add(new SqlParameter("@DK", pDK));
            cmd.Parameters.Add(new SqlParameter("@DuLieuDauVao", pDuLieu));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }

        public List<LichSuDungThe> GetHistoryOfTheDG(int pMaThe)
        {
            List<LichSuDungThe> danhSachLsDungThe = new List<LichSuDungThe>();
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("GetLichSuThe", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaThe", pMaThe);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LichSuDungThe ls = new LichSuDungThe
                {
                    MaThe = int.Parse(reader["MaThe"].ToString()),
                    MaLSD = int.Parse(reader["MaLSD"].ToString()),
                    HoatDong = reader["HoatDong"].ToString(),
                    LyDo = reader["LyDo"].ToString(),
                    ThoiGian = DateTime.Parse(reader["ThoiGian"].ToString())
                };
                danhSachLsDungThe.Add(ls);
            }
            con.Close();
            return danhSachLsDungThe;
        }

        //Lấy danh sách thẻ 
        public DataSet GetAllDocGiaCoThe()
        {
            DataSet ds = new DataSet();
            SqlConnection con = Connect();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllTheDG";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
        //Tùng
        // Load file excel
        public DataTable AccessExcel()
        {
            try
            {
                DataTable dt = new DataTable();
                OpenFileDialog openF = new OpenFileDialog();
                openF.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                if (openF.ShowDialog() == DialogResult.OK)
                {
                    string filepath = openF.FileName;
                    string con = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties = 'Excel 8.0; HDR={1}'";
                    con = string.Format(con, filepath, "yes");
                    OleDbConnection excelconnection = new OleDbConnection(con);
                    excelconnection.Open();
                    DataTable dtexcel = excelconnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string excelsheet = dtexcel.Rows[0]["TABLE_NAME"].ToString();
                    OleDbCommand cmd = new OleDbCommand("select * from [" + excelsheet + "]", excelconnection);
                    OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
                    oda.Fill(dt);
                    excelconnection.Close();
                }
                return dt;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //Them nhieu doc gia tu excel
        public string InsertDocGia(DocGia dg)
        {
            SqlConnection conn = Connect();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pc_insert_docgia";
                cmd.Parameters.AddWithValue("@MaLDG", dg.MaLDG);
                cmd.Parameters.AddWithValue("@HoTen", dg.HoTen);

                cmd.Parameters.AddWithValue("@NgaySinh", dg.NgaySinh);

                cmd.Parameters.AddWithValue("@GioiTinh", dg.GioiTinh);

                cmd.Parameters.AddWithValue("@DiaChi", dg.DiaChi);

                cmd.Parameters.AddWithValue("@SDT", dg.SDT);
                cmd.Parameters.AddWithValue("@Email", dg.Email);
                cmd.Parameters.AddWithValue("@SoDu", dg.SoDu);
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Success!!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Export excel file
        public void ExportToExcel(DataTable dt, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Đưa dữ liệu từ DataTable vào Excel
                    worksheet.Cell(1, 1).InsertTable(dt);

                    workbook.SaveAs(filePath); // Lưu file Excel
                }
            }
            catch (SqlException ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
        //lay loai giao dich
        public DataSet GetAllLoaiGD()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con = Connect();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pc_LoaiGiaoDich";
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(ds);
                return ds;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataSet GetAllNgayGD()
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con = Connect();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pc_NgayGD";
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataSet Find_LoaiGD(GiaoDich gd)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con = Connect();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pc_Find_LoaiGD";
                cmd.Parameters.AddWithValue("@LoaiGD", gd.LoaiGD);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(ds,"GiaoDich");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public DataSet Find_NgayGD(GiaoDich gd)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con = Connect();
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pc_Find_NgayGD";
                cmd.Parameters.AddWithValue("@NgayGD", gd.NgayGD);
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(ds,"GiaoDich");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
