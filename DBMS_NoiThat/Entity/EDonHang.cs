using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_NoiThat.Entity
{
    public class EDonHang
    {
        int MaDonHang;
        int MaSanPham;
        int MaKhachHang;
        string TenNguoiDat;
        int SDTNguoiDat;
        string TenNguoiNhan;
        int SDTNguoiNhan;
        int TongTien;
        string NgayMuaHang;
        string DiaChiNhan;
        string TrangThai;

        public EDonHang(int maDonHang, int maSanPham, int maKhachHang, string tenNguoiDat, int sDTNguoiDat, string tenNguoiNhan, int sDTNguoiNhan, int tongTien, string ngayMuaHang, string diaChiNhan, string trangThai)
        {
            MaDonHang = maDonHang;
            MaSanPham = maSanPham;
            MaKhachHang = maKhachHang;
            TenNguoiDat = tenNguoiDat;
            SDTNguoiDat = sDTNguoiDat;
            TenNguoiNhan = tenNguoiNhan;
            SDTNguoiNhan = sDTNguoiNhan;
            TongTien = tongTien;
            NgayMuaHang = ngayMuaHang;
            DiaChiNhan = diaChiNhan;
            TrangThai = trangThai;
        }

        public int MaDonHang1 { get => MaDonHang; set => MaDonHang = value; }
        public int MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }
        public int MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
        public string TenNguoiDat1 { get => TenNguoiDat; set => TenNguoiDat = value; }
        public int SDTNguoiDat1 { get => SDTNguoiDat; set => SDTNguoiDat = value; }
        public string TenNguoiNhan1 { get => TenNguoiNhan; set => TenNguoiNhan = value; }
        public int SDTNguoiNhan1 { get => SDTNguoiNhan; set => SDTNguoiNhan = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }
        public string NgayMuaHang1 { get => NgayMuaHang; set => NgayMuaHang = value; }
        public string DiaChiNhan1 { get => DiaChiNhan; set => DiaChiNhan = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
    }
}
