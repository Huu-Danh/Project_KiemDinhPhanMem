using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Net
{
    public class LoaiDocGia
    {
        int _MaLDG;
        string _TenLDG;

        public int MaLDG { get => _MaLDG; set => _MaLDG = value; }
        public string TenLDG { get => _TenLDG; set => _TenLDG = value; }
    }
}
