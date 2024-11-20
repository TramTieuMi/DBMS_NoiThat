using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    public partial class GioHang : Form
    {
        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection;   // Declare the SqlConnection variable
        List<EGioHang> listGH = new List<EGioHang>();
        int maGH;

        public GioHang()
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
        }

        public GioHang(int MaGioHang)
        {
            InitializeComponent();
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            LoadGioHang(MaGioHang);
            maGH = MaGioHang;
        }

        public void LoadGioHang(int MaGioHang)
        {
            string query = "SELECT * FROM View_ChiTietGioHang";
            DataTable dataTable = new DataTable();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (MaGioHang == (int)row["MaGioHang"])
                    {
                        LB_MaGioHang.Text = "Mã Giỏ Hàng : " + row["MaGioHang"].ToString();
                        int MaGioHang1 = Convert.ToInt32(row["MaGioHang"]);
                        int MaSanPham1 = Convert.ToInt32(row["MaSanPham"]);
                        int SoLuong1 = Convert.ToInt32(row["SoLuong"]);
                        int SoTien1 = Convert.ToInt32(row["SoTien"]);
                        string TenSanPham1 = row["TenSanPham"].ToString();
                        byte[] pic = (byte[])row["HinhAnh"];
                        EGioHang gioHang = new EGioHang(MaGioHang1, MaSanPham1, SoLuong1, SoTien1, TenSanPham1, false, pic);
                        listGH.Add(gioHang);
                        UCGioHang ucgh = new UCGioHang(gioHang);
                        int dis = (FPN_HienThi.Width - (2 * ucgh.Width)) / 3;
                        ucgh.Margin = new Padding(dis, dis, 0, 0);
                        FPN_HienThi.Controls.Add(ucgh);
                    }
                }
            }
            else
            {
                Console.WriteLine("Không có dữ liệu trong giỏ hàng.");
            }
            connection.Close();
        }


        private void BTN_MuaHang_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu listGH rỗng hoặc không có sản phẩm nào được chọn để mua
            if (listGH.Count == 0 || !listGH.Exists(gioHang => gioHang.Check))
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào để mua");
                return;
            }

            string query1 = "sp_LayThongTinKhachHang";
            string hoVaTen, diaChi, sdt;
            int maDonHang;
            connection.Open();

            using (SqlCommand command1 = new SqlCommand(query1, connection))
            {
                command1.CommandType = CommandType.StoredProcedure; // Đảm bảo đặt loại lệnh là StoredProcedure
                command1.Parameters.AddWithValue("@MaKhachHang", maGH);

                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    if (reader.Read()) // Make sure to read the data
                    {
                        hoVaTen = reader["HovaTen"].ToString();    // Get HovaTen
                        diaChi = reader["DiaChi"].ToString();      // Get DiaChi
                        sdt = reader["SDT"].ToString();            // Get SDT
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng.");
                        return; // Exit if no customer found
                    }
                }
            }

            string query = "sp_ThemDonHang"; // Get the MaDonHang value just inserted

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure; // Đặt loại lệnh là StoredProcedure
                command.Parameters.AddWithValue("@MaKhachHang", maGH);
                command.Parameters.AddWithValue("@TenNguoiDat", hoVaTen);
                command.Parameters.AddWithValue("@SDTNguoiDat", sdt);
                command.Parameters.AddWithValue("@TenNguoiNhan", hoVaTen);
                command.Parameters.AddWithValue("@SDTNguoiNhan", sdt);
                command.Parameters.AddWithValue("@NgayMuaHang", DateTime.Now);
                command.Parameters.AddWithValue("@DiaChiNhan", diaChi);
                command.Parameters.AddWithValue("@TrangThai", "Ðang chờ xác nhận");
                maDonHang = Convert.ToInt32(command.ExecuteScalar());
            }


            string query3 = "sp_ThemDonHangSanPham";
            foreach (EGioHang gioHang in listGH)
            {
                if (gioHang.Check)
                {
                    using (SqlCommand command = new SqlCommand(query3, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaDonHang", maDonHang);
                        command.Parameters.AddWithValue("@MaKhachHang", maGH);
                        command.Parameters.AddWithValue("@MaSanPham", gioHang.MaSanPham1);
                        command.Parameters.AddWithValue("@TenSanPham", gioHang.TenSanPham1);
                        command.Parameters.AddWithValue("@SoLuong", gioHang.SoLuong1);
                        command.Parameters.AddWithValue("@SoTien", gioHang.SoTien1);
                        MemoryStream picture = new MemoryStream(gioHang.Pic);
                        command.Parameters.AddWithValue("@HinhAnh", picture);
                        command.ExecuteNonQuery();
                    }

                }
            }
            connection.Close();
            DonHang dh = new DonHang(maDonHang);
            dh.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GioHang_Load(object sender, EventArgs e)
        {

        }

        private void LB_MaGioHang_Click(object sender, EventArgs e)
        {

        }
    }
}
