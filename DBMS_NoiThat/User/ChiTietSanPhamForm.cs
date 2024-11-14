using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;



namespace DBMS_NoiThat.user
{
    public partial class ChiTietSanPhamForm : Form
    {
        DBConnection mydb = new DBConnection();
        public int idKH;
        public ChiTietSanPhamForm()
        {
            

            InitializeComponent();
        }

        private void ButtonTroVe_Click(object sender, EventArgs e)
        {
            try
            {
               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonThemVaoGio_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra xem sản phẩm đó có tồn tại chưa rồi mới thêm
                int id = Convert.ToInt32(LableIDSP.Text);
                mydb.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT dbo.KiemTraGioHangTonTai(@MaDonHang, @MaSanPham)", mydb.GetConnection());
                cmd.Parameters.AddWithValue("@MaDonHang", idKH);
                cmd.Parameters.AddWithValue("@MaSanPham", id);
                int status = (int)cmd.ExecuteScalar();
                mydb.CloseConnection();
                //kiểm tra xem sản phẩm đó có tồn tại chưa rồi mới thêm
                if (status == 1) // nếu  đã thêm rồi...
                {
                    MessageBox.Show("Sản Phẩm Này Đã Được Thêm Vào Thêm Giỏ Hàng Của Bạn Trước Đó", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (status == 0) // chưa có thêm...
                {
                    decimal giaTo = Convert.ToDecimal(TextBoxGiaSP.Text);
                    int giaSP = Convert.ToInt32(giaTo);
                    int sl = Convert.ToInt32(domainUpDownSoLuong.Text);
                    mydb.OpenConnection();
                    try
                    {
                        SqlCommand cmd1 = new SqlCommand("proc_ThemVaoGioHang", mydb.GetConnection());
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@MaGioHang", idKH);
                        cmd1.Parameters.AddWithValue("@MaSanPham", id);
                        cmd1.Parameters.AddWithValue("@SoLuong", sl);
                       // cmd1.Parameters.AddWithValue("@SoTien", giaSP * sl);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Lỗi khi thực hiện thủ tục SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    mydb.CloseConnection();
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực hiện thủ tục SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    OpenFileDialog open = new OpenFileDialog();
            //    open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            //    if ((open.ShowDialog() == DialogResult.OK))
            //    {
            //        PictureBoxHinhAnhSP.Image = Image.FromFile(open.FileName);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //int id = Convert.ToInt32(LableIDSP.Text);

            //MemoryStream picture = new MemoryStream();
            //PictureBoxHinhAnhSP.Image.Save(picture, PictureBoxHinhAnhSP.Image.RawFormat);
            //SqlCommand command = new SqlCommand("UPDATE SANPHAM SET HinhAnh=@pic WHERE MaSanPham=@ID", mydb.GetConnection());
            //command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            //command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            //mydb.OpenConnection();

            //if ((command.ExecuteNonQuery() == 1))
            //{
            //    mydb.CloseConnection();

            //}
            //else
            //{
            //    mydb.CloseConnection();

            }
            else
            {
                mydb.CloseConnection();

            }
        }

        
    }
}
