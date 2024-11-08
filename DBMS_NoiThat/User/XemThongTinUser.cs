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
            // Kích hoạt hoặc vô hiệu chỉnh sửa trên các TextBox
            txtDiaChi.ReadOnly = !enable;  // Đổi từ ReadOnly thành có thể chỉnh sửa
            txtSdt.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;

        private void ToggleEdit(bool enable)
        {
            // Bật hoặc tắt chế độ chỉnh sửa
            txtDiaChi.ReadOnly = !enable;
            txtSdt.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;
            //btnSave.Visible = enable; // Hiển thị nút "Lưu" khi chế độ chỉnh sửa bật
            //btnEdit.Text = enable ? "Cancel" : "Edit"; // Đổi thành "Cancel" khi đang chỉnh sửa

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
            // Lấy thông tin người dùng từ cơ sở dữ liệu và điền vào các trường TextBox
            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT HovaTen, Email, DiaChi, SDT FROM KHACHHANG WHERE Email = @Email";

            string em = string.Empty;

            // Lấy email từ tài khoản
            DataTable dataTable1 = new DataTable();
            string sqlQuery1 = "SELECT * FROM View_ThongTinTaiKhoanUser WHERE TenDangNhap = @TenDangNhap";
            modify.TaiDuLieu(dataTable1, sqlQuery1, "@TenDangNhap", tenTK);
            if (dataTable1.Rows.Count > 0)
            {
                em = dataTable1.Rows[0]["Email"].ToString();
            }

            // Lấy thông tin chi tiết của khách hàng dựa trên email
            modify.TaiDuLieu(dataTable, sqlQuery, "@Email", em);
            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                txtHoTen.Text = row["HovaTen"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();
                txtSdt.Text = row["SDT"].ToString();
                txtEmail.Text = row["Email"].ToString();
            }
        }



        private void UpdateUserData()
        {
            // Cập nhật thông tin người dùng trong cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connStr.ConnectionString))
            {
                string query = "UPDATE TAIKHOAN SET Email = @Email WHERE TenDangNhap = @TenDangNhap";
                SqlCommand command = new SqlCommand(query, connection);

                // Đảm bảo rằng các tham số cần thiết có giá trị
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@TenDangNhap", FDangNhap.TenDangNhap); // Giả định `FDangNhap.TenDangNhap` chứa tên đăng nhập hiện tại

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Thông tin đã được cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateUserData()
        {

       

        private void XemThongTinUser_Load(object sender, EventArgs e)
        {

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lưu thông tin và quay về chế độ xem
            UpdateUserData();
            ToggleEdit(false);
            isEditing = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Lưu thông tin và quay về chế độ xem
            UpdateUserData();
            ToggleEdit(false);
            isEditing = false;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
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
    }
}

