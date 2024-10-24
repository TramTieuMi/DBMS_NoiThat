using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Do_An_Tuyen_Dung
{
    public partial class FCreateAccount : Form
    {
        SqlConnection stringConnection = Connection.GetSqlConnection();

        public FCreateAccount()
        {
            InitializeComponent();

        }

        private void FCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox_MatKhau.Text;
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string email = textBox_Email.Text;
            string matkhau = textBox_MatKhau.Text;
            //DateTime dob = DateTimePicker.Text;
            string role = ComboBox_Role.Text; // Assuming role selection is implemented


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
                //if (role == "Admin")
                //{
                //    F_DangKiTaiKhoanNTD f_DangKiTaiKhoanNTD = new F_DangKiTaiKhoanNTD();
                //    f_DangKiTaiKhoanNTD.ShowDialog();
                //}
                //else
                //{
                //    FNhapThongTin_UV fNhapThongTinUV = new FNhapThongTin_UV();
                //    fNhapThongTinUV.ShowDialog();
                //}

                //////////////////////////////////////////////////////////////////////////////////////////////////dang lam 
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí, vui lòng nhập tên tài khoản khác!");
            }




        }

        private void ComboBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FCreateAccount_Load_1(object sender, EventArgs e)
        {

        }
    }
}
