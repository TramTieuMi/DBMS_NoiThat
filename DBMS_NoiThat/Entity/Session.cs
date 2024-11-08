using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_NoiThat.Entity
{
    public static class Session
    {
        public static int MaKhachHang { get; set; } // Chỉ lưu mã khách hàng

        // Phương thức để thiết lập giá trị của Session khi người dùng đăng nhập
        public static void InitializeSession(int maKhachHang)
        {
            MaKhachHang = maKhachHang;
        }

        // Phương thức để xóa dữ liệu của Session khi đăng xuất
        public static void ClearSession()
        {
            MaKhachHang = 0;
        }
    }


}
