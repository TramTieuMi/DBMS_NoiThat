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
            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
        }

        public List<int> ExtractNumbers(string input)
        {
            // Tách chuỗi theo dấu phẩy
            string[] parts = input.Split(',');

            // Danh sách lưu các số
            List<int> numbers = new List<int>();

            // Duyệt qua các phần tử
            foreach (string part in parts)
            {
                // Kiểm tra và chuyển đổi thành số
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
                    int maSanPham = ListMSP[i]; // Lấy giá trị từ danh sách ListMSP
                    int maKhachHang = ListMKH[j]; // Lấy giá trị từ danh sách ListMKH
                    using (SqlCommand command = new SqlCommand("sp_InsertDiscount", connection))
                    {
                        connection.Open();
                        // Thiết lập thủ tục
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                        command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        command.Parameters.Add("@SoLuongGiam", SqlDbType.Decimal).Value = soLuongGiam;
                        command.Parameters.AddWithValue("@NgayApDung", ngayApDung);
                        command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                        command.Parameters.AddWithValue("@LiDo", liDo);

                        // Thực thi thủ tục
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
            }
            MessageBox.Show("Tạo Discount thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
