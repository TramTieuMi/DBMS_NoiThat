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
using Do_An_Tuyen_Dung;
using DBMS_NoiThat.user;

namespace DBMS_NoiThat.admin
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // Call LoadData when the form loads
            LoadRoles();
        }

        private void LoadRoles()
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    string query = "SELECT RoleID, RoleName FROM ROLE";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbRole.DisplayMember = "RoleName";  // Display role names (e.g., Admin, User)
                    cmbRole.ValueMember = "RoleID";      // Use RoleID as value
                    cmbRole.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message);
            }
        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            // Get the input values from form controls
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Get the selected Role ID from the ComboBox
            int roleId = (cmbRole.SelectedValue != null) ? (int)cmbRole.SelectedValue : 0;
            if (roleId == 0)
            {
                MessageBox.Show("Vui lòng chọn vai trò.");
                return;
            }

            // Prepare the SQL query to insert the new account
            string query = "INSERT INTO TAIKHOAN (TenDangNhap, MatKhau, Email, RoleID) VALUES (@TenDangNhap, @MatKhau, @Email, @RoleID)";

            // Use the DBConnection class to manage database connection
            DBConnection dbConnection = new DBConnection();
            dbConnection.OpenConnection(); // Open the connection
            SqlConnection conn = dbConnection.GetConnection(); // Get the connection

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);  // Use the plain password
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@RoleID", roleId);  // Add RoleID parameter

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery(); // Execute the insert query

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tài khoản đã được thêm thành công!");
                        LoadData(); // Optionally, reload data or refresh the view
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }

            // Close the connection after the operation is done
            dbConnection.CloseConnection();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            // Get the input values from form controls
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string email = txtEmail.Text.Trim();  // Email is used to identify the account to update
            

            // Validate inputs
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // SQL Connection and Command
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open(); // Open the connection
                using (SqlCommand cmd = new SqlCommand("proc_SuaTaiKhoan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@Email", email);  // Email is used to identify which account to update
                    

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tài khoản đã được cập nhật thành công!");
                            LoadData(); // Refresh the DataGridView or any other controls showing the data
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật tài khoản thất bại. Vui lòng thử lại.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                    }
                }
            }
        }

        private void btnDelete_Click_Click(object sender, EventArgs e)
        {
            
            // Check if a user is selected (assuming this is done via a DataGridView)
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                string email = dgvTaiKhoan.SelectedRows[0].Cells["Email"].Value.ToString(); // Get the email from the selected row

                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand("proc_XoaTaiKhoan", connection, transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Email", email);

                            try
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    LoadData(); // Refresh the data display
                                    MessageBox.Show("Xóa tài khoản thành công!");
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Không tìm thấy tài khoản để xóa.");
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadData()
        {
            // Save the current selection of the ComboBox
            var currentSelection = cmbRole.SelectedValue;

            // Reload DataGridView
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TAIKHOAN", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvTaiKhoan.DataSource = dt; // Bind the data to the DataGridView
                    }
                }
            }

            

            // Restore the ComboBox selection
            if (currentSelection != null)
            {
                cmbRole.SelectedValue = currentSelection;
            }
        }



        private void btnTimKiem_Click_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();

            // Check if the input is empty
            if (string.IsNullOrEmpty(timKiem))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                // Use the function to perform the search
                string query = "SELECT * FROM dbo.func_TimKiemTaiKhoan(@TimKiem)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TimKiem", timKiem);

                    // Execute the query and bind the results to the DataGridView
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dgvTaiKhoan.DataSource = dt;
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            
            // Save the current ComboBox selection before resetting
            var currentSelection = cmbRole.SelectedValue;

            // Reset the form fields
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtEmail.Text = "";
            txtTimKiem.Text = "";

            // Optionally, clear the DataGridView or reset it to its default state
            dgvTaiKhoan.DataSource = null;

            // If you want to reload the data, you can call the LoadData method again
            LoadData();  // This will reload the DataGridView data

            // Restore the ComboBox selection to the previously selected value (Admin/User)
            if (currentSelection != null)
            {
                cmbRole.SelectedValue = currentSelection;
            }

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedValue != null)
            {
                int selectedRoleId = (int)cmbRole.SelectedValue;
                string query = "SELECT * FROM TAIKHOAN WHERE RoleID = @RoleID";
                SqlParameter[] parameters = { new SqlParameter("@RoleID", selectedRoleId) };

                dgvTaiKhoan.DataSource = ExecuteQuery(query, parameters);
            }
        }

        

        private void dgvTaiKhoan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PopulateFieldsFromGrid(e.RowIndex);
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTaiKhoan_CellClick_1(sender, e); // Redirect to CellClick logic
        }
        private void PopulateFieldsFromGrid(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[rowIndex];
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return false;
            }

            if (cmbRole.SelectedValue == null || (int)cmbRole.SelectedValue == 0)
            {
                MessageBox.Show("Vui lòng chọn vai trò.");
                return false;
            }

            return true;
        }
        private DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection()) // Adjust to your connection method
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters); // Add parameters if any
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt); // Fill the DataTable with query results
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }

            return dt;
        }


    }
}

