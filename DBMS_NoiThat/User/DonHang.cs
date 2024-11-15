using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DBMS_NoiThat.user;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DBMS_NoiThat
{
    public partial class DonHang : Form
    {
        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection; // Declare the SqlConnection variable
        private DataTable dataTable = new DataTable();

        public DonHang()
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
        }
        int maDH ;
        public DonHang(int maDonHang)
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            LoadSanPham(maDonHang);
            maDH = maDonHang;   
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            // Initialization code here
        }

        public void LoadSanPham(int maDonHang)
        {
            LB_TieuDe.Text = "Đơn Hàng Của Bạn";
            LB_TTNguoiDat.Text = "Thông Tin Người Đặt Hàng";
            LB_TTNguoiNhan.Text = "Thông Tin Người Nhận Hàng";
            LB_TNguoiNhan.Text = "Tên Người Nhận :";
            LB_SDTNhan.Text = "Số Điện Thoại Người Nhận :";
            LB_DiaChi.Text = "Địa Chỉ Nhận Hàng :";
            string query = "SELECT * FROM View_DonHangChiTiet";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            int sum = 0;
            int MaKhachHang = 0;
            string TenNguoiDat = "";
            int SDTNguoiDat = 0;
            string TenNguoiNhan = "";
            int SDTNguoiNhan = 0;
            string NgayMuaHang = "";
            string DiaChiNhan = "";
            foreach (DataRow row in dataTable.Rows)
            {
                if ((maDonHang == (int)row["MaDonHang"]) && (row["TrangThai"].ToString() == "Ðang chờ xác nhận"))
                {
                    int MaSanPham = (int)row["MaSanPham"];
                    MaKhachHang = (int)row["MaKhachHang"];
                    TenNguoiDat = row["TenNguoiDat"].ToString();
                    SDTNguoiDat = Convert.ToInt32(row["SDTNguoiDat"].ToString());
                    TenNguoiNhan = row["TenNguoiNhan"].ToString();
                    SDTNguoiNhan = Convert.ToInt32(row["SDTNguoiNhan"].ToString());
                    int SoTien = (int)row["SoTien"];
                    NgayMuaHang = row["NgayMuaHang"].ToString();
                    DiaChiNhan = row["DiaChiNhan"].ToString();
                    string TrangThai = row["TrangThai"].ToString();
                    int SoLuong = (int)row["SoLuong"];
                    string TenSanPham = row["TenSanPham"].ToString();
                    byte[] pic = (byte[])row["HinhAnh"];
                    sum += SoTien;
                    EDonHang donHang = new EDonHang(maDonHang, MaSanPham, MaKhachHang, TenNguoiDat, SDTNguoiDat, TenNguoiNhan, SDTNguoiNhan, SoTien, NgayMuaHang, DiaChiNhan, TrangThai, SoLuong, TenSanPham, pic);
                    UCDonHang ucdh = new UCDonHang(donHang);
                    int dis = (FPN_HienThi.Width - (2 * ucdh.Width)) / 3;
                    ucdh.Margin = new Padding(dis, dis, 0, 0);
                    FPN_HienThi.Controls.Add(ucdh);
                }
            }
            LB_MaDonHang.Text = "Mã Đơn Hàng : " + maDonHang.ToString();
            LB_MaKH.Text = "Mã Khách Hàng : " + MaKhachHang.ToString();
            LB_TenNguoiDat.Text = "Tên Người Đặt : " + TenNguoiDat;
            LB_SDTNguoiDat.Text = "Số Điện Thoại Người Đặt : " + SDTNguoiDat.ToString();
            LB_SoTien.Text = "Tổng Số Tiền : " + sum.ToString();
            TB_TenNguoiNhan.Text = TenNguoiNhan;
            TB_SDTNguoiNhan.Text = SDTNguoiNhan.ToString();
            TB_DiaChi.Text = DiaChiNhan;
            connection.Close();
        }



        private void BTN_MuaHang_Click(object sender, EventArgs e)
        {
            string query = "sp_CapNhatDonHang"; // Condition for updating

            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure; // Đặt loại lệnh là StoredProcedure
                // Add parameters to the command
                command.Parameters.AddWithValue("@TenNguoiNhan", TB_TenNguoiNhan.Text);
                command.Parameters.AddWithValue("@SDTNguoiNhan", TB_SDTNguoiNhan.Text);
                command.Parameters.AddWithValue("@NgayMuaHang", DateTime.Now);
                command.Parameters.AddWithValue("@DiaChiNhan", TB_DiaChi.Text);
                command.Parameters.AddWithValue("@TrangThai", "Đang Xác Nhận");
                
                command.Parameters.AddWithValue("@MaDonHang", maDH); // Pass the order ID

                // Execute the command
                command.ExecuteNonQuery();
            }
            connection.Close();
            this.Close();
        }

        private void TB_TenNguoiNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_SDTNguoiNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_DiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void FPN_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
