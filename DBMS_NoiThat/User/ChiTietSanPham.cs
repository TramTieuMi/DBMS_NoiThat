using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMS_NoiThat.user
{
    public partial class ChiTietSanPham : Form
    {
        public ChiTietSanPham()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChiTietSanPham_Load(object sender, EventArgs e)
        {

        }
        public ChiTietSanPham(int MaSanPham)
        {
            InitializeComponent();
            LoadChiTietSanPham(MaSanPham);
        }
        public void LoadChiTietSanPham(int MaSanPham)
        {
            string connectionString = "";
            string query = "SELECT * FROM SANPHAM WHERE MaSanPham = @MaSanPham";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaSanPham", MaSanPham);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read() )
                        {
                            LB_MaSanPham.Text = reader["MaSanPham"].ToString();
                            LB_TenSP.Text = reader["TenSanPham"].ToString();
                            LB_ChatLieu.Text = reader["ChatLieu"].ToString();
                            LB_Gia.Text = reader["GiaSanPham"].ToString();
                            LB_KichThuoc.Text = reader["KichThuoc"].ToString();
                            LB_MauSac.Text = reader["MauSac"].ToString();
                            LB_SoLuong.Text = reader["SoLuong"].ToString();
                            LB_MoTa.Text = reader["MoTa"].ToString();
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
                    // Xử lý lỗi
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
