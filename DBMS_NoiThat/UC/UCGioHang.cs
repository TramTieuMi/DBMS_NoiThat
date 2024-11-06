using DBMS_NoiThat.Entity;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using System.Data.SqlClient;
using DBMS_NoiThat.user;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DBMS_NoiThat.UC
{
    public partial class UCGioHang : UserControl
    {
        private DBConnection dbConnection; // Declare an instance of DBConnection
        private SqlConnection connection;   // Declare the SqlConnection variable
        public UCGioHang()
        {
            InitializeComponent();
        }

        EGioHang gioHang;
        public UCGioHang(EGioHang gioHang)
        {
            InitializeComponent();
            this.gioHang = gioHang;
            LB_MaSanPham.Text = "Mã Sản Phẩm : " + gioHang.MaSanPham1.ToString();
            LB_TenSanPham.Text = "Tên Sản Phẩm : " + gioHang.TenSanPham1;
            LB_Gia.Text = "Số Tiền : " + gioHang.SoTien1.ToString();
            TB_SoLuong.Text = gioHang.SoLuong1.ToString();
            CK_Chon.Checked = gioHang.Check ;

        }
        public void ThayDoiSoLuong(int num)
        {
            TB_SoLuong.Text = num.ToString();
            gioHang.SoLuong1 = num;

            dbConnection = new DBConnection(); // Instantiate DBConnection
            connection = dbConnection.GetConnection(); // Get the connection
            string query = "UpdateSoLuongInGioHang";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaGioHang", gioHang.MaGioHang1);
                command.Parameters.AddWithValue("@MaSanPham", gioHang.MaSanPham1);
                command.Parameters.AddWithValue("@SoLuong", num);
                connection.Open();
                command.ExecuteNonQuery(); 
                connection.Close();
            }
            string query1 = "SELECT * FROM View_ChiTietGioHang";
            DataTable dataTable = new DataTable();
            connection.Open();
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command1);

            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows) 
                {

                    if (gioHang.MaGioHang1 == Convert.ToInt32(row["MaGioHang"]) && gioHang.MaSanPham1 == Convert.ToInt32(row["MaSanPham"]))
                    {
                        gioHang.SoTien1 = Convert.ToInt32(row["SoTien"]);
                        LB_Gia.Text = "Số Tiền : " + gioHang.SoTien1.ToString();
                        break;
                    }
                }
            }

        }
        private void BTN_Giam_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TB_SoLuong.Text) - 1;
            if (num < 0)
            {
                MessageBox.Show("Số lượng không thể âm.");
                return;
            }else
            {
                ThayDoiSoLuong(num);
            }
            
        }

        private void BTN_Tang_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TB_SoLuong.Text) + 1;
            ThayDoiSoLuong(num);
        }

        private void CK_Chon_CheckedChanged(object sender, EventArgs e)
        {
            if (CK_Chon.Checked == true)
            {
                gioHang.Check = true;
            }
        }
        public void AddCheckVaSouong(bool check, int soLuong)
        {
            check = CK_Chon.Checked;
            soLuong = Convert.ToInt32(TB_SoLuong.Text);
        }

        private void TB_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if(TB_SoLuong.Text != "")
            {
                int num = Convert.ToInt32(TB_SoLuong.Text);
                ThayDoiSoLuong(num);
            }

        }
    }
}
