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
        SqlConnection stringConnection = Connection.GetSqlConnection();

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
            string tentk = txtTenTK.Text;
            string hoTen = txtHoten.Text;
            string email = txtEmail.Text;
            string matkhau = txtMatkhau.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = txtSdt.Text;
            string role = comboBxRole.Text; // Assuming role selection is implemented


            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản 6-24 kí tự,chỉ với các kí tự chữ và số, có thể là chữ hoa hoặc chữ thường!"); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu  6-24 kí tự,chỉ với các kí tự chữ và số, có thể là chữ hoa hoặc chữ thường!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if (modify.taiKhoans("Select * from TaoTaiKhoan where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng kí, vui lòng đăng kí email khác!"); return; }
            try
            {
                string query = "Insert into TaoTaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "','" + role + "')";
                string query1 = "Insert into DangNhap values ('" + tentk + "','" + matkhau + "', '" + role + "' )";
                modify.Command(query);
                modify.Command(query1);
                /*if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }*/
                Hide();
                if (role == "Người dùng")
                {
                    FDangNhap Fdangnhap = new FDangNhap();
                    Fdangnhap.ShowDialog();
                }
                else
                {
                    //FDangNhap Fdangnhap = new FDangNhap(); /////////////////// để tamj ở đây
                    //Fdangnhap.ShowDialog();
                    MessageBox.Show("Xin vui lòng chờ xét duyệt từ admin!");
                }

            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí, vui lòng nhập tên tài khoản khác!");
            }

        }
    }
}
