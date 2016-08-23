using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYSACH2
{
    class khachhang1
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public khachhang1 (string ma, string ten, string diachi, string sodienthoai)
        {
            MaKH = ma;
            TenKH = ten;
            DiaChi = diachi;
            SoDienThoai = sodienthoai;
        }


    }
}
