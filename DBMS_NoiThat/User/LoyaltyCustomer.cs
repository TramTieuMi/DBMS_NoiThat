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

namespace DBMS_NoiThat.user
{
    public partial class LoyaltyCustomer : Form
    {
        private user.DBConnection mydb = new user.DBConnection();
        public LoyaltyCustomer()
        {
            InitializeComponent();

            // Set the background of the form to light gray or a gradient
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 10);

            // Customize all elements
            CustomizeTextBox(txtCustomerId);
            CustomizeButton(btnRedeemReward);
            CustomizeButton(btnRefresh);
            CustomizePictureBox(pbRewardImage);

            // Align labels with appropriate font and color
            lblCustomerId.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblCustomerId.ForeColor = Color.FromArgb(0, 120, 215);

            lblCustomerName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblCustomerName.ForeColor = Color.FromArgb(0, 120, 215);

            lblLoyaltyTier.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblLoyaltyTier.ForeColor = Color.Green;
        }

        private void CustomizeButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 120, 215);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            btn.MouseEnter += (sender, e) => { btn.BackColor = Color.FromArgb(0, 100, 180); };
            btn.MouseLeave += (sender, e) => { btn.BackColor = Color.FromArgb(0, 120, 215); };
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
        private int GetCustomerDetails(object input)
        {
            try
            {
                string query;
                SqlCommand command;

                if (input is int customerIdInput) // Input is Customer ID
                {
                    query = "SELECT MaKhachHang, HoVaTen, LoyaltyTier FROM KHACHHANG WHERE MaKhachHang = @MaKhachHang";
                    command = new SqlCommand(query, mydb.GetConnection());
                    command.Parameters.AddWithValue("@MaKhachHang", customerIdInput);
                }
                else if (input is string customerName) // Input is Customer Name
                {
                    query = "SELECT MaKhachHang, HoVaTen, LoyaltyTier FROM KHACHHANG WHERE HoVaTen = @HoVaTen";
                    command = new SqlCommand(query, mydb.GetConnection());
                    command.Parameters.AddWithValue("@HoVaTen", customerName);
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid Customer ID or Name.");
                    return -1;  // Return -1 if no valid input is found
                }

                mydb.OpenConnection();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieve customer details
                    lblCustomerName.Text = reader["HoVaTen"].ToString();
                    lblLoyaltyTier.Text = reader["LoyaltyTier"].ToString();
                    lblCustomerId.Text = reader["MaKhachHang"].ToString();

                    // Store the customer ID before closing the reader
                    int customerIdFromDb = Convert.ToInt32(reader["MaKhachHang"]);

                    // Display the reward image
                    DisplayRewardImage(reader["LoyaltyTier"].ToString());

                    // Ensure the reader is closed after processing
                    reader.Close();

                    return customerIdFromDb;  // Return the customer ID after the reader is closed
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                    reader.Close();  // Close the reader if no customer is found
                    return -1;  // Return -1 if customer not found
                }

                mydb.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching customer details: {ex.Message}");
                return -1;
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

        private void btnRedeemReward_Click(object sender, EventArgs e)
        {
            string input = txtCustomerId.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                int customerId;

                if (int.TryParse(input, out customerId)) // Input is numeric (Customer ID)
                {
                    RedeemReward(customerId);
                }
                else // Input is string (Customer Name)
                {
                    customerId = GetCustomerDetails(input);  // Get Customer ID based on name

                    if (customerId != -1)  // If customer ID is valid
                    {
                        RedeemReward(customerId);  // Redeem reward using the customer ID
                    }
                    else
                    {
                        MessageBox.Show("Customer not found. Please check the name and try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a Customer ID or Name.");
            }
        }

    }
}
