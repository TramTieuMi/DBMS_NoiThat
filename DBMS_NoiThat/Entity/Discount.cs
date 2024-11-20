using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_NoiThat.Entity
{
    public class Discount
    {
        string MaGiamGia;
        int MaSanPham;
        int MaKhachHang;
        decimal SoLuongGiam;
        DateTime NgayApDung;
        DateTime NgayKetThuc;
        string LiDo;

        public Discount(string maGiamGia, int maSanPham, int maKhachHang, decimal soLuongGiam, DateTime ngayApDung, DateTime ngayKetThuc, string liDo)
        {
            MaGiamGia = maGiamGia;
            MaSanPham = maSanPham;
            MaKhachHang = maKhachHang;
            SoLuongGiam = soLuongGiam;
            NgayApDung = ngayApDung;
            NgayKetThuc = ngayKetThuc;
            LiDo = liDo;
        }

        public string MaGiamGia1 { get => MaGiamGia; set => MaGiamGia = value; }
        public int MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }
        public int MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
        public decimal SoLuongGiam1 { get => SoLuongGiam; set => SoLuongGiam = value; }
        public DateTime NgayApDung1 { get => NgayApDung; set => NgayApDung = value; }
        public DateTime NgayKetThuc1 { get => NgayKetThuc; set => NgayKetThuc = value; }
        public string LiDo1 { get => LiDo; set => LiDo = value; }
    }
}
