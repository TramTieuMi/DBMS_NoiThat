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

namespace DBMS_NoiThat.admin
{
    public partial class LoyaltyCustomerAdmin : Form
    {
        private user.DBConnection mydb = new user.DBConnection();

        public LoyaltyCustomerAdmin()
        {
            InitializeComponent();
            DisplayCustomerData();  // Call method to load customer data into DataGridView

            // Set the background of the form to light gray or a gradient
            this.BackColor = Color.LightSkyBlue;
            this.Font = new Font("Segoe UI", 10);

            // Customize all elements
            CustomizeTextBox(txtCustomerId);
           
            CustomizeButton(btnRefresh);
            CustomizePictureBox(pbRewardImage);

            // Align labels with appropriate font and color
            lblCustomerId.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblCustomerId.ForeColor = Color.Green;

            lblCustomerName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblCustomerName.ForeColor = Color.Green;

            lblLoyaltyTier.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblLoyaltyTier.ForeColor = Color.Green;
        }

        private void CustomizeButton(Button btn)
        {
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            btn.MouseEnter += (sender, e) => { btn.BackColor = Color.Green; };
            btn.MouseLeave += (sender, e) => { btn.BackColor = Color.Green; };
        }

        private void CustomizeTextBox(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.BorderStyle = BorderStyle.FixedSingle; // Add a visible border
            txt.Font = new Font("Segoe UI", 12);
            txt.Padding = new Padding(10);
            txt.Width = 130; // Increase width for visibility
            txt.Height = 40; // Increase height for better access
            
        }

        private void CustomizePictureBox(PictureBox pb)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.BackColor = Color.LightGray;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Padding = new Padding(10);
        }

        private void LoyaltyCustomer_Load(object sender, EventArgs e)
        {

        }


        // Method to get customer details
        // Method to get customer details by customer ID (int)
        private void GetCustomerDetails(int customerId)
        {
            try
            {
                string query = "SELECT MaKhachHang, HoVaTen, LoyaltyTier FROM KHACHHANG WHERE MaKhachHang = @MaKhachHang";
                SqlCommand command = new SqlCommand(query, mydb.GetConnection());
                command.Parameters.AddWithValue("@MaKhachHang", customerId);

                mydb.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lblCustomerName.Text = reader["HoVaTen"].ToString();
                    lblLoyaltyTier.Text = reader["LoyaltyTier"].ToString();
                    lblCustomerId.Text = reader["MaKhachHang"].ToString();

                    // Update reward image
                    DisplayRewardImage(reader["LoyaltyTier"].ToString());

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching customer details: {ex.Message}");
            }
            finally
            {
                mydb.CloseConnection();
            }
        }

        // Method to get customer details by customer name (string)
        private void GetCustomerDetails(string customerName)
        {
            try
            {
                string query = "SELECT MaKhachHang, HoVaTen, LoyaltyTier FROM KHACHHANG WHERE HoVaTen LIKE @HoVaTen";
                SqlCommand command = new SqlCommand(query, mydb.GetConnection());
                command.Parameters.AddWithValue("@HoVaTen", "%" + customerName + "%");

                mydb.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lblCustomerName.Text = reader["HoVaTen"].ToString();
                    lblLoyaltyTier.Text = reader["LoyaltyTier"].ToString();
                    lblCustomerId.Text = reader["MaKhachHang"].ToString();

                    // Update reward image
                    DisplayRewardImage(reader["LoyaltyTier"].ToString());

                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching customer details: {ex.Message}");
            }
            finally
            {
                mydb.CloseConnection();
            }
        }

        // Method to update loyalty tier
        private void UpdateLoyaltyTier(int customerId)
        {
            try
            {
                // Check current loyalty tier
                string tierCheckQuery = "SELECT LoyaltyTier FROM KHACHHANG WHERE MaKhachHang = @MaKhachHang";
                SqlCommand checkCommand = new SqlCommand(tierCheckQuery, mydb.GetConnection());
                checkCommand.Parameters.AddWithValue("@MaKhachHang", customerId);

                mydb.OpenConnection();
                object result = checkCommand.ExecuteScalar();
                mydb.CloseConnection();

                if (result == null)
                {
                    MessageBox.Show("Customer not found.");
                    return;
                }

                string currentTier = result.ToString();

                // Check if the customer has reached the maximum tier or if they already received this tier's reward
                if (currentTier == "Gold") // Assuming 'Gold' is the maximum tier
                {
                    MessageBox.Show("Customer is already at the highest loyalty tier.");
                    return;
                }

                if (HasAlreadyReceivedReward(customerId, currentTier))
                {
                    MessageBox.Show($"Customer has already received the reward for {currentTier} tier.");
                    return;
                }

                // Update loyalty tier if eligible
                string updateQuery = "EXEC dbo.UpdateLoyaltyTier @MaKhachHang";
                SqlCommand updateCommand = new SqlCommand(updateQuery, mydb.GetConnection());
                updateCommand.Parameters.AddWithValue("@MaKhachHang", customerId);

                mydb.OpenConnection();
                updateCommand.ExecuteNonQuery();
                mydb.CloseConnection();

                MessageBox.Show("Loyalty tier updated successfully.");
                RecordRewardGiven(customerId, currentTier); // Record that the reward has been given
                GetCustomerDetails(customerId); // Refresh customer details
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating loyalty tier: {ex.Message}");
            }
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string input = txtCustomerId.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out int customerId)) // Input is numeric
                {
                    GetCustomerDetails(customerId);
                }
                else // Input is string (customer name)
                {
                    GetCustomerDetails(input);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Customer ID or Name.");
            }
        }
        // Check if the reward for the current tier has already been given
        private bool HasAlreadyReceivedReward(int customerId, string currentTier)
        {
            try
            {
                // Query the DONHANG table to check if the customer has already received a reward for this tier
                string query = @"
            SELECT COUNT(*) 
            FROM DONHANG 
            WHERE MaKhachHang = @MaKhachHang AND LoyaltyTier = @LoyaltyTier";

                SqlCommand command = new SqlCommand(query, mydb.GetConnection());
                command.Parameters.AddWithValue("@MaKhachHang", customerId);
                command.Parameters.AddWithValue("@LoyaltyTier", currentTier);

                mydb.OpenConnection();
                int count = (int)command.ExecuteScalar();
                mydb.CloseConnection();

                return count > 0;  // Return true if the reward has been received already
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking reward status: {ex.Message}");
                return false;
            }
        }
        // Record that a reward has been given for the current tier
        private void RecordRewardGiven(int customerId, string currentTier)
        {
            try
            {
                // Insert into the DONHANG table when the reward is given
                string query = "INSERT INTO DONHANG (MaKhachHang, LoyaltyTier, DateGiven) VALUES (@MaKhachHang, @LoyaltyTier, @DateGiven)";
                SqlCommand command = new SqlCommand(query, mydb.GetConnection());
                command.Parameters.AddWithValue("@MaKhachHang", customerId);
                command.Parameters.AddWithValue("@LoyaltyTier", currentTier);
                command.Parameters.AddWithValue("@DateGiven", DateTime.Now);

                mydb.OpenConnection();
                command.ExecuteNonQuery();
                mydb.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording reward: {ex.Message}");
            }
        }

        private void DisplayRewardImage(string loyaltyTier)
        {
            try
            {
                // Define paths for reward images (adjust these paths based on your project structure)
                string imagePath = Application.StartupPath + "\\Images\\"; // Example: Store images in an "Images" folder

                string imageFile;
                switch (loyaltyTier)
                {
                    case "Bronze":
                        imageFile = "Bronze.png";
                        break;
                    case "Silver":
                        imageFile = "Silver.png";
                        break;
                    case "Gold":
                        imageFile = "Gold.png";
                        break;
                    default:
                        imageFile = "Default.png"; // Default image for undefined tiers
                        break;
                }

                // Full path to the image
                string fullPath = imagePath + imageFile;

                // Check if the file exists and set the PictureBox image
                if (System.IO.File.Exists(fullPath))
                {
                    pbRewardImage.Image = Image.FromFile(fullPath);
                    pbRewardImage.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust to fit the PictureBox
                }
                else
                {
                    MessageBox.Show($"Image not found: {fullPath}");
                    pbRewardImage.Image = null; // Clear the PictureBox if the image is missing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying reward image: {ex.Message}");
            }
        }
        private void RedeemReward(int customerId)
        {
            try
            {
                // Get the current loyalty tier of the customer
                string tierQuery = "SELECT LoyaltyTier FROM KHACHHANG WHERE MaKhachHang = @MaKhachHang";
                SqlCommand tierCommand = new SqlCommand(tierQuery, mydb.GetConnection());
                tierCommand.Parameters.AddWithValue("@MaKhachHang", customerId);

                mydb.OpenConnection();
                object result = tierCommand.ExecuteScalar();
                mydb.CloseConnection();

                if (result == null)
                {
                    MessageBox.Show("Customer not found.");
                    return;
                }

                string currentTier = result.ToString();

                // Check if the reward for the current tier has already been redeemed
                if (HasAlreadyReceivedReward(customerId, currentTier))
                {
                    MessageBox.Show($"Customer has already redeemed the reward for the {currentTier} tier.");
                    return;
                }

                // If not, update the reward status and give the reward
                RecordRewardGiven(customerId, currentTier);  // Log the redemption

                // Optionally, you could update the tier (if necessary) here:
                // UpdateLoyaltyTier(customerId);  // Uncomment this if you want to promote the customer after redemption

                MessageBox.Show($"Reward for {currentTier} tier successfully redeemed!");
                GetCustomerDetails(customerId); // Refresh customer details and display updated info
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error redeeming reward: {ex.Message}");
            }
        }

        
        private void DisplayCustomerData()
        {
            try
            {
                // Query to fetch customer details from KHACHHANG table
                string query = "SELECT MaKhachHang, HoVaTen, LoyaltyTier FROM KHACHHANG";
                SqlCommand command = new SqlCommand(query, mydb.GetConnection());

                mydb.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                // Create a DataTable to hold the customer data
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CustomerId", typeof(int));
                dataTable.Columns.Add("CustomerName", typeof(string));
                dataTable.Columns.Add("LoyaltyTier", typeof(string));
                dataTable.Columns.Add("RewardImage", typeof(Image));  // Column for image

                // Loop through the data reader and fill the DataTable
                while (reader.Read())
                {
                    // Retrieve customer details
                    int customerId = Convert.ToInt32(reader["MaKhachHang"]);
                    string customerName = reader["HoVaTen"].ToString();
                    string loyaltyTier = reader["LoyaltyTier"].ToString();

                    // Load the reward image for the corresponding loyalty tier
                    Image rewardImage = GetRewardImage(loyaltyTier);

                    // Add the row to the DataTable
                    dataTable.Rows.Add(customerId, customerName, loyaltyTier, rewardImage);
                }

                reader.Close();
                mydb.CloseConnection();

                // Bind the DataTable to the DataGridView
                dataGridViewCustomers.DataSource = dataTable;

                // Optional: Adjust the column sizes for better visibility
                dataGridViewCustomers.Columns["RewardImage"].Width = 100;  // Adjust image column width
                dataGridViewCustomers.Columns["CustomerId"].Visible = false; // Hide CustomerId column if not needed
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying customer data: {ex.Message}");
            }
        }
        // Method to load the reward image based on the loyalty tier
        private Image GetRewardImage(string loyaltyTier)
        {
            try
            {
                // Define paths for reward images (adjust these paths based on your project structure)
                string imagePath = Application.StartupPath + "\\Images\\"; // Example: Store images in an "Images" folder

                string imageFile;
                switch (loyaltyTier)
                {
                    case "Bronze":
                        imageFile = "Bronze.png";
                        break;
                    case "Silver":
                        imageFile = "Silver.png";
                        break;
                    case "Gold":
                        imageFile = "Gold.png";
                        break;
                    default:
                        imageFile = "Default.png"; // Default image for undefined tiers
                        break;
                }

                // Full path to the image
                string fullPath = imagePath + imageFile;

                // Check if the file exists and return the image
                if (System.IO.File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
                else
                {
                    MessageBox.Show($"Image not found: {fullPath}");
                    return null; // Return null if image is missing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reward image: {ex.Message}");
                return null;
            }
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a valid row (not header)
            if (e.RowIndex >= 0)
            {
                // Get the customer ID (MaKhachHang) from the selected row
                int customerId = Convert.ToInt32(dataGridViewCustomers.Rows[e.RowIndex].Cells["CustomerId"].Value);

                // Fetch the customer details including loyalty tier and set the image in the PictureBox
                GetCustomerDetails(customerId);  // This will update the label and image in pbRewardImage
            }
        }
    }
}
