using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DBMS_NoiThat.Entity;
using DBMS_NoiThat.user;
using DBMS_NoiThat.admin;  // Ensure this is added to use QuanlySanPham

namespace DBMS_NoiThat
{
    public partial class QuanLySanPham : Form
    {
        user.DBConnection mydb = new user.DBConnection();
        private SqlConnection conn;

        public QuanLySanPham()
        {

            InitializeComponent();
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);





        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            // Call method to load SANPHAM data into the DataGridView
            RefreshSanPhamData();
            


        }


        private void PictureBoxHinhAnhSP_Click(object sender, EventArgs e)
        {
            // Optionally handle picture box click for other purposes
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            // Open the ThemSanPham form to add a new product
            ThemSanPham form = new ThemSanPham();
            form.ShowDialog();  // Show the form as a dialog so the user can input product data
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (dataGridViewSanPham.SelectedRows.Count > 0)
                {
                    // Get the selected row from the DataGridView
                    DataGridViewRow selectedRow = dataGridViewSanPham.SelectedRows[0];

                    // Retrieve the MaSanPham (Product ID) from the selected row
                    int MaSanPham = Convert.ToInt32(selectedRow.Cells["MaSanPham"].Value);

                    // Ask for confirmation before deleting
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Create a new DBConnection instance
                        DBConnection dbConnection = new DBConnection();
                        SqlConnection conn = dbConnection.GetConnection();

                        // Prepare the SQL command to call the stored procedure
                        SqlCommand cmd = new SqlCommand("proc_XoaSanPham", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameter for the Product ID
                        cmd.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = MaSanPham;

                        // Open the connection and execute the command
                        dbConnection.OpenConnection();
                        int rowsAffected = cmd.ExecuteNonQuery();  // Execute the stored procedure

                        // Check if the deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully!");
                            // Refresh the DataGridView after deletion
                            RefreshSanPhamData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete product.");
                        }

                        dbConnection.CloseConnection();  // Close the connection
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            // Ensure a valid row is selected in the DataGridView
            if (dataGridViewSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewSanPham.SelectedRows[0];

                // Retrieve the MaSanPham (product ID) from the selected row
                int MaSanPham = Convert.ToInt32(selectedRow.Cells["MaSanPham"].Value);

                // Open the ThemSanPham form and load data for editing
                ThemSanPham form = new ThemSanPham();
                form.LoadProductData(MaSanPham);  // Pass the MaSanPham to load product details
                form.ShowDialog();  // Open the form as a dialog
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            // Refresh the data when the reload button is clicked
            RefreshSanPhamData();
        }

        
        // Method to refresh SANPHAM data in the DataGridView
        public void RefreshSanPhamData()
        {
            try
            {
                DBConnection dbConnection = new DBConnection();
                conn = dbConnection.GetConnection();  // Open the connection

                SqlCommand cmd = new SqlCommand("SELECT MaSanPham, TenSanPham, GiaSanPham, ChatLieu, MoTa, KichThuoc, MauSac, SoLuong, HinhAnh FROM SANPHAM", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);  // Fill the DataTable with the data from the database

                dataGridViewSanPham.DataSource = dt; // Bind data

                // Check for null/empty Base64 data in HinhAnh column
                foreach (DataRow row in dt.Rows)
                {
                    string hinhAnhBase64 = row["HinhAnh"].ToString();
                    if (string.IsNullOrEmpty(hinhAnhBase64))
                    {
                        Console.WriteLine("Warning: Image data is empty for product with ID " + row["MaSanPham"]);
                    }
                }

                // Optional: Set custom column headers for better display
                dataGridViewSanPham.Columns["MaSanPham"].HeaderText = "Product ID";
                dataGridViewSanPham.Columns["TenSanPham"].HeaderText = "Product Name";
                dataGridViewSanPham.Columns["GiaSanPham"].HeaderText = "Price";
                dataGridViewSanPham.Columns["ChatLieu"].HeaderText = "Material";
                dataGridViewSanPham.Columns["MoTa"].HeaderText = "Description";
                dataGridViewSanPham.Columns["KichThuoc"].HeaderText = "Size";
                dataGridViewSanPham.Columns["MauSac"].HeaderText = "Color";
                dataGridViewSanPham.Columns["SoLuong"].HeaderText = "Quantity";
                dataGridViewSanPham.Columns["HinhAnh"].Visible = true; // Ensure image column is visible

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadProductImage(int MaSanPham)
        {
            try
            {
                // Create DB connection and command to fetch the image for the selected product
                DBConnection dbConnection = new DBConnection();
                SqlConnection conn = dbConnection.GetConnection();

                SqlCommand cmd = new SqlCommand("SELECT HinhAnh FROM SANPHAM WHERE MaSanPham = @MaSanPham", conn);
                cmd.Parameters.AddWithValue("@MaSanPham", MaSanPham);

                // Open the connection
                dbConnection.OpenConnection();

                // Execute the query and get the image data
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();  // Read the first row
                    string hinhAnhBase64 = reader["HinhAnh"].ToString();  // Get the Base64 string

                    // If there is a Base64 string, convert it to an image and display it
                    if (!string.IsNullOrEmpty(hinhAnhBase64))
                    {
                        byte[] imageBytes = Convert.FromBase64String(hinhAnhBase64);  // Convert Base64 to byte array
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            PictureBoxHinhAnhSP.Image = Image.FromStream(ms);  // Load the image into PictureBox
                            PictureBoxHinhAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;  // Adjust image size to fit the PictureBox
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Image not found for this product.");
                }

                // Close the reader and connection
                reader.Close();
                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if a valid row was clicked
                if (e.RowIndex >= 0)
                {
                    // Get the clicked row
                    DataGridViewRow row = dataGridViewSanPham.Rows[e.RowIndex];

                    // Example: Get data from a specific column (HinhAnh column)
                    string hinhAnhBase64 = row.Cells["HinhAnh"].Value.ToString();

                    // Process and display the image (this is just an example; customize as needed)
                    if (!string.IsNullOrEmpty(hinhAnhBase64))
                    {
                        // Convert Base64 string to image and display it in a PictureBox
                        byte[] imageBytes = Convert.FromBase64String(hinhAnhBase64);
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            PictureBoxHinhAnhSP.Image = Image.FromStream(ms);
                            PictureBoxHinhAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                    else
                    {
                        // Clear the image if no Base64 data is found
                        PictureBoxHinhAnhSP.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the event
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            string searchTerm = txtbTimKiemSP.Text;  // Get the text from the TextBox

            if (!string.IsNullOrEmpty(searchTerm)) // Check if the search term is not empty
            {
                SearchSanPham(searchTerm);  // Call the search function
            }
            else
            {
                MessageBox.Show("Please enter a search term.");
            }
        }
        private void SearchSanPham(string searchTerm)
        {
            try
            {
                // Create connection
                DBConnection dbConnection = new DBConnection();
                SqlConnection conn = dbConnection.GetConnection();

                // Prepare the SQL command to call the function with the search term
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.func_TimKiemSanPham(@TimKiem)", conn);
                cmd.Parameters.AddWithValue("@TimKiem", searchTerm);  // Pass the search term as a parameter

                // Use SqlDataAdapter to fill the DataTable with the result
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);  // Fill the DataTable with the search results

                // Bind the DataTable to the DataGridView to display the search results
                dataGridViewSanPham.DataSource = dt;

                // Close the connection after fetching the data
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

        private void txtbTimKiemSP_TextChanged_1(object sender, EventArgs e)
        {
            string searchTerm = txtbTimKiemSP.Text;  // Get the current text from the TextBox

            if (!string.IsNullOrEmpty(searchTerm))  // Only search if there's something in the TextBox
            {
                SearchSanPham(searchTerm);  // Call the search function
            }
            else
            {
                // Optionally, you can reload all products if the TextBox is cleared
                RefreshSanPhamData();  // Replace with your method to refresh all data
            }
        }

        private void dataGridViewSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }



    

        
    

