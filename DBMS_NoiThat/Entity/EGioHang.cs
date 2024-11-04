using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_NoiThat.Entity
{
    public class EGioHang
    {
        int MaGioHang;
        int MaSanPham;
        int SoLuong;
        int SoTien;
        string TenSanPham;
        bool check;
      

        public EGioHang()
        {
        }

        public EGioHang(int maGioHang, int maSanPham, int soLuong, int soTien, string tenSanPham, bool check)
        {
            MaGioHang = maGioHang;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            SoTien = soTien;
            TenSanPham = tenSanPham;
            this.check = check;
        }

        public int MaGioHang1 { get => MaGioHang; set => MaGioHang = value; }
        public int MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int SoTien1 { get => SoTien; set => SoTien = value; }
        public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }
        public bool Check { get => check; set => check = value; }
    }
}
