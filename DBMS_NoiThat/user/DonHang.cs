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
        private DataTable dataTable1 = new DataTable();

        public DonHang()
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
        }
        int maDH,maKH = 0,ThanhTien = 0 ;
        
        public DonHang(int maDonHang)
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            LoadSanPham(maDonHang);

            LoadThanhTien(" ");
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
                    maKH = MaKhachHang;
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
            maKH = MaKhachHang;
            LB_TenNguoiDat.Text = "Tên Người Đặt : " + TenNguoiDat;
            LB_SDTNguoiDat.Text = "Số Điện Thoại Người Đặt : " + SDTNguoiDat.ToString();
            LB_SoTien.Text = "Tổng Số Tiền : " + sum.ToString();
            ThanhTien = sum;
            TB_TenNguoiNhan.Text = TenNguoiNhan;
            TB_SDTNguoiNhan.Text = SDTNguoiNhan.ToString();
            TB_DiaChi.Text = DiaChiNhan;

            using (SqlCommand command1 = new SqlCommand("GetDiscountsByCustomer", connection))
            {
                command1.CommandType = CommandType.StoredProcedure;

                // Thêm tham số MaKhachHang
                command1.Parameters.Add(new SqlParameter("@MaKhachHang", SqlDbType.Int));
                command1.Parameters["@MaKhachHang"].Value = MaKhachHang;

                // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                using (SqlDataAdapter adapter1 = new SqlDataAdapter(command1))
                {

                    adapter1.Fill(dataTable1);
                    foreach (DataRow row in dataTable1.Rows)    
                    {
                        {
                            string maGiamGia = row["MaGiamGia"].ToString();
                            int maSanPham = (int)row["MaSanPham"];
                            decimal soLuongGiam = decimal.Parse(row["SoLuongGiam"].ToString());
                            DateTime ngayApDung = (DateTime)row["NgayApDung"];
                            DateTime ngayKetThuc = (DateTime)row["NgayKetThuc"];
                            string liDo = row["LiDo"].ToString();
                            Discount discount = new Discount(maGiamGia, maSanPham, MaKhachHang, soLuongGiam, ngayApDung, ngayKetThuc, liDo);
                            UCDiscount ucgg = new UCDiscount(discount);
                            // Lắng nghe sự kiện OnApplyDiscount
                            ucgg.OnApplyDiscount += MaGiamGia =>
                            {
                                LoadThanhTien(MaGiamGia); // Gọi hàm LoadThanhTien với mã giảm giá
                            };  

                            int dis = (FPN_HienThi.Width - (2 * ucgg.Width)) / 3;
                            ucgg.Margin = new Padding(dis, dis, 0, 0);
                            FLP_Voucher.Controls.Add(ucgg);
                        }
                    }
                }
            }          
            connection.Close();
        }

        public void LoadThanhTien(string maGG)
        {
            decimal phanTramGiamGia = 0;
            if (maKH <= 0)
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!");
                return;
            }

            // Sử dụng SqlCommand để gọi hàm fn_TinhPhanTramGiamGia
            using (SqlCommand command = new SqlCommand("fn_TinhPhanTramGiamGia", connection))
            {
                command.CommandType = CommandType.StoredProcedure; // Thay CommandType.Text thành CommandType.StoredProcedure

                // Thêm tham số vào câu lệnh
                command.Parameters.AddWithValue("@MaKhachHang", maKH);  // Truyền tham số MaKhachHang
                command.Parameters.AddWithValue("@SoTien", ThanhTien);  // Truyền tham số Số Tiền
                command.Parameters.AddWithValue("@MaGiamGia", maGG);    // Truyền mã giảm giá

                // Mở kết nối
                connection.Open();

                // Thực thi hàm và lấy kết quả
                object result = command.ExecuteScalar();
                if (result != null && decimal.TryParse(result.ToString(), out decimal discountPercent))
                {
                    phanTramGiamGia = discountPercent;
                }
                connection.Close();
            }

            // Tính toán số tiền giảm và số tiền phải trả
            int SoTienGiam = Convert.ToInt32(ThanhTien * phanTramGiamGia);
            int SoTienTra = ThanhTien - SoTienGiam;

            // Hiển thị kết quả
            LB_GiamGia.Text = "Số Tiền Giảm: " + SoTienGiam.ToString();
            LB_SoTienTra.Text = "Số Tiền Phải Trả: " + SoTienTra.ToString();
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
