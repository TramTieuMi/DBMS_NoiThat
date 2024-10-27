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
        
        public UCLichSuMuaHang()
        {
            InitializeComponent();
        }

        LichSuMuaHang LichSuMua;
        public UCLichSuMuaHang(LichSuMuaHang LichSuMua)
        {
            this.LichSuMua = LichSuMua;
            txtTenSP.Text = LichSuMua.TenSanPham.ToString();
            txtMoTa.Text = LichSuMua.MoTa;
            txtMau.Text = LichSuMua.Mau.ToString();
            txtSoLuong.Text = LichSuMua.SoLuong.ToString();
            txtNgayMua.Text = LichSuMua.NgayMua.ToString();
            txtTrangThai.Text = LichSuMua.TrangThai.ToString();
            txtThanhTien.Text = LichSuMua.ThanhTien.ToString();
            //CK_Chon = new CheckBox();
            //CK_Chon.Checked = gioHang.Check;
        }


        private void UCLichSuDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
