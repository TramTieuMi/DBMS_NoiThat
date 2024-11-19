using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_NoiThat.user;


namespace DBMS_NoiThat.admin
{
    public partial class ThemSanPham : Form
    {
        private int? _MaSanPhamToEdit = null; // To store the product ID when editing
        private System.Windows.Forms.PictureBox HinhAnh;
        public ThemSanPham()
        {
            InitializeComponent();
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChatLieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKichThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMauSac_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSP_Click_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the input fields
                if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaSanPham.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Collect data from form controls
                string TenSanPham = txtTenSanPham.Text;
                decimal GiaSanPham;
                if (!decimal.TryParse(txtGiaSanPham.Text, out GiaSanPham))
                {
                    MessageBox.Show("Invalid price format.");
                    return;
                }

                string ChatLieu = txtChatLieu.Text;
                string MoTa = txtMoTa.Text;
                string KichThuoc = txtKichThuoc.Text;
                string MauSac = txtMauSac.Text;

                int SoLuong;
                if (!int.TryParse(txtSoLuong.Text, out SoLuong))
                {
                    MessageBox.Show("Invalid quantity format.");
                    return;
                }

                // Convert the image to a byte array
                byte[] HinhAnh = ConvertImageToByteArray(PictureBoxHinhAnhSP.Image);

                DBConnection dbConnection = new DBConnection();
                SqlConnection conn = dbConnection.GetConnection();
                SqlCommand cmd;

                // Check if we are editing an existing product or adding a new one
                if (_MaSanPhamToEdit.HasValue)
                {
                    cmd = new SqlCommand("proc_SuaSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = _MaSanPhamToEdit.Value;
                }
                else
                {
                    cmd = new SqlCommand("proc_ThemSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                // Add parameters for the stored procedure
                cmd.Parameters.Add("@TenSanPham", SqlDbType.NVarChar, 100).Value = TenSanPham;
                cmd.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = (object)HinhAnh ?? DBNull.Value;
                cmd.Parameters.Add("@GiaSanPham", SqlDbType.Decimal).Value = GiaSanPham;
                cmd.Parameters.Add("@ChatLieu", SqlDbType.NVarChar, 100).Value = ChatLieu;
                cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = MoTa;
                cmd.Parameters.Add("@KichThuoc", SqlDbType.NVarChar, 50).Value = KichThuoc;
                cmd.Parameters.Add("@MauSac", SqlDbType.NVarChar, 50).Value = MauSac;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;

                dbConnection.OpenConnection();

                // Execute the query
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(_MaSanPhamToEdit.HasValue ? "Product updated successfully!" : "Product added successfully!");
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to save product.");
                }

                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHuy_Click_Click(object sender, EventArgs e)
        {
            // Clear the form and reset the editing state
            ClearFormFields();
        }

        private void btnThemAnh_Click_Click(object sender, EventArgs e)
        {
            try
            {
                // Open file dialog to choose an image
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load selected image into PictureBox
                    PictureBoxHinhAnhSP.Image = Image.FromFile(openFileDialog.FileName);
                    PictureBoxHinhAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        

        private void btnXoaAnh_Click_Click(object sender, EventArgs e)
        {
            // Clear the selected image in PictureBox
            PictureBoxHinhAnhSP.Image = null;
        }

        private void ClearFormFields()
        {
            txtTenSanPham.Clear();
            txtGiaSanPham.Clear();
            txtChatLieu.Clear();
            txtMoTa.Clear();
            txtKichThuoc.Clear();
            txtMauSac.Clear();
            txtSoLuong.Clear();
            PictureBoxHinhAnhSP.Image = null;
            _MaSanPhamToEdit = null;
        }
     }
} 
                

        

        

       


   

       
       

       