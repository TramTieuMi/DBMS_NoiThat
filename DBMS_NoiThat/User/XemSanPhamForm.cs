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


namespace DBMS_NoiThat.user
{
    public partial class XemSanPhamForm : Form
    {
        DBConnection conn = new DBConnection();
        public int idKhachHang;
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
            dgvXemSanPham.ReadOnly = true;
            dgvXemSanPham.DataSource = null;
            dgvXemSanPham.DataSource = SPTable;
            dgvXemSanPham.Refresh();
            dgvXemSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgvXemSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvXemSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";
            dgvXemSanPham.Columns["GiaSanPham"].HeaderText = "Giá Sản Phẩm";
            dgvXemSanPham.Columns["MauSac"].HeaderText = "Màu Sắc";
            DataGridViewImageColumn piccol = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            piccol = (DataGridViewImageColumn)dgvXemSanPham.Columns["HinhAnh"];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dgvXemSanPham.RowTemplate.Height = 80;
            dgvXemSanPham.AllowUserToAddRows = false;
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
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
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
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
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
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

      

        private void dgvXemSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string id = dgvXemSanPham.CurrentRow.Cells[0].Value.ToString().Trim();
                int ID = Convert.ToInt32(id);

                DataTable table1 = new DataTable();
                conn.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_ChiTietSanPham(@MaSP)", conn.GetConnection());
                cmd.Parameters.AddWithValue("@MaSP", ID);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(table1);
                }
                conn.CloseConnection();
                //  dgvXemSanPham.DataSource = table1;
                ChiTietSanPhamForm xemtSPF = new ChiTietSanPhamForm();
                // thu tu cua cac cot: id fname Inane bd - gdr - phn - adrs - pic
                xemtSPF.idKH = idKhachHang;
                //MessageBox.Show(xemtSPF.idKH.ToString());

                xemtSPF.LableIDSP.Text = table1.Rows[0][0].ToString().Trim();
                xemtSPF.TextBoxTenSP.Text = table1.Rows[0][1].ToString().Trim();
                xemtSPF.TextBoxGiaSP.Text = table1.Rows[0][3].ToString().Trim();
                xemtSPF.textBoxChatLieu.Text = table1.Rows[0][4].ToString().Trim();
                xemtSPF.TextBoxKichThuoc.Text = table1.Rows[0][6].ToString().Trim();
                xemtSPF.TextBoxMoTa.Text = table1.Rows[0][5].ToString().Trim();
                xemtSPF.textBoxMauSac.Text = table1.Rows[0][7].ToString().Trim();
                byte[] pic;
                pic = (byte[])table1.Rows[0][2];
                MemoryStream picture = new MemoryStream(pic);
                xemtSPF.PictureBoxHinhAnhSP.Image = Image.FromStream(picture);

                xemtSPF.ShowDialog();
                //this.Show();
                 //xemtSPF.Show();
                conn.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XemSanPhamForm_Click(object sender, EventArgs e)
        {
            dgvXemSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDataToDataGridView();
        }
    }
}
