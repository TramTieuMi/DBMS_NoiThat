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

        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string email = txtEmail.Text;
            int roleId;

            // Assuming role ID is selected from a ComboBox
            if (!int.TryParse(cmbRoleID.SelectedValue.ToString(), out roleId))
            {
                MessageBox.Show("Vui lòng chọn một Role ID hợp lệ");
                return;
            }

            // Get the SQL connection from the Connection class
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open(); // Open the connection

                using (SqlCommand cmd = new SqlCommand("proc_ThemTaiKhoan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding parameters
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@RoleID", roleId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tài khoản đã được thêm thành công!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
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
            } // Connection is automatically closed here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string email = txtEmail.Text;
            int roleId;

            // Assuming role ID is selected from a ComboBox
            if (!int.TryParse(cmbRoleID.SelectedValue.ToString(), out roleId))
            {
                MessageBox.Show("Vui lòng chọn một Role ID hợp lệ");
                return;
            }

            // Get the SQL connection from the Connection class
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open(); // Open the connection

                using (SqlCommand cmd = new SqlCommand("proc_SuaTaiKhoan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding parameters
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@RoleID", roleId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tài khoản đã được cập nhật thành công!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật tài khoản thất bại!");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                    }
                }
            } // Connection is automatically closed here
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
            // Assuming you have a DataGridView named dgvUsers to display the user accounts.
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM TAIKHOAN", connection)) // Adjust query as needed
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvTaiKhoan.DataSource = dt; // Bind the data to the DataGridView
                    }
                }
            }
        }

        private void btnTimKiem_Click_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text; 
            bool theoEmail = chkEmail.Checked; 
            bool theoTenDangNhap = chkTenDangNhap.Checked; 

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                // Prepare the command to call the function
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.func_TimKiemTaiKhoan(@TimKiem, @TheoEmail, @TheoTenDangNhap)", connection))
                {
                    cmd.Parameters.AddWithValue("@TimKiem", timKiem);
                    cmd.Parameters.AddWithValue("@TheoEmail", theoEmail ? 1 : 0);
                    cmd.Parameters.AddWithValue("@TheoTenDangNhap", theoTenDangNhap ? 1 : 0);

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(dt);

                    dgvTaiKhoan.DataSource = null; // Assuming you have a DataGridView for displaying results

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dgvTaiKhoan.DataSource = dt; // Bind the results to the DataGridView
                    }
                }

                connection.Close(); // Connection is automatically closed by the using statement
            }
        }

        private void chkTenDangNhap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoleID_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {

        }
    }
}
