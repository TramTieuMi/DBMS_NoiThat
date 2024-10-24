using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{

    public partial class QuanLyDonHangForm : Form
    {
        DBConnection conn = new DBConnection();
        public QuanLyDonHangForm()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            DataTable SPTable = new DataTable();
            conn.OpenConnection();
            SqlCommand cmd = new SqlCommand("select * from v_XemDonHang", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(SPTable);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SPTable;
            dataGridView1.Refresh();
            dataGridView1.Columns["MaDonHang"].HeaderText = "Mã Đơn Hàng";
            dataGridView1.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dataGridView1.Columns["MaKhachHang"].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns["TenNguoiDat"].HeaderText = "Tên Người Đặt";
            dataGridView1.Columns["SDTNguoiDat"].HeaderText = "SĐT Người Đặt";
            dataGridView1.Columns["TenNguoiNhan"].HeaderText = "Tên Người Nhận";
            dataGridView1.Columns["SDTNguoiNhan"].HeaderText = "SĐT Người Nhận";
            dataGridView1.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dataGridView1.Columns["NgayMuaHang"].HeaderText = "Ngày Mua Hàng";
            dataGridView1.Columns["DiaChiNhan"].HeaderText = "Địa Chỉ Nhận";
            dataGridView1.Columns["TrangThai"].HeaderText = "Trạng Thái";
            conn.CloseConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                TextBoxMaDonHang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                textBoxMaSanPham.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                TextBoxMaKhachHang.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                textBoxTenNguoiDat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
                textBoxSDTNguoiDat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
                textBoxTenNguoiNhan.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
                textBoxSĐTNguoiNhan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
                textBoxTongTien.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();
                textBoxNgayMuaHang.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString().Trim();
                textBoxDiaChiNhan.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString().Trim();

                string status = dataGridView1.CurrentRow.Cells[10].Value.ToString().Trim();

                if (status == "Ðang chờ xác nhận".Trim())
                {

                    radioButtonChoXN.Checked = true;
                }
                else if (status == "Ðã xác nhận")
                {

                    radioButtonDaXN.Checked = true;
                }
                else if (status == "Ðã giao")
                {
                    radioButtonGiao.Checked = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonDangChoXN_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand("proc_LocTrangThaiDonHang", conn.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Status", "Ðang chờ xác nhận");
                DataTable table = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
                dataGridView1.DataSource = table;
                conn.CloseConnection();

            }
            catch { Exception ex; }
        }

        private void radioButtonDaXacNhan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand("proc_LocTrangThaiDonHang", conn.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Status", "Ðã xác nhận");
                DataTable table = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
                dataGridView1.DataSource = table;
                conn.CloseConnection();

            }
            catch { Exception ex; }
        }

        private void radioButtonDaGiao_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand("proc_LocTrangThaiDonHang", conn.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Status", "Ðã giao");
                DataTable table = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
                dataGridView1.DataSource = table;
                conn.CloseConnection();

            }
            catch { Exception ex; }
        }

        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Mã Đơn Hàng")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.Black;
            }
        }

        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "")
            {
                textBoxTimKiem.Text = "Mã Đơn Hàng";
                textBoxTimKiem.ForeColor = Color.DarkGray;
            }
        }

        private void QuanLyDonHangForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDataToDataGridView();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            int idDonHang = Convert.ToInt32(textBoxTimKiem.Text);
            conn.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_TimKiemDonHangTheoMaDonHang", conn.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDon", idDonHang);
            DataTable table = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }
            dataGridView1.DataSource = table;
            conn.CloseConnection();
        }

        private void buttonCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            int idDonHang = Convert.ToInt32(TextBoxMaDonHang.Text);
            string status;
            if (radioButtonChoXN.Checked == true)
            {
                status = "Ðang chờ xác nhận";
            }
            else if (radioButtonDaXN.Checked == true)
            {
                status = "Ðã xác nhận";
            }
            else
            {
                status = "Ðã giao";
            }
            conn.OpenConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_UpdateTrangThaiDonHang", conn.GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDonHang", idDonHang);
                cmd.Parameters.AddWithValue("@TrangThai", status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                LoadDataToDataGridView();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực hiện hàm thủ tục SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.CloseConnection();
        }
    }
}
