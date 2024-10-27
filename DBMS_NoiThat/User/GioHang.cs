using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            LB_Ma.Text = "Mã Giỏ Hàng :";
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
                foreach (DataRow row in dataTable.Rows) // Loop through each row in DataTable
                {
                    
                    if (MaGioHang == (int)row["MaGioHang"])
                    {
                        LB_MaGioHang.Text = row["MaGioHang"].ToString();
                        int MaGioHang1 = (int)row["MaGioHang"];
                        int MaSanPham1 = (int)row["MaSanPham"];
                        int SoLuong1 = (int)row["SoLuong"];
                        int SoTien1 = (int)row["SoTien"];
                        string TenSanPham1 = row["TenSanPham"].ToString();
                        EGioHang gioHang = new EGioHang(MaGioHang1, MaSanPham1, SoLuong1, SoTien1, TenSanPham1, false);
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
            string query1 = "sp_LayThongTinKhachHang";
            string hoVaTen, diaChi, sdt;
            int maDonHang;
            connection.Open();

            using (SqlCommand command1 = new SqlCommand(query1, connection))
            {
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
                command.Parameters.AddWithValue("@MaKhachHang", maGH);
                command.Parameters.AddWithValue("@TenNguoiDat", hoVaTen);
                command.Parameters.AddWithValue("@SDTNguoiDat", sdt);
                command.Parameters.AddWithValue("@TenNguoiNhan", hoVaTen);
                command.Parameters.AddWithValue("@SDTNguoiNhan", sdt);
                command.Parameters.AddWithValue("@NgayMuaHang", DateTime.Now);
                command.Parameters.AddWithValue("@DiaChiNhan", diaChi);
                command.Parameters.AddWithValue("@TrangThai", "Đặt Hàng");
                maDonHang = Convert.ToInt32(command.ExecuteScalar());
            }


            string query3 = "sp_ThemDonHangSanPham";
            foreach (EGioHang gioHang in listGH)
            {
                if (gioHang.Check)
                {
                    using (SqlCommand command = new SqlCommand(query3, connection))
                    {
                        // Thêm các tham số vào lệnh SQL
                        command.Parameters.AddWithValue("@MaDonHang", maDonHang);
                        command.Parameters.AddWithValue("@MaKhachHang", maGH);
                        command.Parameters.AddWithValue("@MaSanPham", gioHang.MaSanPham1);
                        command.Parameters.AddWithValue("@TenSanPham", gioHang.TenSanPham1);
                        command.Parameters.AddWithValue("@SoLuong", gioHang.SoLuong1);
                        command.Parameters.AddWithValue("@SoTien", gioHang.SoTien1);

                        // Thực thi lệnh SQL
                        command.ExecuteNonQuery();
                    }
                }
            }
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
