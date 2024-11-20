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
        private int? _MaSanPhamToEdit;

        // Constructor to support editing a specific product
        public ThemSanPham(int MaSanPham)
        {
            InitializeComponent();
            _MaSanPhamToEdit = MaSanPham;

            // Load product data for editing
            LoadProductData(MaSanPham);
        }
        // Method to load product data into the form for editing
        private void LoadProductData(int MaSanPham)
        {
            try
            {
                DBConnection dbConnection = new DBConnection();
                SqlConnection conn = dbConnection.GetConnection();

                string query = "SELECT * FROM SANPHAM WHERE MaSanPham = @MaSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = MaSanPham;

                dbConnection.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtTenSanPham.Text = reader["TenSanPham"].ToString();
                    txtGiaSanPham.Text = reader["GiaSanPham"].ToString();
                    txtChatLieu.Text = reader["ChatLieu"].ToString();
                    txtMoTa.Text = reader["MoTa"].ToString();
                    txtKichThuoc.Text = reader["KichThuoc"].ToString();
                    txtMauSac.Text = reader["MauSac"].ToString();
                    txtSoLuong.Text = reader["SoLuong"].ToString();

                    if (reader["HinhAnh"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])reader["HinhAnh"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            PictureBoxHinhAnhSP.Image = Image.FromStream(ms);
                            PictureBoxHinhAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        PictureBoxHinhAnhSP.Image = null;
                    }
                }
                reader.Close();
                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product: " + ex.Message);
            }
        }

        private System.Windows.Forms.PictureBox HinhAnh;
        public ThemSanPham()
        {
            InitializeComponent();
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
                return null;

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
                    // If editing, use the update procedure
                    cmd = new SqlCommand("proc_SuaSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = _MaSanPhamToEdit.Value;
                }
                else
                {
                    // If adding a new product, MaSanPham will be auto-incremented
                    cmd = new SqlCommand("proc_SuaSanPham", conn);
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

                // Execute the stored procedure
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
                

        

        

       


   

       
       

       