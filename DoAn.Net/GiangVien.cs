using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Net
{
    public class GiangVien:DocGia
    {
        int _MaGV;
        int _MaDG;
        string _ChuyenMon;

        public int MaGV { get => _MaGV; set => _MaGV = value; }
        public int MaDG { get => _MaDG; set => _MaDG = value; }
        public string ChuyenMon { get => _ChuyenMon; set => _ChuyenMon = value; }

        public GiangVien()
        {

        }
    }
}
