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
            ThucThi(FDangNhap.TenDangNhap); /////////////////////////////////////////////////////////////////////////
        }
        public XemThongTinUser(string tenUV, string email)
        {
            InitializeComponent();
            string tenTK = KiemTK(email);
            ThucThi(tenTK);
            ToggleEdit(false); // Mặc định là chế độ xem, không cho phép chỉnh sửa
        }
        private void ToggleEdit(bool enable)
        {
            // Kích hoạt hoặc vô hiệu chỉnh sửa trên các TextBox
            txtDiaChi.ReadOnly = !enable;  // Đổi từ ReadOnly thành có thể chỉnh sửa
            txtSdt.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;

            btnSave.Visible = enable;  // Hiển thị nút "Lưu" khi chế độ chỉnh sửa bật
            btnEdit.Text = enable ? "Cancel" : "Edit";  // Đổi thành "Cancel" khi đang chỉnh sửa

            // Tùy chỉnh màu nền và kiểu dáng để báo hiệu chế độ xem hay chỉnh sửa
            if (!enable)
            {
                // Màu nền khi không thể chỉnh sửa
                txtDiaChi.BackColor = System.Drawing.Color.LightGray;
                txtSdt.BackColor = System.Drawing.Color.LightGray;
                txtEmail.BackColor = System.Drawing.Color.LightGray;
            }
            else
            {
                // Màu nền khi ở chế độ chỉnh sửa
                txtDiaChi.BackColor = System.Drawing.Color.White;
                txtSdt.BackColor = System.Drawing.Color.White;
                txtEmail.BackColor = System.Drawing.Color.White;
            }
        }
        private void XemProfileUser_Load(object sender, EventArgs e)
        {
            // Mặc định các TextBox là ReadOnly (hoặc có thể dùng Enabled = false)
            txtDiaChi.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtEmail.ReadOnly = true;
        }

        public string KiemTK(string email)
        {
            string tk = string.Empty;
            string query = "SELECT TenDangNhap,Email FROM TAIKHOAN";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Email"].ToString() == email)
                {
                    tk = reader["TenDangNhap"].ToString();
                    break;
                }
            }
            return tk;
        }


        public void ThucThi(string tenTK)
        {
            //đoạn này chưa đụng đến nha

            FDangNhap fLogin = new FDangNhap();
            string em = "VanKien@gmail.com";
            DataTable dataTable = new DataTable();
            string sqlQuery = "SELECT HovaTen,Email,DiaChi,SDT FROM KHACHHANG WHERE Email = @Email";


            DataTable dataTable1 = new DataTable();
            string sqlQuery1 = "SELECT * FROM View_ThongTinTaiKhoanUser where TenDangNhap = @TenDangNhap";
            modify.TaiDuLieu(dataTable1, sqlQuery1, "@TenDangNhap", tenTK);
            if (dataTable1.Rows.Count > 0)
            {
                foreach (DataRow row1 in dataTable1.Rows)
                {
                    string TenTK = row1["TenDangNhap"].ToString();
                    if (TenTK == tenTK)
                    {
                        em = row1["Email"].ToString();
                    }
                }
            }

            modify.TaiDuLieu(dataTable, sqlQuery, "@Email", em);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string email = row["Email"].ToString();
                    if (email == em)
                    {
                        txtHoTen.Text = row["HovaTen"].ToString();
                        txtDiaChi.Text = row["DiaChi"].ToString();
                        txtSdt.Text = row["SDT"].ToString();
                        txtEmail.Text = row["Email"].ToString();

                    }
                }
            }
        }

        private void lbSdt_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Nếu đang ở chế độ chỉnh sửa, và nhấn "Cancel", hủy bỏ và quay lại chế độ xem
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
        private void UpdateUserData()
        {

            // Cập nhật thông tin user trong cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connStr.ConnectionString))
            {
                string query = "UPDATE KHACHHANG " +
               "SET KHACHHANG.SDT = @SDT, KHACHHANG.DiaChi = @DiaChi " +
               "FROM KHACHHANG " +
               "JOIN TAIKHOAN ON KHACHHANG.Email = TAIKHOAN.Email " +
               "WHERE HovaTen = @TenDangNhap";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@SDT", txtSdt.Text);
                command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@TenDangNhap", txtHoTen.Text);

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


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lưu thông tin và quay về chế độ xem
            UpdateUserData();
            ToggleEdit(false);
            isEditing = false;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
