using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_NoiThat.Entity
{
    public class ESanPham
    {
        int MaSanPham;
        string TenSanPham;
        string HinhAnh;
        int GiaSanPham;
        string ChatLieu;
        string MoTa;
        string KichThuoc;
        string MauSac;
        int SoLuong;

        public ESanPham(int maSanPham, string tenSanPham, string hinhAnh, int giaSanPham, string chatLieu, string moTa, string kichThuoc, string mauSac, int soLuong)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            HinhAnh = hinhAnh;
            GiaSanPham = giaSanPham;
            ChatLieu = chatLieu;
            MoTa = moTa;
            KichThuoc = kichThuoc;
            MauSac = mauSac;
            SoLuong = soLuong;
        }

        public int MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }
        public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }
        public string HinhAnh1 { get => HinhAnh; set => HinhAnh = value; }
        public int GiaSanPham1 { get => GiaSanPham; set => GiaSanPham = value; }
        public string ChatLieu1 { get => ChatLieu; set => ChatLieu = value; }
        public string MoTa1 { get => MoTa; set => MoTa = value; }
        public string KichThuoc1 { get => KichThuoc; set => KichThuoc = value; }
        public string MauSac1 { get => MauSac; set => MauSac = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    }
}
