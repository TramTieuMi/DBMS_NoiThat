using DBMS_NoiThat.Entity;
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

namespace DBMS_NoiThat.admin
{
    public partial class DisCount : Form
    {
        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection;   // Declare the SqlConnection variable
        public DisCount()
        {
            InitializeComponent();
            LB_TieuDe.Text = "Tạo Mã Giảm Giá";
            LB_MKH.Text = "Mã Khách Hàng";
            LB_MSPh.Text = "Mã Sản Phẩm";
            LB_NAD.Text = "Ngày Áp Dụng";
            LB_NKT.Text = "Ngày Kết Thúc";
            LB_GT.Text = "Giá Trị Giảm";
            LB_LiDo.Text = "Lí Do Giảm";
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
        }

        public List<int> ExtractNumbers(string input)
        {
            string[] parts = input.Split(',');
            List<int> numbers = new List<int>();
            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }
        private void BTN_AD_Click(object sender, EventArgs e)
        {
            List<int> ListMSP  = ExtractNumbers(TB_MSP.Text);
            List<int> ListMKH = ExtractNumbers(TB_MKH.Text);
            decimal soLuongGiam = Math.Round(decimal.Parse(TB_GTG.Text), 3);
            DateTime ngayApDung = DTP_NAD.Value.Date; ;
            DateTime ngayKetThuc = DTP_NKT.Value.Date; ;
            string liDo = TB_LDG.Text;
            for (int i = 0; i < ListMSP.Count; i++)
            {
                for (int j = 0; j < ListMKH.Count; j++)
                {
                    int maSanPham = ListMSP[i]; 
                    int maKhachHang = ListMKH[j]; 
                    using (SqlCommand command = new SqlCommand("sp_InsertDiscount", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                        command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        command.Parameters.Add("@SoLuongGiam", SqlDbType.Decimal).Value = soLuongGiam;
                        command.Parameters.AddWithValue("@NgayApDung", ngayApDung);
                        command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                        command.Parameters.AddWithValue("@LiDo", liDo);
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
            }
            MessageBox.Show("Tạo Discount thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
