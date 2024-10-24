using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Do_An_Tuyen_Dung
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide();
           // FCreateAccount createAcc = new FCreateAccount();
            //createAcc.ShowDialog();
        }


        Modify modify = new Modify();
        public static string TenTaiKhoan { get; private set; }
        //private void guna2Button1_Click(object sender, EventArgs e)
        //{


        //    string tentk = txtBoxUser.Text;
        //    TenTaiKhoan = tentk;
        //    string matkhau = txtBoxPassword.Text;
        //    if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
        //    else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
        //    else
        //    {
        //        DataTable dt = new DataTable();
        //        string query = "Select * from DangNhap where tenTaiKhoan = '" + tentk + "' and matKhau = '" + matkhau + "'";
        //        string query1 = "SELECT TenTaiKhoan,role FROM TaoTaiKhoan Where TenTaiKhoan = @TenTaiKhoan";
        //        modify.TaiDuLieu(dt, query1, "@TenTaiKhoan", txtBoxUser.Text);
        //        if (modify.taiKhoans(query).Count != 0)
        //        {
        //            this.Hide();
        //            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            foreach (DataRow row in dt.Rows)
        //            {

        //                string ten = row["TenTaiKhoan"].ToString();
        //                if (ten == txtBoxUser.Text)
        //                {

        //                    string role = row["role"].ToString();
        //                    if (role == "Nha Tuyen Dung")
        //                    {
        //                        FLogin flogin = new FLogin();
        //                        FDangBai_NTD dangbai = new FDangBai_NTD();
        //                        dangbai.ShowDialog();
        //                        break;
        //                    }
        //                    else
        //                    {
        //                        FLogin flogin = new FLogin();
        //                        FUngVien.FMenu UVMenu = new FUngVien.FMenu();
        //                        UVMenu.ShowDialog();

        //                        break;
        //                    }
        //                }
        //            }
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //    }

        //}
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        //private void label1_Click(object sender, EventArgs e)
        //{
        //    FForgotPassword forgotAcc = new FForgotPassword();
        //    forgotAcc.ShowDialog();
        //}

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true) 
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
