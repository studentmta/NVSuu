using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace QLKho
{
    public static class GlobalVariables
    {
        public static int m_Flag = 100;

        public static SqlDateTime NgayLV
        {
            get { 
                clsPhieuXuat cls = new clsPhieuXuat();
                cls.GetDate();
                return cls.NgayLV;
            }
        }

        public enum TrangThai:int
        {
            DangLap = 0,
            TrinhDuyet = 1,
            PheDuyet = 5,
            HuyDuyet = 3,
            GhiTheKho = 6
        }
    }
}
