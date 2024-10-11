using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Net
{
    public class SinhVien: DocGia
    {
        int _MaSV;
        int _MaDG;
        string _Lop;
        string _NamHoc;

        public int MaSV { get => _MaSV; set => _MaSV = value; }
        public int MaDG1 { get => _MaDG; set => _MaDG = value; }
        public string Lop { get => _Lop; set => _Lop = value; }
        public string NamHoc { get => _NamHoc; set => _NamHoc = value; }

        public SinhVien()
        {

        }
    }
}
