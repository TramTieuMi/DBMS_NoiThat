using DBMS_NoiThat.user;
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

namespace DBMS_NoiThat.admin
{
    public partial class ThongKeDoanhThu : Form
    {
        DBConnection conn = new DBConnection();


        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void buttonSPBanChay_Click(object sender, EventArgs e)
        {
            labelDoanhThu.Text = "Tổng Doanh Thu:";
            try
            {
                BieuDoCot.Series["SanPham"].Points.Clear();
                if (radioButton1Ngay.Checked == true)
                {
                    BieuDoCot.Series.Clear();
                    BieuDoCot.Series.Add("SanPham");
                    int yy = Convert.ToInt32(numericUpDownYear.Text);
                    int mm = Convert.ToInt32(comboBoxMonth.Text);
                    int dd = Convert.ToInt32(comboBox1Ngay.Text);
                    DataTable table = new DataTable();
                    conn.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetSanPhamBanChayNgay(@yy, @mm, @dd) ORDER BY [Số Lượng] DESC", conn.GetConnection());
                    cmd.Parameters.AddWithValue("@yy", yy);
                    cmd.Parameters.AddWithValue("@mm", mm);
                    cmd.Parameters.AddWithValue("@dd", dd);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewDT.DataSource = table;
                    dataGridViewDT.AllowUserToAddRows = false;
                    dataGridViewDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    try
                    {
                        int len = this.dataGridViewDT.Rows.Count;
                        for (int i = 0; i < len; i++)
                        {

                            string s = dataGridViewDT.Rows[i].Cells[1].Value.ToString();
                            string k = dataGridViewDT.Rows[i].Cells[0].Value.ToString();
                            double kq = Convert.ToDouble(k);
                            BieuDoCot.Series["SanPham"].Points.AddXY(s, k);
                        }
                    }
                    catch (NullReferenceException ee)
                    {
                        ee.InnerException.ToString();
                    }


                }
                if (radioButton1Thang.Checked == true)
                {
                    BieuDoCot.Series.Clear();
                    BieuDoCot.Series.Add("SanPham");
                    int yy = Convert.ToInt32(numericUpDownYear.Text);
                    int mm = Convert.ToInt32(comboBoxMonth.Text);


                    DataTable table = new DataTable();
                    conn.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetSanPhamBanChayThang(@yy, @mm) ORDER BY [Số Lượng] DESC", conn.GetConnection());
                    cmd.Parameters.AddWithValue("@yy", yy);
                    cmd.Parameters.AddWithValue("@mm", mm);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewDT.DataSource = table;
                    dataGridViewDT.AllowUserToAddRows = false;
                    dataGridViewDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    try
                    {
                        int len = this.dataGridViewDT.Rows.Count;
                        for (int i = 0; i < len; i++)
                        {

                            string s = dataGridViewDT.Rows[i].Cells[1].Value.ToString();
                            string k = dataGridViewDT.Rows[i].Cells[0].Value.ToString();
                            double kq = Convert.ToDouble(k);
                            BieuDoCot.Series["SanPham"].Points.AddXY(s, k);
                        }
                    }
                    catch (NullReferenceException ee)
                    {
                        ee.InnerException.ToString();
                    }

                }
                if (radioButtonNam.Checked == true)
                {
                    BieuDoCot.Series.Clear();
                    BieuDoCot.Series.Add("SanPham");
                    int yy = Convert.ToInt32(numericUpDownYear.Text);

                    DataTable table = new DataTable();
                    conn.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetSanPhamBanChayNam(@yy) ORDER BY [Số Lượng] DESC", conn.GetConnection());
                    cmd.Parameters.AddWithValue("@yy", yy);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewDT.DataSource = table;
                    dataGridViewDT.AllowUserToAddRows = false;
                    dataGridViewDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    try
                    {
                        int len = this.dataGridViewDT.Rows.Count;
                        for (int i = 0; i < len; i++)
                        {

                            string s = dataGridViewDT.Rows[i].Cells[1].Value.ToString();
                            string k = dataGridViewDT.Rows[i].Cells[0].Value.ToString();
                            double kq = Convert.ToDouble(k);
                            BieuDoCot.Series["SanPham"].Points.AddXY(s, k);
                        }
                    }
                    catch (NullReferenceException ee)
                    {
                        ee.InnerException.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1Ngay.Checked == true)
                {
                    int yy = Convert.ToInt32(numericUpDownYear.Text);
                    int mm = Convert.ToInt32(comboBoxMonth.Text);
                    int dd = Convert.ToInt32(comboBox1Ngay.Text);
                    DataTable table = new DataTable();
                    conn.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetDonHangDaGiaoNgayThangNam(@yy, @mm, @dd)", conn.GetConnection());
                    cmd.Parameters.AddWithValue("@yy", yy);
                    cmd.Parameters.AddWithValue("@mm", mm);
                    cmd.Parameters.AddWithValue("@dd", dd);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewDT.DataSource = table;
                    dataGridViewDT.AllowUserToAddRows = false;
                    dataGridViewDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    int totalSalary = 0;
                    foreach (DataRow row in table.Rows)
                    {
                        totalSalary += (int)row["TongTien"];
                    }
                    labelDoanhThu.Text = "TỔNG DOANH THU LÀ: " + totalSalary.ToString() + "VNĐ";

                }
                if (radioButton1Thang.Checked == true)
                {
                    int yy = Convert.ToInt32(numericUpDownYear.Text);
                    int mm = Convert.ToInt32(comboBoxMonth.Text);


                    DataTable table = new DataTable();
                    conn.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetDonHangDaGiaoThangNam(@yy, @mm)", conn.GetConnection());
                    cmd.Parameters.AddWithValue("@yy", yy);
                    cmd.Parameters.AddWithValue("@mm", mm);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewDT.DataSource = table;
                    dataGridViewDT.AllowUserToAddRows = false;
                    dataGridViewDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    int totalSalary = 0;
                    foreach (DataRow row in table.Rows)
                    {
                        totalSalary += (int)row["TongTien"];
                    }
                    labelDoanhThu.Text = "TỔNG DOANH THU LÀ: " + totalSalary.ToString() + "VNĐ";

                }
                if (radioButtonNam.Checked == true)
                {
                    int yy = Convert.ToInt32(numericUpDownYear.Text);
                    DataTable table = new DataTable();
                    conn.OpenConnection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetDonHangDaGiaoNam(@yy)", conn.GetConnection());
                    cmd.Parameters.AddWithValue("@yy", yy);


                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                    dataGridViewDT.DataSource = table;
                    dataGridViewDT.AllowUserToAddRows = false;
                    dataGridViewDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    int totalSalary = 0;
                    foreach (DataRow row in table.Rows)
                    {
                        totalSalary += (int)row["TongTien"];
                    }
                    labelDoanhThu.Text = "TỔNG DOANH THU LÀ: " + totalSalary.ToString() + "VNĐ";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
