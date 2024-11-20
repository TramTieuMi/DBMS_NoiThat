using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using DBMS_NoiThat.Entity;


namespace DBMS_NoiThat.user
{
    public partial class ChiTietSanPhamForm : Form
    {
        DBConnection mydb = new DBConnection();
        public int idKH;
        public ChiTietSanPhamForm()
        {
            

            InitializeComponent();
        }

       
      

        private void buttonThemVaoGio_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra xem sản phẩm đó có tồn tại chưa rồi mới thêm
                int id = Convert.ToInt32(LableIDSP.Text);
                mydb.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT dbo.KiemTraGioHangTonTai(@MaDonHang, @MaSanPham)", mydb.GetConnection());
                cmd.Parameters.AddWithValue("@MaDonHang", idKH);
                cmd.Parameters.AddWithValue("@MaSanPham", id);
                int status = (int)cmd.ExecuteScalar();
                mydb.CloseConnection();



                // Tạo đối tượng kết nối từ lớp DBConnection
                DBConnection db = new DBConnection();

                // Gọi hàm cập nhật hoặc thêm dữ liệu vào bảng SANPHAM_GOIY
                int maSanPham = id;
                int maKhachHang = idKH;
                int soLuongTruyCap = 1;
                DateTime ngayTruyCapGanDay = DateTime.Now;

                try
                {
                    db.OpenConnection(); // Mở kết nối
                    SqlConnection sqlCon = db.GetConnection();

                    // Gọi Stored Procedure
                    using (SqlCommand cmd1 = new SqlCommand("sp_UpdateOrInsertSanPhamGoiY", sqlCon))
                    {
                        cmd1.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số vào Stored Procedure
                        cmd1.Parameters.AddWithValue("@MaSanPham", maSanPham);
                        cmd1.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                        cmd1.Parameters.AddWithValue("@SoLuongTruyCap", soLuongTruyCap);
                        cmd1.Parameters.AddWithValue("@NgayTruyCapGanDay", ngayTruyCapGanDay);

                        // Thực thi Stored Procedure
                        cmd1.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.CloseConnection(); // Đóng kết nối
                }




                //kiểm tra xem sản phẩm đó có tồn tại chưa rồi mới thêm
                if (status == 1) // nếu  đã thêm rồi...
                {
                    MessageBox.Show("Sản Phẩm Này Đã Được Thêm Vào Thêm Giỏ Hàng Của Bạn Trước Đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (status == 0) // chưa có thêm...
                {
                    decimal giaTo = Convert.ToDecimal(TextBoxGiaSP.Text);
                    int giaSP = Convert.ToInt32(giaTo);
                    int sl = Convert.ToInt32(domainUpDownSoLuong.Text);
                    mydb.OpenConnection();
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("proc_ThemVaoGioHang", mydb.GetConnection());
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@MaGioHang", idKH);
                        cmd1.Parameters.AddWithValue("@MaSanPham", id);
                        cmd1.Parameters.AddWithValue("@SoLuong", sl);
                        // cmd1.Parameters.AddWithValue("@SoTien", giaSP * sl);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi thực hiện thủ tục SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    mydb.CloseConnection();
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thủ tục SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonTroVe_Click(object sender, EventArgs e)
        {
            try
            {

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
