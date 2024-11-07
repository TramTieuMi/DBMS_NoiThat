using DBMS_NoiThat.user;
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

namespace DBMS_NoiThat.user9
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
            int maKhachHang = (int)cmd.ExecuteScalar();
            conn.CloseConnection();
           // MessageBox.Show(maKhachHang.ToString());
            try
            {
                XemSanPhamForm xemSanPhamForm = new XemSanPhamForm();
                xemSanPhamForm.idKhachHang= maKhachHang;
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
                if (currentFormChild != null)
                {
                    currentFormChild.Close();
                }
                currentFormChild = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
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
            hello.Text = $"Welcome {tenTaiKhoan} to our website";
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

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLSMH_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new FLichSu());
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
