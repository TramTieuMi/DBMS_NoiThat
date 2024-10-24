using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public MainFormKhachHang()
        {
            InitializeComponent();
            try
            {
                OpenChildForm(new XemSanPhamForm());
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

        

        private void labelMenu_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new XemSanPhamForm());
                // labelHome.Text = buttonQLNV.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainFormKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
