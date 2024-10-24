using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_NoiThat.Entity
{
    public class EKhachHang
    {
        int MaKhachHang;
        string HovaTen;
        string Email;
        string DiaChi;
        int SDT;
        string NgayTao;

        public EKhachHang(int maKhachHang, string hovaTen, string email, string diaChi, int sDT, string ngayTao)
        {
            MaKhachHang1 = maKhachHang;
            HovaTen1 = hovaTen;
            Email1 = email;
            DiaChi1 = diaChi;
            SDT1 = sDT;
            NgayTao1 = ngayTao;
        }

        public int MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
        public string HovaTen1 { get => HovaTen; set => HovaTen = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public string NgayTao1 { get => NgayTao; set => NgayTao = value; }
    }
}
