using DBMS_NoiThat.user9;
using Do_An_Tuyen_Dung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DBMS_NoiThat.user
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        public static string TenDangNhap { get; private set; }
        Modify modify = new Modify();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
                

            string tentk = txtTenTK.Text;
            TenDangNhap = tentk;
            string matkhau = txtMatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                DataTable dt = new DataTable();
                string query = "Select * from TAIKHOAN where TenDangNhap  = '" + tentk + "' and MatKhau  = '" + matkhau + "'";
                //string query = "SELECT TAIKHOAN.TenDangNhap, TAIKHOAN.MatKhau, KHACHHANG.Email, KHACHHANG.MaKhachHang" +
                //    "FROM TAIKHOAN" +
                //    "JOIN KHACHHANG ON TAIKHOAN.Email = KHACHHANG.Email";
                // truy vấn tên trùng mới cho vô ?
                string query1 = "SELECT TenDangNhap,RoleID FROM TAIKHOAN Where TenDangNhap = @TenDangNhap";
                modify.TaiDuLieu(dt, query1, "@TenDangNhap", txtTenTK.Text);
                if (modify.taiKhoans(query).Count != 0)
                {
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (DataRow row in dt.Rows)
                    {
                        string ten = row["TenDangNhap"].ToString();
                        //string queryCustomer = "SELECT KHACHHANG.MaKhachHang FROM TAIKHOAN " +
                        //        "JOIN KHACHHANG ON TAIKHOAN.Email = KHACHHANG.Email" +
                        //        "where TenDangNhap = @TenDangNhap";
                        //int? maKhachHang = row["MaKhachHang"] != DBNull.Value ? (int?)Convert.ToInt32(row["MaKhachHang"]) : null;

                        if (ten == txtTenTK.Text)
                        {
                            int role = Convert.ToInt32(row["RoleID"]);
                            
                            if (role == 2)
                            {
                                FDangNhap flogin = new FDangNhap();
                                MainFormKhachHang mainForm = new MainFormKhachHang(ten);
                                mainForm.ShowDialog();
                                break;
                            }
                            else
                            {
                                FDangNhap flogin = new FDangNhap();
                                MainFormAdmin mainForm = new MainFormAdmin(ten);
                                mainForm.ShowDialog();
                                break;
                            }
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
