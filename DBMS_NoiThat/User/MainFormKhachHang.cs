using DBMS_NoiThat.admin;
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
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    public partial class MainFormKhachHang : Form
    {
        DBConnection conn = new DBConnection();
        private int maKhachHang;

        private string tenTaiKhoan;

        public MainFormKhachHang(string tenTaiKhoan)
        {
            InitializeComponent();
            this.tenTaiKhoan = tenTaiKhoan;

            conn.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT dbo.GetMaKhachHang(@TenDangNhap)", conn.GetConnection());
            cmd.Parameters.AddWithValue("@TenDangNhap", tenTaiKhoan);
            maKhachHang = (int)cmd.ExecuteScalar();
            conn.CloseConnection();
            // MessageBox.Show(maKhachHang.ToString());
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            try
            {
                XemSanPhamForm xemSanPhamForm = new XemSanPhamForm();
                xemSanPhamForm.idKhachHang = maKhachHang;
                OpenChildForm(xemSanPhamForm);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            try
            {
                // Đóng form con hiện tại nếu có
                if (currentFormChild != null)
                {
                    currentFormChild.Close();
                }
                currentFormChild = childForm;

                // Thiết lập thuộc tính cho form con
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;

                // Đặt DockStyle.Fill để form con chiếm toàn bộ diện tích của panel_Body
                childForm.Dock = DockStyle.Fill;

                // Thêm form con vào panel_Body và hiển thị
                panel_Body.Controls.Add(childForm);
                panel_Body.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonTTCN_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new XemThongTinUser());
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonGioHang_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new GioHang(maKhachHang));
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
            try
            {
                XemSanPhamForm xemSanPhamForm = new XemSanPhamForm();
                xemSanPhamForm.idKhachHang = maKhachHang;
                OpenChildForm(xemSanPhamForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MainFormKhachHang_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            hello.Text = $"Welcome {tenTaiKhoan} to our website";
            //te.Text = $"Welcome {maKhachHang} to our website";

        }

        private void buttonLSMH_Click(object sender, EventArgs e)
        {
            try
            {
                //FLichSu lichSuForm = new FLichSu(this.tenTaiKhoan);
                OpenChildForm(new FLichSu(tenTaiKhoan));
                // labelHome.Text = buttonQLNV.Text;

                //lichSuForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
                labelTime.Text = DateTime.Now.ToLongTimeString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_Chat_Click(object sender, EventArgs e)
        {
            string email = string.Empty;

            SqlCommand cmd = new SqlCommand("sp_LayEmailTheoMaKhachHang", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            // Thêm tham số đầu vào cho MaKhachHang
            cmd.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

            // Thêm tham số đầu ra cho Email
            SqlParameter emailParam = new SqlParameter("@Email", SqlDbType.VarChar, 255)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(emailParam);

            // Mở kết nối và thực hiện thủ tục
            conn.OpenConnection();
            cmd.ExecuteNonQuery();
            

            // Lấy giá trị của tham số đầu ra
            email = emailParam.Value as string;

            using (SqlCommand cmd1 = new SqlCommand("sp_CapNhatTrangThai_user", conn.GetConnection()))
            {
                cmd1.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục
                cmd1.Parameters.AddWithValue("@Email", email);

                // Mở kết nối và thực thi thủ tục
                cmd1.ExecuteNonQuery();
            }
            conn.CloseConnection();
            OpenChildForm(new ChatBoxUser(email));
        }
    }
}
