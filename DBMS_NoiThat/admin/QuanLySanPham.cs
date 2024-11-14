using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace DBMS_NoiThat.admin
{
    public partial class QuanLySanPham : Form
    {
        user.DBConnection mydb = new user.DBConnection();
        public QuanLySanPham()
        {

            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {

        }

        private void PictureBoxHinhAnhSP_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                if ((open.ShowDialog() == DialogResult.OK))
                {
                    PictureBoxHinhAnhSP.Image = Image.FromFile(open.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            
        }

        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(LableIDSP.Text);
            int id = 1;
            MemoryStream picture = new MemoryStream();
            PictureBoxHinhAnhSP.Image.Save(picture, PictureBoxHinhAnhSP.Image.RawFormat);
            SqlCommand command = new SqlCommand("UPDATE SANPHAM SET HinhAnh=@pic WHERE MaSanPham=@ID", mydb.GetConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.OpenConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.CloseConnection();

            }
            else
            {
                mydb.CloseConnection();

            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {

        }
    }
}
