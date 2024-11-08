using DBMS_NoiThat.Entity;
using DBMS_NoiThat.user;
using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat.UC
{
    public partial class UCLichSuMuaHang : UserControl
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        string tensp;
        string mota;
        string soluong;
        string mau;
        string trangthai;
        string ngaymua;
        string tongtien;
        public UCLichSuMuaHang()
        {
            InitializeComponent();
        }

        LichSuMuaHang LichSuMua;
        public UCLichSuMuaHang(LichSuMuaHang LichSuMua)
        {
            InitializeComponent();
            this.LichSuMua = LichSuMua;
            // nganh = lichSuNTD.Nganh;

            txtTenSP.Text = LichSuMua.TenSanPham.ToString();

            txtMoTa.Text = $"Mô tả: {LichSuMua.MoTa.ToString()}";

            txtMau.Text = "Màu sắc: " + LichSuMua.Mau.ToString();

            txtSoLuong.Text = "Số lượng: "+LichSuMua.SoLuong.ToString();

            txtNgayMua.Text = "Ngày mua hàng: " + LichSuMua.NgayMua.ToString();

            txtTrangThai.Text = "Trạng thái: " + LichSuMua.TrangThai.ToString();

          //  txtThanhTien.Text = "Tổng tiền " + LichSuMua.ThanhTien.ToString();
            //CK_Chon = new CheckBox();
            //CK_Chon.Checked = gioHang.Check;
        }


        private void UCLichSuDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
