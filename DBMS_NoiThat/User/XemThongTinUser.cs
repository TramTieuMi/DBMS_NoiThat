using DBMS_NoiThat.user;
using Do_An_Tuyen_Dung;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DBMS_NoiThat.user
{
    public partial class XemThongTinUser : Form
    {
        private bool isEditing = false;
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        private int TenDangNhap;
        public XemThongTinUser()
        {
            InitializeComponent();
            ThucThi(FDangNhap.TenDangNhap); // Lấy thông tin người dùng khi form được mở
        }

        public XemThongTinUser(string tenUV, string email)
        {
            InitializeComponent();
            string tenTK = KiemTK(email);
            ThucThi(tenTK);
            ToggleEdit(false); // Đặt form ở chế độ xem (không cho phép chỉnh sửa)
        }
        private void ToggleEdit(bool enable)
        {
            // Bật hoặc tắt chế độ chỉnh sửa
            txtDiaChi.ReadOnly = !enable;
            txtSdt.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;
            btnSave.Visible = enable; // Hiển thị nút "Lưu" khi chế độ chỉnh sửa bật
            btnEdit.Text = enable ? "Cancel" : "Edit"; // Đổi thành "Cancel" khi đang chỉnh sửa

            // Thay đổi màu nền khi chế độ chỉnh sửa bật hoặc tắt
            txtDiaChi.BackColor = enable ? Color.White : Color.LightGray;
            txtSdt.BackColor = enable ? Color.White : Color.LightGray;
            txtEmail.BackColor = enable ? Color.White : Color.LightGray;
        }

        private string KiemTK(string email)
        {
            string tenTK = string.Empty;
            string query = "SELECT TenDangNhap FROM TAIKHOAN WHERE Email = @Email";

            using (SqlCommand command = new SqlCommand(query, connStr))
            {
                command.Parameters.AddWithValue("@Email", email);
                connStr.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tenTK = reader["TenDangNhap"].ToString();
                }
                connStr.Close();
            }

            return tenTK;
        }

        public void ThucThi(string tenTK)
        {
            // Tải dữ liệu user từ cơ sở dữ liệu và điền vào các TextBox
            using (SqlConnection connection = new SqlConnection(connStr.ConnectionString))
            {
                string query = "SELECT * from View_ThongTinTaiKhoanUser WHERE TenDangNhap = @TenDangNhap";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenDangNhap", tenTK);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtHoTen.Text = reader["HovaTen"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtDiaChi.Text = reader["DiaChi"].ToString();
                    txtSdt.Text = reader["SDT"].ToString();
                    txtTenDangNhap.Text = reader["TenDangNhap"].ToString();
                }
                connection.Close();
            }
        }




        private void UpdateUserData()
        {// Cập nhật thông tin người dùng trong cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connStr.ConnectionString))
            {
                string query = "UPDATE KHACHHANG " +
                    "SET KHACHHANG.SDT = @SDT, KHACHHANG.DiaChi = @DiaChi " +
                    "FROM KHACHHANG " +
                    "JOIN TAIKHOAN ON KHACHHANG.Email = TAIKHOAN.Email " +
                    "WHERE HovaTen = @HovaTen";


                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                command.Parameters.AddWithValue("@Sdt", txtSdt.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@HovaTen", txtHoTen.Text);
                command.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                // Mở kết nối và thực thi câu lệnh
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("TenDangNhap: " + txtHoTen.Text);
                // Kiểm tra kết quả
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thông tin đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi nào để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("Thông tin đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void XemThongTinUser_Load(object sender, EventArgs e)
        {
            txtDiaChi.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }

   

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Nếu đang ở chế độ chỉnh sửa, hủy và quay lại chế độ xem
                ThucThi(FDangNhap.TenDangNhap); // Tải lại dữ liệu ban đầu
                ToggleEdit(false);
                isEditing = false;
                
            }
            else
            {
                // Kích hoạt chế độ chỉnh sửa
                ToggleEdit(true);
                isEditing = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            // Lưu thông tin và quay về chế độ xem
            UpdateUserData();
            ToggleEdit(false);
            isEditing = false;
        }
    }

}

