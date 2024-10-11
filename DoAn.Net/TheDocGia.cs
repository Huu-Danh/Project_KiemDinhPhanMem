using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Net
{
    public class TheDocGia
    {
        int _MaThe;
        int _MaDG;
        string _TrangThai;
        DateTime _NgayDangKy;
        DateTime _NgayHetHan;

        public int MaThe { get => _MaThe; set => _MaThe = value; }
        public int MaDG { get => _MaDG; set => _MaDG = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
        public DateTime NgayDangKy { get => _NgayDangKy; set => _NgayDangKy = value; }
        public DateTime NgayHetHan { get => _NgayHetHan; set => _NgayHetHan = value; }

        public TheDocGia()
        {

        }
    }
}
