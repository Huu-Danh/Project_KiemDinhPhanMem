using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.Net
{
    public class LichSuDungThe
    {
        int _MaLSD;
        int _MaThe;
        string _HoatDong;
        string _LyDo;
        DateTime _ThoiGian;
        
        public int MaLSD { get => _MaLSD; set => _MaLSD = value; }
        public int MaThe { get => _MaThe; set => _MaThe = value; }
        public string HoatDong { get => _HoatDong; set => _HoatDong = value; }
        public string LyDo { get => _LyDo; set => _LyDo = value; }
        public DateTime ThoiGian { get => _ThoiGian; set => _ThoiGian = value; }

        public LichSuDungThe()
        {

        }

        public LichSuDungThe(int maThe, int maLSD, string hoatDong, string lyDo, DateTime tgian)
        {
            MaThe = maThe;
            MaLSD = maLSD;
            HoatDong = hoatDong;
            LyDo = lyDo;
            ThoiGian = tgian;
        }

    }
}
