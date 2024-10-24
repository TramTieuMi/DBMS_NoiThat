using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
using DBMS_NoiThat.user;
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
        string connectionString = "";
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
        public DonHang(int MaKhachHang, List<EGioHang> lst)
        {
            InitializeComponent();
            LoadSanPham(MaKhachHang, lst);

        }
        public void LoadSanPham(int MaKhachHang, List<EGioHang> lst)
        {
            int sum = 0;
            foreach (EGioHang gioHang in lst)
            {
                if (gioHang.MaGioHang1 == MaKhachHang)
                {
                    UCDonHang ucdh = new UCDonHang(gioHang);
                    int dis = (FPN_HienThi.Width - (2 * ucdh.Width)) / 3;
                    ucdh.Margin = new Padding(dis, dis, 0, 0);
                    FPN_HienThi.Controls.Add(ucdh);
                    sum = sum + gioHang.SoTien1;
                }
            }
            LB_SoTien.Text = sum.ToString();
        }
        public void LoadThongTin(int maKH)
        {

            string query = "SELECT * FROM View_ChiTietDonHang";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows) // Lặp qua từng hàng trong DataTable
                    {
                        if (maKH == (int)row["MaGioHang"] && row["TrangThai"].ToString() == "Chưa Xác Nhận")
                        {

                            int MaGioHang1 = (int)row["MaGioHang"];
                           
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Không có dữ liệu trong giỏ hàng.");
                }
            }
        }

        private void BTN_MuaHang_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DONHANG (TenNguoiNhan, SDTNguoiNhan, NgayMuaHang, DiaChiNhan, TrangThai) " +
                               "VALUES (@TenNguoiNhan, @SDTNguoiNhan, @NgayMuaHang, @DiaChiNhan, @TrangThai)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenNguoiNhan", TB_TenNguoiNhan.Text);
                    command.Parameters.AddWithValue("@SDTNguoiNhan", TB_SDTNguoiNhan.Text);
                    command.Parameters.AddWithValue("@NgayMuaHang", DateTime.Now);
                    command.Parameters.AddWithValue("@DiaChiNhan", TB_DiaChi.Text);
                    command.Parameters.AddWithValue("@TrangThai", " Đang Xác Nhận");

                    // Mở kết nối và thực thi câu lệnh
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
