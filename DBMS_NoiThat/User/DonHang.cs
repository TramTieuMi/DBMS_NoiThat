using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
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

namespace DBMS_NoiThat
{
    public partial class DonHang : Form
    {
        static string connectionString = "ddd";
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dataTable = new DataTable();
        public DonHang()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DonHang_Load(object sender, EventArgs e)
        {

        }
        public DonHang(int maDonHang)
        {
            InitializeComponent();
            LoadSanPham(maDonHang);

        }
        public void LoadSanPham(int maDonHang)
        {
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
            foreach (DataRow row in dataTable.Rows) // Lặp qua từng hàng trong DataTable
            {
                if ( (maDonHang == (int)row["MaDonHang"] ) && ( row["TrangThai"].ToString() == "Đặt Hàng") )
                {
                    int MaSanPham = (int)row["MaSanPham"];
                    MaKhachHang = (int)row["MaKhachHang"];
                    TenNguoiDat = row["TenNguoiDat"].ToString();
                    SDTNguoiDat = (int)row["SDTNguoiDat"];
                    TenNguoiNhan = row["TenNguoiNhan"].ToString();
                    SDTNguoiNhan = (int)row["SDTNguoiNhan"];
                    int SoTien = (int)row["SoTien"];
                    NgayMuaHang = row["NgayMuaHang"].ToString();
                    DiaChiNhan = row["DiaChiNhan"].ToString();
                    string TrangThai = row["TrangThai"].ToString();
                    int SoLuong = (int)row["TrangThai"];
                    string TenSanPham = row["TrangThai"].ToString();
                    sum = sum + SoTien;
                    EDonHang donHang = new EDonHang(maDonHang, MaSanPham, MaKhachHang, TenNguoiDat, SDTNguoiDat, TenNguoiNhan, SDTNguoiNhan, SoTien, NgayMuaHang, DiaChiNhan, TrangThai, SoLuong, TenSanPham);

                    UCDonHang ucdh = new UCDonHang(donHang);
                    int dis = (FPN_HienThi.Width - (2 * ucdh.Width)) / 3;
                    ucdh.Margin = new Padding(dis, dis, 0, 0);
                    FPN_HienThi.Controls.Add(ucdh);
                }

            }         
            LB_MaDonHang.Text = maDonHang.ToString();
            LB_MaKH.Text = MaKhachHang.ToString();
            LB_TenNguoiDat.Text = TenNguoiDat;
            LB_SDTNguoiDat.Text = SDTNguoiDat.ToString();
            LB_SoTien.Text = sum.ToString();
            TB_TenNguoiNhan.Text = TenNguoiNhan;
            TB_SDTNguoiNhan.Text = SDTNguoiNhan.ToString();
            TB_DiaChi.Text = DiaChiNhan;
        }
        

        private void BTN_MuaHang_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE DONHANG SET " +
                               "TenNguoiNhan = @TenNguoiNhan, " +
                               "SDTNguoiNhan = @SDTNguoiNhan, " +
                               "NgayMuaHang = @NgayMuaHang, " +
                               "DiaChiNhan = @DiaChiNhan, " +
                               "TrangThai = @TrangThai " +
                               "WHERE MaDonHang = @MaDonHang"; // Điều kiện để cập nhật

                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số vào câu lệnh
                    command.Parameters.AddWithValue("@TenNguoiNhan", TB_TenNguoiNhan.Text);
                    command.Parameters.AddWithValue("@SDTNguoiNhan", TB_SDTNguoiNhan.Text);
                    command.Parameters.AddWithValue("@NgayMuaHang", DateTime.Now);
                    command.Parameters.AddWithValue("@DiaChiNhan", TB_DiaChi.Text);
                    command.Parameters.AddWithValue("@TrangThai", "Đang Xác Nhận");
                    command.Parameters.AddWithValue("@MaDonHang", Convert.ToInt32(LB_MaDonHang)); // Tham số cho mã đơn hàng

                    // Thực thi câu lệnh
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
