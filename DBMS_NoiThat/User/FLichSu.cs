using DBMS_NoiThat.Entity;
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
                string query = "SELECT TenCongViec,Tinh_TP,TenTaiKhoan,TenCTy FROM DangBaiNTD " +//////////////////////////
                    "JOIN ThongTinCTy_Chinh on DangBaiNTD.EmailHR = ThongTinCTy_Chinh.EmailHR " +////////////
                    "JOIN TaoTaiKhoan on TaoTaiKhoan.Email = ThongTinCTy_Chinh.EmailHR";////
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();
                flwPnLichSu.Controls.Clear();
                int soNguoi = 0;

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
                    soNguoi = 0;
                }
                else
                {
                    while (reader.Read())
                    {
                        if (KTTenCTy(reader["TenTaiKhoan"].ToString()) == true)
                        {
                            if (chuoi == reader["TenCongViec"].ToString() || chuoi == reader["Tinh_TP"].ToString())
                            {
                                string nganh = reader["TenCongViec"].ToString();
                                string tenCTy = reader["TenCTy"].ToString();
                                string diaDiem = reader["Tinh_TP"].ToString();
                                soNguoi = soNguoi + 1;
                                LichSuNTD lich = new LichSuNTD(nganh, diaDiem, tenCTy, soNguoi);

                                list.Add(lich);
                            }
                        }
                    }
                    soNguoi = 0;
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
            foreach (LichSuNTD l in list)
            {
                UCLichSuNTD ucLS = new UCLichSuNTD(l);
                int dis = (fpn_HienThi.Height - (6 * ucLS.Height)) / 10;
                ucLS.Margin = new Padding(0, dis, 0, 0);
                fpn_HienThi.Controls.Add(ucLS);
            }

        }
    }
}
