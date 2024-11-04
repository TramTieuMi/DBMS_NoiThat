using Do_An_Tuyen_Dung;
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
    public partial class XemThongTinUser : Form
    {
        Modify modify = new Modify();
        SqlConnection connStr = Connection.GetSqlConnection();
        public XemThongTinUser()
        {
            InitializeComponent();
            ThucThi(FDangNhap.TenDangNhap); /////////////////////////////////////////////////////////////////////////
        }
        public XemThongTinUser(string tenUV, string email)
        {
            InitializeComponent();
            string tenTK = KiemTK(email);
            ThucThi(tenTK);
        }

        private void XemProfileUser_Load(object sender, EventArgs e)
        {

        }

        public string KiemTK(string email)
        {
            string tk = string.Empty;
            string query = "SELECT TenDangNhap,Email FROM TAIKHOAN";
            SqlCommand command = new SqlCommand(query, connStr);
            connStr.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["Email"].ToString() == email)
                {
                    tk = reader["TenDangNhap"].ToString();
                    break;
                }
            }
            return tk;
        }


        public void ThucThi(string tenTK)
        {
            //đoạn này chưa đụng đến nha

            FDangNhap fLogin = new FDangNhap();
            string em = "VanKien@gmail.com";
            DataTable dataTable = new DataTable(); 
            string sqlQuery = "SELECT HovaTen,Email,DiaChi,SDT FROM KHACHHANG WHERE Email = @Email";


            DataTable dataTable1 = new DataTable();
            string sqlQuery1 = "SELECT * FROM View_ThongTinTaiKhoanUser where TenDangNhap = @TenDangNhap";
            modify.TaiDuLieu(dataTable1, sqlQuery1, "@TenDangNhap", tenTK);
            if (dataTable1.Rows.Count > 0)
            {
                foreach (DataRow row1 in dataTable1.Rows)
                {
                    string TenTK = row1["TenDangNhap"].ToString();
                    if (TenTK == tenTK)
                    {
                        em = row1["Email"].ToString();
                    }
                }
            }

            modify.TaiDuLieu(dataTable, sqlQuery, "@Email", em);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string email = row["Email"].ToString();
                    if (email == em)
                    {
                        txtHoTen.Text = row["HovaTen"].ToString();
                        txtDiaChi.Text = row["DiaChi"].ToString();
                        txtSdt.Text = row["SDT"].ToString(); 
                        txtEmail.Text = row["Email"].ToString(); 

                    }
                }
            }
        }

    }
}
