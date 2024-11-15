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
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_Click(object sender, EventArgs e)
        {
            // Gather input from textboxes
            string tenSanPham = TenSanPham.Text.Trim();
            string hinhAnh = HinhAnh.Text.Trim();
            string chatLieu = ChatLieu.Text.Trim();
            string moTa = MoTa.Text.Trim();
            string kichThuoc = KichThuoc.Text.Trim();
            string mauSac = MauSac.Text.Trim();
            decimal giaSanPham; // Price as decimal
            int soLuong;

            // Validate GiaSanPham
            if (!decimal.TryParse(GiaSanPham.Text.Trim(), out giaSanPham))
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ.");
                return;
            }

            // Validate SoLuong
            if (!int.TryParse(SoLuong.Text.Trim(), out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            // Add product to the database
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open(); // Open the connection
                using (SqlCommand cmd = new SqlCommand("proc_ThemSanPham", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding parameters (excluding MaSanPham)
                    cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                    cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                    cmd.Parameters.AddWithValue("@GiaSanPham", giaSanPham);
                    cmd.Parameters.AddWithValue("@ChatLieu", chatLieu);
                    cmd.Parameters.AddWithValue("@MoTa", moTa);
                    cmd.Parameters.AddWithValue("@KichThuoc", kichThuoc);
                    cmd.Parameters.AddWithValue("@MauSac", mauSac);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sản phẩm đã được thêm thành công!");
                            LoadData(); // Refresh the data display
                        }
                        else
                        {
                            MessageBox.Show("Thêm sản phẩm thất bại!");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                    }
                }
            } // Connection is automatically closed here
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSanPham.Rows[e.RowIndex];
                MaSanPham.Text = row.Cells["MaSanPham"].Value.ToString();
                TenSanPham.Text = row.Cells["TenSanPham"].Value.ToString();
                HinhAnh.Text = row.Cells["HinhAnh"].Value.ToString();
                GiaSanPham.Text = row.Cells["GiaSanPham"].Value.ToString();
                ChatLieu.Text = row.Cells["ChatLieu"].Value.ToString();
                MoTa.Text = row.Cells["MoTa"].Value.ToString();
                KichThuoc.Text = row.Cells["KichThuoc"].Value.ToString();
                MauSac.Text = row.Cells["MauSac"].Value.ToString();
                SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            }
        }

        private void btnEdit_Click_Click(object sender, EventArgs e)
        {
            string maSanPham = MaSanPham.Text;
            string tenSanPham = TenSanPham.Text;
            string hinhAnh = HinhAnh.Text;
            decimal giaSanPham;
            string chatLieu = ChatLieu.Text;
            string moTa = MoTa.Text;
            string kichThuoc = KichThuoc.Text;
            string mauSac = MauSac.Text;
            int soLuong;

            if (!decimal.TryParse(GiaSanPham.Text, out giaSanPham))
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ.");
                return;
            }

            if (!int.TryParse(SoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                return;
            }

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("proc_SuaSanPham", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding parameters
                    cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    cmd.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                    cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                    cmd.Parameters.AddWithValue("@GiaSanPham", giaSanPham);
                    cmd.Parameters.AddWithValue("@ChatLieu", chatLieu);
                    cmd.Parameters.AddWithValue("@MoTa", moTa);
                    cmd.Parameters.AddWithValue("@KichThuoc", kichThuoc);
                    cmd.Parameters.AddWithValue("@MauSac", mauSac);
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sản phẩm đã được cập nhật thành công!");
                            LoadData(); // Refresh the data display
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật sản phẩm thất bại!");
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
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                string maSanPham = dgvSanPham.SelectedRows[0].Cells["MaSanPham"].Value.ToString();

                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("proc_XoaSanPham", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaSanPham", maSanPham);

                        try
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa sản phẩm thành công!");
                                LoadData(); // Refresh the data display
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sản phẩm để xóa.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void LoadData()
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SANPHAM", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvSanPham.DataSource = dt; // Bind the data to the DataGridView
                    }
                }
            }
        }

        private void btnTimKiem_Click_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text;
            

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.func_TimKiemSanPham(@TimKiem, @TheoTenSanPham, @TheoChatLieu)", conn))
                {
                    cmd.Parameters.AddWithValue("@TimKiem", timKiem);
                    
                 

                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dgvSanPham.DataSource = dt; // Bind the results to the DataGridView
                    }
                }
            }
        }
    }
}
  
