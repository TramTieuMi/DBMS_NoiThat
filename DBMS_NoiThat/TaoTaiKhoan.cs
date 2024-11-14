using DBMS_NoiThat.user;
using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat
{
    public partial class TaoTaiKhoan : Form
    {
        //SqlConnection stringConnection = Connection.GetSqlConnection();
        SqlConnection connStr = Connection.GetSqlConnection();
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {

        }
        public bool checkAccount(string ac)//check mat khau va ten tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool checkEmail(string em) //Check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");// @"^[\w_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            string Hoten = txtHoten.Text;
            string tentk = txtTenTK.Text;
            string DiaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string matkhau = txtMatkhau.Text;
            string sdt =txtSdt.Text;
            string role = comboBxRole.Text;


            int roleid = -1; ;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản 6-24 kí tự,chỉ với các kí tự chữ và số, có thể là chữ hoa hoặc chữ thường!"); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu  6-24 kí tự,chỉ với các kí tự chữ và số, có thể là chữ hoa hoặc chữ thường!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if (modify.taiKhoans("Select * from TAIKHOAN where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng kí, vui lòng đăng kí email khác!"); return; }
            // Kiểm tra tên đăng nhập đã tồn tại
            if (modify.taiKhoans("SELECT * FROM TAIKHOAN WHERE TenDangNhap = '" + tentk + "'").Count != 0)
            {
                MessageBox.Show("Tên tài khoản này đã được sử dụng, vui lòng chọn tên khác!");
                return;
            }
            try
            {
                
                if (role == "Người dùng")
                {
                    roleid = 2;
                }
                else if (role == "Quản trị viên")
                {
                    roleid = 1;
                }
                string queryKH = "INSERT INTO KHACHHANG (HoVaTen, Email, DiaChi, SDT, NgayTao, MatKhau, RoleID, TenDangNhap) " +
                 "VALUES (@HoVaTen, @Email, @DiaChi, @SDT, GETDATE(), @MatKhau, @RoleID, @TenDangNhap)";

                
                // Sử dụng Transaction
                using (SqlConnection connection = new SqlConnection(connStr.ConnectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        using (SqlCommand cmdKH = new SqlCommand(queryKH, connection, transaction))
                        {
                            cmdKH.Parameters.AddWithValue("@HoVaTen", Hoten);
                            cmdKH.Parameters.AddWithValue("@Email", email);
                            cmdKH.Parameters.AddWithValue("@DiaChi", DiaChi);
                            cmdKH.Parameters.AddWithValue("@SDT", sdt);
                            cmdKH.Parameters.AddWithValue("@MatKhau", matkhau);
                            cmdKH.Parameters.AddWithValue("@RoleID", roleid);
                            cmdKH.Parameters.AddWithValue("@TenDangNhap", tentk);
                            cmdKH.ExecuteNonQuery();
                        }

                        
                        // Commit transaction nếu cả hai câu lệnh INSERT đều thành công
                        transaction.Commit();
                        MessageBox.Show("Đăng ký thành công!");

                        Hide();
                        FDangNhap dangnhap = new FDangNhap();
                        dangnhap.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show("Đăng ký thất bại: " + ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký thất bại: " + ex.Message);
            }

        }
    }
}

