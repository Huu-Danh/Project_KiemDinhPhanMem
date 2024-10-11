using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Net
{
    public class DocGia
    {
        int _MaDG;
        int _MaLDG;
        string _HoTen;
        DateTime _NgaySinh;
        string _GioiTinh;
        string _DiaChi;
        string _SDT;
        string _Email;
        float? _SoDu;
        string _Fax;

        public int MaDG { get => _MaDG; set => _MaDG = value; }
        public int MaLDG { get => _MaLDG; set => _MaLDG = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
        public float? SoDu { get => _SoDu; set => _SoDu = value; }
        public string Fax { get => _Fax; set => _Fax = value; }

        public DocGia()
        {

        }

        public DocGia(int pMaLDG, string pHoTen, DateTime pNgaySinh, string pGioiTinh, string pDiaChi, string pSDT, string pEmail, float? pSoDu, string pFax)
        {
            MaLDG = pMaLDG;
            HoTen = pHoTen;
            NgaySinh = pNgaySinh;
            GioiTinh = pGioiTinh;
            DiaChi = pDiaChi;
            SDT = pSDT;
            Email = pEmail;
            SoDu = pSoDu;
            Fax = pFax;
        }


    }
}
