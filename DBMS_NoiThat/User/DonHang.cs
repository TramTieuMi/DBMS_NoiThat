using DBMS_NoiThat.Entity;
using DBMS_NoiThat.UC;
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
            foreach (EGioHang gioHang in lst)
            {
                if (gioHang.MaGioHang1 == MaKhachHang)
                {
                    UCDonHang ucdh = new UCDonHang(gioHang);
                    int dis = (FPN_HienThi.Width - (2 * ucdh.Width)) / 3;
                    ucdh.Margin = new Padding(dis, dis, 0, 0);
                    FPN_HienThi.Controls.Add(ucdh);

                }
            }
        }
        public void LoadThongTin()
        {
            string connectionString = "";
            string query = "SELECT * FROM DONHANG";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Lấy giá trị của các cột
                            LB_MaDonHang.Text = reader["MaDonHang"].ToString();
                            LB_MaKH.Text = reader["TenDonHang"].ToString();
                            LB_SDTNguoiDat.Text = reader["MaKhachHang"].ToString();
                            LB_SoTien.Text = reader["TenNguoiDat"].ToString();
                            LB_TenDH.Text = reader["SDTNguoiDat"].ToString();
                            LB_TenNguoiDat.Text = reader["TenNguoiNhan"].ToString();
                            TB_SDTNguoiNhan.Text = reader["SDTNguoiNhan"].ToString();
                            TB_TenNguoiNhan.Text = reader["SDTNguoiNhan"].ToString();
                            TB_DiaChi.Text = reader["SDTNguoiNhan"].ToString();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không có dữ liệu.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }

        private void BTN_MuaHang_Click(object sender, EventArgs e)
        {

        }
    }
}
