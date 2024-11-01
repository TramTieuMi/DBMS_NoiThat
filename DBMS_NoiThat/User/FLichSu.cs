using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    public partial class FLichSu : Form
    {
        public FLichSu()
        {
            InitializeComponent();
            //LoadDanhSach(null);
        }
        SqlConnection connStr = Connection.GetSqlConnection();
        private void FLichSu_Load(object sender, EventArgs e)
        {

        }
        public bool KTTenTaiKhoan(string chuoi)
        {
            if (chuoi == FDangNhap.TenDangNhap)
            {
                return true;
            }
            return false;
        }
        public void LoadDanhSach(string chuoi)
        {
            List<LichSuMuaHang> list = new List<LichSuMuaHang>();
            try
            {
                string query = "SELECT SANPHAM.TenSanPham, SANPHAM.MoTa, SANPHAM.MauSac, SANPHAM.SoLuong, " +
               "DONHANG.NgayMuaHang, DONHANG.TrangThai " +
               "FROM DONHANG " +
               "JOIN SANPHAM ON DONHANG.MaSanPham = SANPHAM.MaSanPham";

                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                flwPnLichSu.Controls.Clear();
                int soDon = 0;

                if (chuoi == null)
                {
                    while (reader.Read())
                    {
                        if (KTTenTaiKhoan(reader["TenDangNhap"].ToString()) == true)//
                        {
                            string tenSanPham = reader["TenSanPham"].ToString();/// ten dung ko
                            string moTa = reader["MoTa"].ToString();/// ten dung ko
                            string mau = reader["MauSac"].ToString();/// ten dung ko
                            string soLuong = reader["SoLuong"].ToString();/// ten dung ko
                            string ngayMua = reader["NgayMuaHang"].ToString();/// ten dung ko
                            string trangThai = reader["TrangThai"].ToString();/// ten dung ko
                            string thanhTien = reader["TongTien"].ToString();/// ten dung ko

                            LichSuMuaHang lichsu = new LichSuMuaHang(tenSanPham, moTa, mau, soLuong, ngayMua, trangThai, thanhTien);

                            list.Add(lichsu);
                        }

                    }
                    soDon = 0;
                }
                else
                {
                    while (reader.Read())
                    {
                        if (KTTenTaiKhoan(reader["TenDangNhap"].ToString()) == true)
                        {
                            if (chuoi == reader["TenCongViec"].ToString() || chuoi == reader["Tinh_TP"].ToString())
                            {
                                string tenSanPham = reader["TenSanPham"].ToString();
                                string moTa = reader["MoTa"].ToString();                         
                                string mau = reader["MauSac"].ToString();
                                string soLuong = reader["SoLuong"].ToString();
                                string ngayMua = reader["NgayMuaHang"].ToString();
                                string trangThai = reader["TrangThai"].ToString();
                                string thanhTien = reader["TongTien"].ToString();
                                soDon = soDon + 1;
                                LichSuMuaHang lich = new LichSuMuaHang(tenSanPham, moTa, mau, soLuong, ngayMua, trangThai, thanhTien);

                                list.Add(lich);
                            }
                        }
                    }
                    soDon = 0;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                connStr.Close();
            }
            foreach (LichSuMuaHang l in list)
            {
                UCLichSuMuaHang ucLS = new UCLichSuMuaHang(l);
                int dis = (flwPnLichSu.Height - (6 * ucLS.Height)) / 10;
                ucLS.Margin = new Padding(0, dis, 0, 0);
                flwPnLichSu.Controls.Add(ucLS);
            }

        }

        private void flwPnLichSu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
