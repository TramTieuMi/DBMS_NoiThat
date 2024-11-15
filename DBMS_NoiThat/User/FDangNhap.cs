using DBMS_NoiThat.Entity;

using Do_An_Tuyen_Dung;
using System;
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

namespace DBMS_NoiThat.user
{
    public partial class FDangNhap : Form
    {
        SqlConnection connStr = Connection.GetSqlConnection();
        public FDangNhap()
        {
            InitializeComponent();
        }
        public static string TenDangNhap { get; private set; }
        Modify modify = new Modify();
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string tentk = txtTenTK.Text;
            TenDangNhap = tentk;
            string matkhau = txtMatKhau.Text;

            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM dbo.CheckLogin(@TenDangNhap, @MatKhau)";

                // Sử dụng parameterized query để tránh SQL injection
                using (SqlConnection connection = new SqlConnection(connStr.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenDangNhap", tentk);
                        command.Parameters.AddWithValue("@MatKhau", matkhau);
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                }

                if (dt.Rows.Count != 0)
                {
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (DataRow row in dt.Rows)
                    {
                        string ten = row["TenDangNhap"].ToString();
                        int role = Convert.ToInt32(row["RoleID"]);

                        if (role == 2)
                        {
                            MainFormKhachHang mainForm = new MainFormKhachHang(ten);
                            mainForm.ShowDialog();
                        }
                        else
                        {
                            MainFormAdmin mainForm = new MainFormAdmin(ten);
                            mainForm.ShowDialog();
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
