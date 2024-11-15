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
        private int? _MaSanPhamToEdit = null; // This will hold the ID of the product to edit, if applicable

        public ThemSanPham()
        {
            InitializeComponent();
        }

        // Method to load data when editing a product
        public void LoadProductData(int MaSanPham)
        {
            _MaSanPhamToEdit = MaSanPham;

            try
            {
                DBConnection dbConnection = new DBConnection();
                SqlConnection conn = dbConnection.GetConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM SANPHAM WHERE MaSanPham = @MaSanPham", conn);
                cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                   
                    txtTenSanPham.Text = row["TenSanPham"].ToString();
                    txtGiaSanPham.Text = row["GiaSanPham"].ToString();
                    txtChatLieu.Text = row["ChatLieu"].ToString();
                    txtMoTa.Text = row["MoTa"].ToString();
                    txtKichThuoc.Text = row["KichThuoc"].ToString();
                    txtMauSac.Text = row["MauSac"].ToString();
                    txtSoLuong.Text = row["SoLuong"].ToString();

                    // If the image is stored as Base64, decode and display it
                    string hinhAnhBase64 = row["HinhAnh"].ToString();
                    if (!string.IsNullOrEmpty(hinhAnhBase64))
                    {
                        byte[] imageBytes = Convert.FromBase64String(hinhAnhBase64);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            PictureBoxHinhAnhSP.Image = Image.FromStream(ms);
                            PictureBoxHinhAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message);
            }
        }

        private void btnThemSP_Click_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the input fields
                if (string.IsNullOrWhiteSpace(txtTenSanPham.Text) || string.IsNullOrWhiteSpace(txtGiaSanPham.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Collect data from form controls
                string TenSanPham = txtTenSanPham.Text;

                // Convert image to Base64 string
                string HinhAnhBase64 = ConvertImageToBase64(PictureBoxHinhAnhSP.Image);

                decimal GiaSanPham;
                if (!decimal.TryParse(txtGiaSanPham.Text, out GiaSanPham))
                {
                    MessageBox.Show("Invalid price.");
                    return;
                }

                string ChatLieu = txtChatLieu.Text;
                string MoTa = txtMoTa.Text;
                string KichThuoc = txtKichThuoc.Text;
                string MauSac = txtMauSac.Text;

                int SoLuong;
                if (!int.TryParse(txtSoLuong.Text, out SoLuong))
                {
                    MessageBox.Show("Invalid quantity.");
                    return;
                }

                DBConnection dbConnection = new DBConnection();
                SqlConnection conn = dbConnection.GetConnection();

                SqlCommand cmd;

                if (_MaSanPhamToEdit.HasValue) // If we are editing an existing product
                {
                    cmd = new SqlCommand("proc_SuaSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters for the stored procedure (including MaSanPham to edit the product)
          
                    cmd.Parameters.Add("@TenSanPham", SqlDbType.NVarChar, 100).Value = TenSanPham;
                    cmd.Parameters.Add("@HinhAnh", SqlDbType.NVarChar).Value = HinhAnhBase64;
                    cmd.Parameters.Add("@GiaSanPham", SqlDbType.Decimal).Value = GiaSanPham;
                    cmd.Parameters.Add("@ChatLieu", SqlDbType.NVarChar, 50).Value = ChatLieu;
                    cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = MoTa;
                    cmd.Parameters.Add("@KichThuoc", SqlDbType.NVarChar, 50).Value = KichThuoc;
                    cmd.Parameters.Add("@MauSac", SqlDbType.NVarChar, 50).Value = MauSac;
                    cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                }
                else // If we are adding a new product
                {
                    cmd = new SqlCommand("proc_ThemSanPham", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Do not add MaSanPham, as it is auto-generated by the database
                    cmd.Parameters.Add("@TenSanPham", SqlDbType.NVarChar, 100).Value = TenSanPham;
                    cmd.Parameters.Add("@HinhAnh", SqlDbType.NVarChar).Value = HinhAnhBase64;
                    cmd.Parameters.Add("@GiaSanPham", SqlDbType.Decimal).Value = GiaSanPham;
                    cmd.Parameters.Add("@ChatLieu", SqlDbType.NVarChar, 100).Value = ChatLieu;
                    cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = MoTa;
                    cmd.Parameters.Add("@KichThuoc", SqlDbType.NVarChar, 50).Value = KichThuoc;
                    cmd.Parameters.Add("@MauSac", SqlDbType.NVarChar, 50).Value = MauSac;
                    cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                }

                dbConnection.OpenConnection();

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

        // Helper method to convert image to Base64 string
        private string ConvertImageToBase64(Image image)
        {
            if (image == null) return string.Empty;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);  // Save the image in its original format
                byte[] imageBytes = ms.ToArray();  // Convert image to byte array
                return Convert.ToBase64String(imageBytes);  // Convert byte array to Base64 string
            }
        }

        private void btnThemAnh_Click_Click(object sender, EventArgs e)
        {
            try
            {
                // Create OpenFileDialog to let the user choose an image
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

                // If the user selects an image and clicks OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox
                    PictureBoxHinhAnhSP.Image = Image.FromFile(openFileDialog.FileName);
                    PictureBoxHinhAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;  // Adjust image size in the PictureBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnXoaAnh_Click_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset the image in the PictureBox
                PictureBoxHinhAnhSP.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Helper method to clear the form fields after successful addition or update
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

            _MaSanPhamToEdit = null; // Reset the edit flag
        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click_Click(object sender, EventArgs e)
        {
            // Close the ThemSanPham form
            this.Close();

            // Show the QuanLySanPham form
            QuanLySanPham quanLySanPhamForm = new QuanLySanPham();
            quanLySanPhamForm.Show();
        }
    }
}