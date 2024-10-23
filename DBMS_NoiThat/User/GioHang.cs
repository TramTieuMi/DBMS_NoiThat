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

namespace DBMS_NoiThat.user
{
    public partial class GioHang : Form
    {
        public GioHang()
        {
            InitializeComponent();
        }
        string connectionString = "";
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
                        if(MaGioHang == (int)row["MaGioHang"])
                        {
                            
                            int MaGioHang1 = (int)row["MaGioHang"];
                            int MaSanPham1 = (int)row["MaSanPham"];
                            int SoLuong1 = (int)row["SoLuong"];
                            int SoTien1 = (int)row["SoTien"]; // Giả sử SoTien là kiểu decimal
                            string TenSanPham1 = row["TenSanPham"].ToString();
                            EGioHang gioHang = new EGioHang(MaGioHang1, MaSanPham1, SoLuong1, SoTien1, TenSanPham1, false);

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

            
        }

        private void BTN_MuaHang_Click(object sender, EventArgs e)
        {
           
            Application.Run(new DonHang(maGH, new List<EGioHang>())); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GioHang_Load(object sender, EventArgs e)
        {

        }
    }
}
