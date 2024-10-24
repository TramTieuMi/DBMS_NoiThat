using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }
        static string connectionString = "";
        SqlConnection connection = new SqlConnection(connectionString);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FPN_HienThi_Paint(object sender, PaintEventArgs e)
        {

        }
        List<EGioHang> listGH ;
        int maGH;
        public GioHang(int MaGioHang)
        {
            InitializeComponent();
            LoadGioHang(MaGioHang);
            maGH= MaGioHang;
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
                foreach (DataRow row in dataTable.Rows) // Lặp qua từng hàng trong DataTable
                {
                    if(MaGioHang == (int)row["MaGioHang"])
                    {
                            
                        int MaGioHang1 = (int)row["MaGioHang"];
                        int MaSanPham1 = (int)row["MaSanPham"];
                        int SoLuong1 = (int)row["SoLuong"];
                        int SoTien1 = (int)row["SoTien"]; // Giả sử SoTien là kiểu decimal
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
            

            
        }

        private void BTN_MuaHang_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT MaKhachHang, HovaTen, DiaChi, SDT FROM KHACHHANG WHERE MaKhachHang = @MaKhachHang";
            string hoVaTen, diaChi, sdt;
            int maDonHang;
            List<EGioHang> lst = new List<EGioHang>();
            connection.Open();
            using (SqlCommand command1 = new SqlCommand(query1, connection))
            {
                command1.Parameters.AddWithValue("@MaKhachHang", maGH);

                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    hoVaTen = reader["HovaTen"].ToString();    // Lấy HovaTen
                    diaChi = reader["DiaChi"].ToString();      // Lấy DiaChi
                    sdt = reader["SDT"].ToString();        // Lấy SDT

                }
            }

            string query = "INSERT INTO DONHANG (MaSanPham, MaKhachHang, TenNguoiDat, SDTNguoiDat, " +
               "TenNguoiNhan, SDTNguoiNhan, TongTien, NgayMuaHang, DiaChiNhan, TrangThai) " +
               "VALUES (@MaSanPham, @MaKhachHang, @TenNguoiDat, @SDTNguoiDat, " +
               "@TenNguoiNhan, @SDTNguoiNhan, @TongTien, @NgayMuaHang, @DiaChiNhan, @TrangThai); " +
               "SELECT SCOPE_IDENTITY();"; // Lấy giá trị MaDonHang vừa chèn

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@MaKhachHang", maGH);
                command.Parameters.AddWithValue("@TenNguoiDat", hoVaTen);
                command.Parameters.AddWithValue("@SDTNguoiDat", sdt);
                command.Parameters.AddWithValue("@TenNguoiNhan", hoVaTen);
                command.Parameters.AddWithValue("@SDTNguoiNhan", sdt);
                command.Parameters.AddWithValue("@NgayMuaHang", DateTime.Now);
                command.Parameters.AddWithValue("@DiaChiNhan", diaChi);
                command.Parameters.AddWithValue("@TrangThai", "Chưa Xác Nhận");
                maDonHang = Convert.ToInt32(command.ExecuteScalar());
                command.ExecuteNonQuery();
            }
            string query2 = "INSERT INTO DONHANG_SANPHAM (MaDonHang, MaKhachHang, MaSanPham, TenSanPham, SoLuong, SoTien) " +
                   "VALUES (@MaDonHang, @MaKhachHang, @MaSanPham, @TenSanPham, @SoLuong, @SoTien)";
            foreach (EGioHang gioHang in listGH)
            {
                UCGioHang uc =new UCGioHang();
                uc.AddCheckVaSouong(gioHang.Check, gioHang.SoLuong1);
                if(gioHang.Check)
                {
                    lst.Add(gioHang);
                    using(SqlCommand command = new SqlCommand(query2, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@MaDonHang", maDonHang);
                        command.Parameters.AddWithValue("@MaKhachHang", maGH);
                        command.Parameters.AddWithValue("@MaSanPham", gioHang.MaSanPham1);
                        command.Parameters.AddWithValue("@TenSanPham", gioHang.TenSanPham1);
                        command.Parameters.AddWithValue("@SoLuong", gioHang.SoLuong1);
                        command.Parameters.AddWithValue("@SoTien", gioHang.SoTien1);

                        command.ExecuteNonQuery();
                    }

                }           
            }
            Application.Run(new DonHang(maGH, lst));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GioHang_Load(object sender, EventArgs e)
        {

        }
    }
}
