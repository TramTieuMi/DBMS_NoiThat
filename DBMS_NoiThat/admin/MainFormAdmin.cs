using DBMS_NoiThat.admin;
using DBMS_NoiThat.admin;
using DBMS_NoiThat.Entity;
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
    public partial class MainFormAdmin : Form
    {
        DBConnection conn = new DBConnection();
        private string tenTaiKhoan;
        public MainFormAdmin()
        {
            InitializeComponent();
        }
        public MainFormAdmin(string tenTaiKhoan)
        {

            InitializeComponent();
            this.tenTaiKhoan = tenTaiKhoan;

            conn.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT dbo.GetMaKhachHang(@TenDangNhap)", conn.GetConnection());
            cmd.Parameters.AddWithValue("@TenDangNhap", tenTaiKhoan);
            int maKhachHang = (int)cmd.ExecuteScalar();
            conn.CloseConnection();
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            hello.Text = "Welcome "+tenTaiKhoan.ToString();
            hello.Show();
            // MessageBox.Show(maKhachHang.ToString());
            //try
            //{
            //    XemSanPhamForm xemSanPhamForm = new XemSanPhamForm();
            //    xemSanPhamForm.idKhachHang = maKhachHang;
            //    OpenChildForm(xemSanPhamForm);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
       
        private void buttonQLDH_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new QuanLyDonHangForm());
                // labelHome.Text = buttonQLNV.Text;
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
        private void CloseChildForm()
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                panel_Body.Controls.Remove(currentFormChild);
                currentFormChild = null;
            }
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            CloseChildForm();
        }

        private void labelMenu_Click(object sender, EventArgs e)
        {
           CloseChildForm();
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

        private void buttonThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new ThongKeDoanhThu());
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ChatBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChatBoxAdmin());
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDangNhap dangNhap = new FDangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void buttonSP_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new QuanLySanPham());
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQLTT_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new QuanLyTaiKhoan());
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new FNhacNho());
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DisCount());
        }

        private void btnLoyalCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new LoyaltyCustomerAdmin());
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
