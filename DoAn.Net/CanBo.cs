using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Net
{
    public class CanBo: DocGia
    {
        int _MaCB;
        int _MaDG;
        string _BoPhan;

        public int MaCB { get => _MaCB; set => _MaCB = value; }
        public int MaDG1 { get => _MaDG; set => _MaDG = value; }
        public string BoPhan { get => _BoPhan; set => _BoPhan = value; }

        public CanBo()
        {

        }

        public CanBo(int pMaLDG, string pHoTen, DateTime pNgaySinh, string pGioiTinh, string pDiaChi, string pSDT, string pEmail, float? pSoDu, string pFax, string pBoPhan):base(pMaLDG, pHoTen, pNgaySinh, pGioiTinh, pDiaChi, pSDT, pEmail, pSoDu, pFax)
        {
            BoPhan = pBoPhan;
        }
    }
}
