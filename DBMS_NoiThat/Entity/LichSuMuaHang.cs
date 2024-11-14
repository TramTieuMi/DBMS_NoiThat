using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_NoiThat.Entity
{
    public class LichSuMuaHang
    {
        string tenSanPham;
        string moTa;
        string mau;
        int soLuong;
        DateTime ngayMua;
        string trangThai;
        //int thanhTien;

        public LichSuMuaHang()
        {
        }
        public LichSuMuaHang(string tenSanPham, string moTa, string mau, int soLuong, DateTime ngayMua, string trangThai)
        {
            this.tenSanPham = tenSanPham;
            this.moTa = moTa;
            this.mau = mau;
            this.soLuong = soLuong;
            this.ngayMua = ngayMua;
            this.trangThai = trangThai;
            //this.thanhTien = thanhTien;
        }

        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string Mau { get => mau; set => mau = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayMua { get => ngayMua; set => ngayMua = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        //public int ThanhTien { get => thanhTien; set => thanhTien = value; }


        // Giả sử bạn có một danh sách các sản phẩm
        public List<LichSuMuaHang> DanhSachSanPham { get; set; }
    }
}
