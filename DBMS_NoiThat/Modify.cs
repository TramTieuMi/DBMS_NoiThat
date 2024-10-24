using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Do_An_Tuyen_Dung
{
    internal class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; //dung de truy van cac cau lenh Insert,Update, Delete...
        SqlDataReader dataReader; //dung de doc du lieu trong bang


        public List<TaiKhoan> taiKhoans(string query)// check tai khoan 
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query) // dung de dang ki tai khoan
        {
            using (SqlConnection sqlConnection =Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();// thuc thi cau truy van
                sqlConnection.Close();
            }
        }

        // hàm tải dữ liệu từ SQL
        public void TaiDuLieu(DataTable dataTable, string sqlQuery, string thuocTinh, string khoaChinh)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue(thuocTinh, khoaChinh);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {

                        adapter.Fill(dataTable);

                    }
                }
                conn.Close();
            }
        }
        //public void OpenChildForm(Form currentFormChild,Form childForm,Panel panel2)
        //{
        //    if (currentFormChild != null)
        //    {
        //        currentFormChild.Close();
        //    }
        //    currentFormChild = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panel2.Controls.Add(childForm);
        //    panel2.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}
    }
}
