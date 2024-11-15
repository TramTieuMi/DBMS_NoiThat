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
        DBConnection myDB = new DBConnection();
        public TaoTaiKhoan()
        {
            InitializeComponent();
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
                //string queryKH = "INSERT INTO KHACHHANG (HoVaTen, Email, DiaChi, SDT, NgayTao, MatKhau, RoleID, TenDangNhap) " +
                // "VALUES (@HoVaTen, @Email, @DiaChi, @SDT, GETDATE(), @MatKhau, @RoleID, @TenDangNhap)";
                
                //string queryTKKH = "INSERT INTO TAIKHOAN (TenDangNhap,MatKhau,Email,RoleID) " +
                //"VALUES (@TenDangNhap,@MatKhau,@Email,@RoleID)";

                // Sử dụng Transaction
                using (SqlConnection connection = new SqlConnection(connStr.ConnectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    myDB.OpenConnection();
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("[InsertKhachHang]", myDB.GetConnection());
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@HoVaTen", Hoten);
                        cmd1.Parameters.AddWithValue("@Email", email);
                        cmd1.Parameters.AddWithValue("@DiaChi", DiaChi);
                        cmd1.Parameters.AddWithValue("@SDT", sdt);
                        cmd1.Parameters.AddWithValue("@MatKhau", matkhau);
                        cmd1.Parameters.AddWithValue("@RoleID", roleid);
                        cmd1.Parameters.AddWithValue("@TenDangNhap", tentk);
                        cmd1.ExecuteNonQuery();

                        //SqlCommand cmd = new SqlCommand("[InsertTaiKhoan]", myDB.GetConnection());
                        //cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@TenDangNhap", tentk);
                        //cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                        //cmd.Parameters.AddWithValue("@Email", email);
                        //cmd.Parameters.AddWithValue("@RoleID", roleid);
                        //cmd.ExecuteNonQuery();

                    

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

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}

