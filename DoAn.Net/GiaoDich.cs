using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Net
{
    public class GiaoDich
    {
        int _MaGD;
        int _MaDG;
        string _LoaiGD;
        float _SoTien;
        string _NgayGD;
        string _GhiChu;

        public int MaGD { get => _MaGD; set => _MaGD = value; }
        public int MaDG { get => _MaDG; set => _MaDG = value; }
        public string LoaiGD { get => _LoaiGD; set => _LoaiGD = value; }
        public float SoTien { get => _SoTien; set => _SoTien = value; }
        public string NgayGD { get => _NgayGD; set => _NgayGD = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }

        public GiaoDich()
        {

        }

        public GiaoDich(int maGD, string loaiGD, float soTien, string ngayGD, string ghiChu)
        {
            MaGD = maGD;
            LoaiGD = loaiGD;
            SoTien = soTien;
            NgayGD = ngayGD;
            GhiChu = ghiChu;
        }
    }
}
