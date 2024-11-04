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
        private int maKhachHang; // Mã khách hàng

        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection;

        List<LichSuMuaHang> lstLichSu = new List<LichSuMuaHang>();
        int maKH; /// <summary>
                  /// /////////////////////////////////////////////////////////////////////////////
                  /// </summary>

        private string tenDangNhap;
        public FLichSu()
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
        }
        public FLichSu(int maKhachHang)
        {
            InitializeComponent();
            this.maKhachHang = maKhachHang;
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            LoadLichSu(maKhachHang);
            maKH = maKhachHang;
        }

        //SqlConnection connStr = Connection.GetSqlConnection();
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
        //public void LoadSanPham(int maDonHang)
        //{
        //    string query = "SELECT * FROM View_DonHangChiTiet";
        //    DataTable dataTable = new DataTable();
        //    connection.Open();
        //    SqlCommand command = new SqlCommand(query, connection);
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    adapter.Fill(dataTable);

        //    int sum = 0;
        //    int MaKhachHang = 0;
        //    string TenSanPham= "";
        //    string MoTa = "";
        //    string Mau = "";
        //    int SoLuong = 0;
        //    DateTime NgayMua = ;
        //    string TrangThai = "";

        //    foreach (DataRow row in dataTable.Rows) // Loop through each row in DataTable
        //    {
        //        if ((maDonHang == (int)row["MaDonHang"]) && (row["TrangThai"].ToString() == "Đặt Hàng"))
        //        {
        //            int MaSanPham = (int)row["MaSanPham"];
        //            MaKhachHang = (int)row["MaKhachHang"];

        //            TenSanPham = row["TenSanPham"].ToString();
        //            MoTa = row["MoTa"].ToString();
        //            Mau = row["Mau"].ToString();
        //            SoLuong = Convert.ToInt32(row["SDTNguoiNhan"].ToString());
        //           // NgayMua = row["NgayMuaHang"].ToString();
        //            TrangThai = row["TrangThai"].ToString();

        //            int SoTien = (int)row["SoTien"];
        //            sum += SoTien; // Sum the total amount
        //            LichSuMuaHang lichsu = new LichSuMuaHang(TenSanPham, MoTa, Mau, SoLuong, NgayMua, TrangThai);

        //            UCLichSuMuaHang ucls = new UCLichSuMuaHang(lichsu);
        //            int dis = (flwPnLichSu.Width - (2 * ucls.Width)) / 3;
        //            ucls.Margin = new Padding(dis, dis, 0, 0);
        //            flwPnLichSu.Controls.Add(ucls);
        //        }
        //    }

        //// Set the values in the labels and text boxes
        //LB_MaDonHang.Text = maDonHang.ToString();
        //LB_MaKH.Text = MaKhachHang.ToString();
        //LB_TenNguoiDat.Text = TenNguoiDat;
        //LB_SDTNguoiDat.Text = SDTNguoiDat.ToString();
        //LB_SoTien.Text = sum.ToString();
        //TB_TenNguoiNhan.Text = TenNguoiNhan;
        //TB_SDTNguoiNhan.Text = SDTNguoiNhan.ToString();
        //TB_DiaChi.Text = DiaChiNhan;

        //    connection.Close(); // Close the connection
        //}
        public void LoadLichSu(int maKhachHang)
        {
            List<LichSuMuaHang> listLichSu = new List<LichSuMuaHang>();
            string query = "select * from view_ChiTietLichSuMuaHang";


            DataTable dataTable = new DataTable();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);


            int sum = 0;
            int MaKhachHang = 0;
            string TenNguoiDat = "";
            int SDTNguoiDat = 0;
            string TenNguoiNhan = "";
            int SDTNguoiNhan = 0;
            string NgayMuaHang = "";
            string DiaChiNhan = "";
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows) // Loop through each row in DataTable
                {

                    if (maKhachHang == (int)row["MaKhachHang"])
                    {

                        string TenSanPham1 = (string)row["TenSanPham"];
                        string MoTa1 = (string)row["MoTa"];
                        string MauSac1 = (string)row["MauSac"];
                        int SoLuong1 = (int)row["SoLuong"];
                        DateTime NgayMua1 = (DateTime)row["NgayMuaHang"];
                        string TrangThai1 = (string)row["TrangThai"];
                        //int SoTien1 = (int)row["SoTien"];


                        LichSuMuaHang gioHang = new LichSuMuaHang(TenSanPham1, MoTa1, MauSac1, SoLuong1, NgayMua1, TrangThai1);
                        listLichSu.Add(gioHang);
                        UCLichSuMuaHang ucgh = new UCLichSuMuaHang(gioHang);
                        int dis = (flwPnLichSu.Width - (2 * ucgh.Width)) / 3;
                        ucgh.Margin = new Padding(dis, dis, 0, 0);
                        flwPnLichSu.Controls.Add(ucgh);
                    }
                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu trong giỏ hàng.");
            }
            connection.Close();
        }

        private void flwPnLichSu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flwPnLichSu_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
  
}
