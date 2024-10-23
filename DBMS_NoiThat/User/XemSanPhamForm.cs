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

namespace DBMS_NoiThat
{
   
    public partial class XemSanPhamForm : Form
    {
        DBConnection conn = new DBConnection();
        public XemSanPhamForm()
        {
            InitializeComponent();
            dgvXemSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            DataTable SPTable = new DataTable();
            conn.OpenConnection();
            SqlCommand cmd = new SqlCommand("select * from v_XemSanPham", conn.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(SPTable);
            dgvXemSanPham.DataSource = null;
            dgvXemSanPham.DataSource = SPTable;
            dgvXemSanPham.Refresh();
            dgvXemSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvXemSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvXemSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
            dgvXemSanPham.Columns["GiaSanPham"].HeaderText = "Giá Sản Phẩm";
            dgvXemSanPham.Columns["MauSac"].HeaderText = "Màu Sắc";
            conn.CloseConnection();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string find = textBoxTimKiem.Text.Trim();

            if (radioButtonGia.Checked == true)
            {
                string GiaFrom = textBoxFrom.Text.Trim();
                decimal giaFrom = Convert.ToDecimal(GiaFrom);

                string GiaTo = textBoxTo.Text.Trim();
                decimal giaTo = Convert.ToDecimal(GiaTo);

                try
                {
                    conn.OpenConnection();
                    SqlCommand cmd = new SqlCommand("proc_TimKiemTheoGia", conn.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@GiaFrom", giaFrom);
                    cmd.Parameters.AddWithValue("@GiaTo", giaTo);
                    DataTable table = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                    dgvXemSanPham.DataSource = table;
                    conn.CloseConnection();

                }
                catch { Exception ex; }
            }
            else if (radioButtonTenSP.Checked == true)
            {
                try
                {
                    conn.OpenConnection();
                    SqlCommand cmd1 = new SqlCommand("proc_TimKiemTheoTen", conn.GetConnection());
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Ten", find);
                    DataTable table1 = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd1))
                    {
                        adapter.Fill(table1);
                    }
                    dgvXemSanPham.DataSource = table1;
                    conn.CloseConnection();

                }
                catch { Exception ex; }
            }
            else
            {
                try
                {
                    conn.OpenConnection();
                    SqlCommand cmd1 = new SqlCommand("proc_TimKiemTheoMau", conn.GetConnection());
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@Mau", find);
                    DataTable table1 = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd1))
                    {
                        adapter.Fill(table1);
                    }
                    dgvXemSanPham.DataSource = table1;
                    conn.CloseConnection();

                }
                catch { Exception ex; }
            }
        }

        private void XemSanPhamForm_Load(object sender, EventArgs e)
        {
            dgvXemSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDataToDataGridView();
        }

        private void dgvXemSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dgvXemSanPham.CurrentRow.Cells[0].Value.ToString().Trim();
                int ID = Convert.ToInt32(id);
                conn.OpenConnection();
                SqlCommand cmd1 = new SqlCommand("proc_ChiTietSanPham", conn.GetConnection());
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@MaSP", ID);
                DataTable table1 = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd1))
                {
                    adapter.Fill(table1);
                }
                //  dgvXemSanPham.DataSource = table1;
                ChiTietSanPhamForm updateDeletStdF = new ChiTietSanPhamForm();
                // thu tu cua cac cot: id fname Inane bd - gdr - phn - adrs - pic

                updateDeletStdF.TextBoxIDSP.Text = table1.Rows[0][0].ToString().Trim();
                updateDeletStdF.TextBoxTenSP.Text = table1.Rows[0][1].ToString().Trim();
                updateDeletStdF.TextBoxGiaSP.Text = table1.Rows[0][3].ToString().Trim();
                updateDeletStdF.textBoxChatLieu.Text = table1.Rows[0][4].ToString().Trim();
                updateDeletStdF.TextBoxKichThuoc.Text = table1.Rows[0][6].ToString().Trim();
                updateDeletStdF.TextBoxMoTa.Text = table1.Rows[0][5].ToString().Trim();
                updateDeletStdF.textBoxMauSac.Text = table1.Rows[0][7].ToString().Trim();
                //byte[] pic;
                //    pic = (byte[])dgvXemSanPham.CurrentRow.Cells[2].Value;
                //    MemoryStream picture = new MemoryStream(pic);
                //    updateDeletStdF.PictureBoxHinhAnhSP.Image = Image.FromStream(picture);

                updateDeletStdF.ShowDialog();
                //this.Show();
                //    updateDeletStdF.Show();
                conn.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
