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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DBMS_NoiThat.user
{
    public partial class FLichSu : Form

    {
        private int maKhachHang; // Mã khách hàng

        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection;

        List<LichSuMuaHang> lstLichSu = new List<LichSuMuaHang>();
        int maKH; 

        private string tenTaiKhoan;
        public FLichSu()
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            //string em = KiemEmail();
            //LoadLichSu(null, em);
        }
        public FLichSu(string tenTaiKhoan)
        {
            InitializeComponent();
            //this.tenDangNhap = tenDangNhap;
            this.tenTaiKhoan = tenTaiKhoan;
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            LoadLichSu(tenTaiKhoan);
            maKH = maKhachHang;
        }

        //SqlConnection connStr = Connection.GetSqlConnection();
        private void FLichSu_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            string em = KiemEmail();
            nm.Text = $"Welcome {tenTaiKhoan} to our website";
            //  LoadLichSu(maKhachHang);
        }
        public bool KTTenTaiKhoan(string chuoi)
        {
            if (chuoi == FDangNhap.TenDangNhap)
            {
                return true;
            }
            return false;
        }
        public string KiemEmail()
        {
            string em = string.Empty;
            string query = "SELECT TenDangNhap,Email FROM TAIKHOAN";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["TenDangNhap"].ToString() == FDangNhap.TenDangNhap)
                {
                    em = reader["Email"].ToString();
                    break;
                }
            }
            connection.Close();
            return em;
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
        public void LoadLichSu(string tenDangNhap)
        {
            List<LichSuMuaHang> listLichSu = new List<LichSuMuaHang>();
            string query = "select * from view_ChiTietLichSuMuaHang WHERE TenDangNhap = @TenDangNhap";


            DataTable dataTable = new DataTable();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TenDangNhap", tenTaiKhoan); // Truyền mã khách hàng vào truy vấn
            SqlDataAdapter adapter = new SqlDataAdapter(command);


            adapter.Fill(dataTable);
            flwPnLichSu.Controls.Clear();

            if (dataTable.Rows.Count > 0)
            {
                //object previousOrderID = null;
                decimal totalOrderPrice = 0; // Biến để lưu tổng giá trị của đơn hàng
                // Biến để lưu mã đơn hàng trước đó
                object previousOrderID = null;

                foreach (DataRow row in dataTable.Rows)
                {
                    // Giả sử cột OrderID đại diện cho mã đơn hàng
                    object currentOrderID = row["MaDonHang"];////////////////////////////

                    // Khi gặp đơn hàng mới, tạo một UserControl mới để hiển thị nhóm sản phẩm
                    if (previousOrderID == null || !currentOrderID.Equals(previousOrderID))
                    {
                        // Nếu không phải đơn hàng đầu tiên, cập nhật giá trị cho đơn hàng trước đó
                        if (previousOrderID != null)
                        {
                            // Thêm tổng giá trị của đơn hàng vào `UserControl`
                            UCLichSuMuaHang lastUcOrderGroup = (UCLichSuMuaHang)flwPnLichSu.Controls[flwPnLichSu.Controls.Count - 1];
                            lastUcOrderGroup.SetTotalOrderPrice(totalOrderPrice);
                        }
                        UCLichSuMuaHang ucOrderGroup1 = new UCLichSuMuaHang(); // UC đại diện cho một đơn hàng
                        ucOrderGroup1.SetOrderInfo(currentOrderID, (DateTime)row["NgayMuaHang"], (string)row["TrangThai"]);
                        flwPnLichSu.Controls.Add(ucOrderGroup1);

                        // Cập nhật mã đơn hàng trước đó
                        previousOrderID = currentOrderID;
                        totalOrderPrice = 0; // Đặt lại tổng giá trị cho đơn hàng mới

                    }

                    // Tạo chi tiết sản phẩm và thêm vào nhóm đơn hàng hiện tại
                    string TenSanPham = (string)row["TenSanPham"];
                    string MoTa = (string)row["MoTa"];
                    string MauSac = (string)row["MauSac"];
                    int SoLuong = (int)row["SoLuong"];
                    DateTime NgayMua = (DateTime)row["NgayMuaHang"];
                    string TrangThai = (string)row["TrangThai"];
                    decimal GiaSanPham = (decimal)row["GiaSanPham"]; // Giá sản phẩm

                    // Tính giá trị của sản phẩm và cộng vào tổng giá trị đơn hàng
                    totalOrderPrice += SoLuong * GiaSanPham;
                    // Tạo đối tượng sản phẩm từ các trường dữ liệu
                    LichSuMuaHang product = new LichSuMuaHang(TenSanPham, MoTa, MauSac, SoLuong, NgayMua, TrangThai);


                    // Lấy tham chiếu đến UserControl cuối cùng vừa thêm vào FlowLayoutPanel
                    UCLichSuMuaHang ucOrderGroup = (UCLichSuMuaHang)flwPnLichSu.Controls[flwPnLichSu.Controls.Count - 1];

                    // Đưa UC vừa thêm lên trên cùng
                    flwPnLichSu.Controls.SetChildIndex(ucOrderGroup, 0);

                    // Thêm sản phẩm vào nhóm đơn hàng hiện tại
                    ucOrderGroup.AddProduct(product); // Phương thức này sẽ thêm sản phẩm vào flwPnLichSu trong ucLichSuMuaHang1
                }

                // Cập nhật tổng giá trị cho đơn hàng cuối cùng
                if (previousOrderID != null)
                {
                    UCLichSuMuaHang lastUcOrderGroup = (UCLichSuMuaHang)flwPnLichSu.Controls[flwPnLichSu.Controls.Count - 1];
                    lastUcOrderGroup.SetTotalOrderPrice(totalOrderPrice);
                }

            }
            else
            {
                Console.WriteLine("Không có dữ liệu trong lịch sử mua hàng.");
            }
            connection.Close();
        }

        private void flwPnLichSu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flwPnLichSu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ucLichSuMuaHang1_Load(object sender, EventArgs e)
        {

        }

        private void ucLichSuMuaHang1_Load_1(object sender, EventArgs e)
        {

        }
    }
  
}

// code chính //////////////////////////////////////////////



//------------- Theo do an cu 
//List<LichSuMuaHang> listLichSu = new List<LichSuMuaHang>();
//try
//{

//    string query = "select * from view_ChiTietLichSuMuaHang";
//    SqlCommand command = new SqlCommand(query, connection);
//    connection.Open();
//    SqlDataReader reader = command.ExecuteReader();
//    flwPnLichSu.Controls.Clear();

//    // DataTable dataTable = new DataTable();

//    if (chuoi == null)
//    {

//        while (reader.Read())
//        {
//            if (email == reader["Email"].ToString())
//            {
//                string TenSanPham1 = reader["TenSanPham"].ToString();
//                string MoTa1 = reader["MoTa"].ToString();
//                string MauSac1 = reader["MauSac"].ToString();
//                int SoLuong1 = Convert.ToInt32(reader["SoLuong"]); // Chuyển đổi thành int
//                DateTime NgayMua1 = Convert.ToDateTime(reader["NgayMuaHang"]); // Chuyển đổi thành DateTime
//                string TrangThai1 = reader["TrangThai"].ToString();

//                LichSuMuaHang gioHang = new LichSuMuaHang(TenSanPham1, MoTa1, MauSac1, SoLuong1, NgayMua1, TrangThai1);
//                listLichSu.Add(gioHang);
//            }
//        }
//    }
//    else
//    {
//        while (reader.Read())
//        {
//            if (chuoi == reader["TenSanPham"].ToString() || chuoi == reader["Mau"].ToString() || chuoi == reader["SoLuong"].ToString())
//            {
//                if (email == reader["Email"].ToString())
//                {
//                    string TenSanPham1 = reader["TenSanPham"].ToString();
//                    string MoTa1 = reader["MoTa"].ToString();
//                    string MauSac1 = reader["MauSac"].ToString();
//                    int SoLuong1 = Convert.ToInt32(reader["SoLuong"]); // Chuyển đổi thành int
//                    DateTime NgayMua1 = Convert.ToDateTime(reader["NgayMuaHang"]); // Chuyển đổi thành DateTime
//                    string TrangThai1 = reader["TrangThai"].ToString();

//                    LichSuMuaHang gioHang = new LichSuMuaHang(TenSanPham1, MoTa1, MauSac1, SoLuong1, NgayMua1, TrangThai1);
//                    listLichSu.Add(gioHang);
//                }
//            }
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Lỗi truy vấn: " + ex.Message);
//}
//finally
//{
//    connection.Close();
//}
//foreach (LichSuMuaHang l in listLichSu)
//{
//    //listLichSu.Add(gioHang);
//    UCLichSuMuaHang ucgh = new UCLichSuMuaHang(l);
//    int dis = (flwPnLichSu.Width - (2 * ucgh.Width)) / 3;
//    ucgh.Margin = new Padding(dis, dis, 0, 0);
//    flwPnLichSu.Controls.Add(ucgh);

//}