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
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace DBMS_NoiThat.admin
{
    public partial class FNhacNho : Form
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        public FNhacNho()
        {
            InitializeComponent();
            LoadMessages();
        }

        private void FNhacNho_Load(object sender, EventArgs e)
        {
            LoadMessages();
        }
        private void LoadMessages()
        {
            // string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=YOUR_DATABASE;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connStr.ConnectionString))
            {
                connection.Open();

                // Lấy danh sách sản phẩm gần hết hàng
                //string querySanPham = "SELECT MaSanPham, TenSanPham, TonKho FROM vw_SanPhamSapHetHang";
                //using (SqlCommand cmdSanPham = new SqlCommand(querySanPham, connection))
                //{
                //    try
                //    {
                //        using (SqlDataReader readerSanPham = cmdSanPham.ExecuteReader())
                //        {
                //            while (readerSanPham.Read())
                //            {
                //                string maSanPham = readerSanPham["MaSanPham"].ToString();
                //                string tenSanPham = readerSanPham["TenSanPham"].ToString();
                //                int tonKho = Convert.ToInt32(readerSanPham["TonKho"]);

                //                string message = $"Sản phẩm {maSanPham} - {tenSanPham} hiện đang gần hết hàng, chỉ còn {tonKho} trong kho.";
                //                AddMessageToUI(message);
                //            }
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        // Xử lý lỗi nếu có (ví dụ: log lỗi)
                //        AddMessageToUI($"Lỗi khi truy xuất dữ liệu: {ex.Message}");
                //    }
                //}
                //Lấy danh sách đơn hàng chưa giao
                string queryDonHang = "SELECT MaDonHang, TenNguoiDat, MaKhachHang, NgayMuaHang, TrangThai FROM vw_DonHangCanXacNhan";
                using (SqlCommand cmdDonHang = new SqlCommand(queryDonHang, connection))
                {
                    try
                    {
                        using (SqlDataReader readerDonHang = cmdDonHang.ExecuteReader())
                        {
                            while (readerDonHang.Read())
                            {
                                string maDonHang = readerDonHang["MaDonHang"].ToString();
                                string tenNguoiDat = readerDonHang["TenNguoiDat"].ToString();
                                string maKhachHang = readerDonHang["MaKhachHang"].ToString();
                                string NgayMua = readerDonHang["NgayMuaHang"].ToString();
                                // Chuyển đổi NgayMuaHang từ string thành DateTime
                                DateTime ngayMua = Convert.ToDateTime(readerDonHang["NgayMuaHang"]);
                                string TrangThai = readerDonHang["TrangThai"].ToString();
                                TrangThai = TrangThai.Trim();

                                // Tính số ngày đã trôi qua từ ngày mua hàng
                                int soNgayDaTron = (DateTime.Now - ngayMua).Days;
                                string message = $"Đơn hàng số {maDonHang} của khách hàng {tenNguoiDat} đã hơn {soNgayDaTron} ngày  ";
                                message += $" vẫn ở trạng thái '{TrangThai}'";
                                //if (TrangThai.ToLower() == "đang chờ xác nhận")
                                //{
                                //    message += " và trạng thái là 'Đang chờ xác nhận'.";
                                //}
                                //else if (TrangThai.ToLower() == "đã xác nhận")
                                //{
                                //    message += " và trạng thái là 'Đã xác nhận'.";
                                //}
                                //else
                                //{
                                //    message += $" và trạng thái không xác định. (TrangThai: '{TrangThai}')";
                                //}


                                // Hiển thị thông báo trên UI
                                AddMessageToUI(message);
                                

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu có (ví dụ: log lỗi)
                        AddMessageToUI($"Lỗi khi truy xuất dữ liệu đơn hàng: {ex.Message}");
                    }
                }
                //// Lấy danh sách đơn hàng chưa giao
                //string queryDonHang = "SELECT MaDonHang, TenKhachHang FROM vw_DonHangChuaGiao";
                //SqlCommand cmdDonHang = new SqlCommand(queryDonHang, conn);
                //SqlDataReader readerDonHang = cmdDonHang.ExecuteReader();

                //while (readerDonHang.Read())
                //{
                //    string maDonHang = readerDonHang["MaDonHang"].ToString();
                //    string tenKhachHang = readerDonHang["TenKhachHang"].ToString();

                //    string message = $"Đơn hàng {maDonHang} của khách hàng {tenKhachHang} chưa được giao.";
                //    AddMessageToUI(message);
                //}
                //readerDonHang.Close();
            }

        }

        private void AddMessageToUI(string message)
        {
            // Tạo một instance của UCNhacNho
            UCNhacNho nhacNhoUC = new UCNhacNho();

            // Gán nội dung thông báo
            nhacNhoUC.SetMessage(message);

            // Thêm vào giao diện (Panel hoặc FlowLayoutPanel)
            flowLayoutPanel1.Controls.Add(nhacNhoUC); // flowLayoutPanel1 là nơi chứa các UserControl
        }
    }
}
